using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

using ServiceCore;

namespace WinServiceTemplate
{
  [RunInstaller(true)]
  public partial class ProjectInstaller : System.Configuration.Install.Installer
  {
    public ProjectInstaller()
    {
      InitializeComponent();

      var setting = new Setting();
      serviceInstaller.Description = setting.Description;
      serviceInstaller.ServiceName = setting.ServiceName;
    }
  }
}
