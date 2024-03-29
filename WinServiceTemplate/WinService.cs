﻿using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;
using System.Runtime.InteropServices;

using Efues.Utility;

using ServiceCore;

namespace WinServiceTemplate
{
  public partial class WinService : ServiceBase
  {
    private readonly Setting setting = new Setting();
    private readonly EntryPoint entryPoint = new EntryPoint();
    public WinService()
    {
      InitializeComponent();
      this.ServiceName = setting.ServiceName;
    }

    public enum ServiceState
    {
      SERVICE_STOPPED = 0x00000001,
      SERVICE_START_PENDING = 0x00000002,
      SERVICE_STOP_PENDING = 0x00000003,
      SERVICE_RUNNING = 0x00000004,
      SERVICE_CONTINUE_PENDING = 0x00000005,
      SERVICE_PAUSE_PENDING = 0x00000006,
      SERVICE_PAUSED = 0x00000007,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ServiceStatus
    {
      public int dwServiceType;
      public ServiceState dwCurrentState;
      public int dwControlsAccepted;
      public int dwWin32ExitCode;
      public int dwServiceSpecificExitCode;
      public int dwCheckPoint;
      public int dwWaitHint;
    };

    [DllImport("advapi32.dll", SetLastError = true)]
    private static extern bool SetServiceStatus(System.IntPtr handle, ref ServiceStatus serviceStatus);

    protected override void OnStart(string[] args)
    {
      // Update the service state to Start Pending.
      ServiceStatus serviceStatus = new ServiceStatus();
      serviceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING;
      serviceStatus.dwWaitHint = 100000;
      SetServiceStatus(this.ServiceHandle, ref serviceStatus);

      var timer = new Timer();
      timer.Interval = setting.LoopInterval   ;
      timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
      timer.Start();

      // Update the service state to Running.
      serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
      SetServiceStatus(this.ServiceHandle, ref serviceStatus);

      Log.Write("Service Started");
      entryPoint.Init();
    }

    protected override void OnStop()
    {
      // Update the service state to Stop Pending.
      ServiceStatus serviceStatus = new ServiceStatus();
      serviceStatus.dwCurrentState = ServiceState.SERVICE_STOP_PENDING;
      serviceStatus.dwWaitHint = 100000;
      SetServiceStatus(this.ServiceHandle, ref serviceStatus);

      // Update the service state to Stopped.
      serviceStatus.dwCurrentState = ServiceState.SERVICE_STOPPED;
      SetServiceStatus(this.ServiceHandle, ref serviceStatus);

      Log.Write("Service Stopped");
      entryPoint.Finish();
    }

    private void OnTimer(object sender, ElapsedEventArgs e)
    {
      entryPoint.Execute();
    }
  }
}
