using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ServiceCore;
using Efues.Utility;

namespace WinServiceInstall
{
  public partial class MainForm : Form
  {
    private readonly Setting setting = new Setting();

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      textBoxServiceName.Text = setting.ServiceName;
      textBoxServiceDescription.Text = setting.Description;
      textBoxLoopInterval.Text = setting.LoopInterval.ToString();
      if(!IsAdministrator)
      {
        MessageBox.Show("This Application have to be executed by Administrator", "Windows Service Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.Close();
      }

      UpdateInstallStatus();
      textBoxInstallCmd1.Text = @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe";
    }

    private void buttonExecuteOnce_Click(object sender, EventArgs e)
    {
      try
      {
        EntryPoint.Execute();
      }
      catch (Exception exp)
      {
        MessageBox.Show(exp.Message);
        Log.WriteError(exp);
      }
    }

    private int loopCnt = 0;
    private void buttonExecuteLoop_Click(object sender, EventArgs e)
    {
      try
      {
        if (timer.Enabled)
        {
          timer.Stop();
          buttonExecuteLoop.Text = "Execute Loop";
        }
        else
        {
          timer.Interval = setting.LoopInterval;
          timer.Start();
          buttonExecuteLoop.Text = "Stop Loop";
        }
      }
      catch (Exception exp)
      {
        MessageBox.Show(exp.Message);
        Log.WriteError(exp);
      }
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      EntryPoint.Execute();

      textBoxLoopCnt.Text = (loopCnt++).ToString();
    }


    private void buttonInstall_Click(object sender, EventArgs e)
    {
      try
      {
        var process = new System.Diagnostics.Process();
        process.StartInfo.FileName = textBoxInstallCmd1.Text;
        process.StartInfo.Arguments = textBoxInstallCmd2.Text;

        process.StartInfo.CreateNoWindow = true;            // DOSプロンプトの黒い画面を非表示
        process.StartInfo.UseShellExecute = false;          // プロセスを新しいウィンドウで起動するか否か
        process.StartInfo.RedirectStandardOutput = true;    // 標準出力をリダイレクトして取得したい

        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        output.Replace("\r\r\n", "\n"); // 改行コード変換

        textBoxStatus.Text = output;
        UpdateInstallStatus();
      }
      catch (Exception exp)
      {
        textBoxStatus.Text += exp.Message;
      }
    }

    #region Inner Method
    private bool IsAdministrator
    {
      get
      {
        var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
        var principal = new System.Security.Principal.WindowsPrincipal(identity);
        return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
      }
    }
    private void UpdateInstallStatus()
    {
      var serviceName = setting.ServiceName;
      var arg = "";
      if (System.ServiceProcess.ServiceController.GetServices().Where(service => service.ServiceName == serviceName).Any())
      {
        // すでにサービスが存在する
        buttonInstall.Text = "UnInstall";
        arg += "/u ";
      }
      else
      {
        // サービスは存在しない
        buttonInstall.Text = "Install";
      }
      arg += "WinServiceTemplate.exe";
      textBoxInstallCmd2.Text = arg;
    }
    #endregion
  }
}
