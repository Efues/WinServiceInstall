﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinServiceTemplate
{
  static class Program
  {
    /// <summary>
    /// アプリケーションのメイン エントリ ポイントです。
    /// </summary>
    static void Main()
    {
      ServiceBase[] ServicesToRun;
      ServicesToRun = new ServiceBase[]
      {
        new WinService()
      };
      ServiceBase.Run(ServicesToRun);
    }
  }
}
