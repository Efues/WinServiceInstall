﻿namespace WinServiceTemplate
{
  partial class ProjectInstaller
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region コンポーネント デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.serviceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
      this.serviceInstaller = new System.ServiceProcess.ServiceInstaller();
      this.eventLog = new System.Diagnostics.EventLog();
      ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
      // 
      // serviceProcessInstaller
      // 
      this.serviceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
      this.serviceProcessInstaller.Password = null;
      this.serviceProcessInstaller.Username = null;
      // 
      // serviceInstaller
      // 
      this.serviceInstaller.DelayedAutoStart = true;
      this.serviceInstaller.Description = "empty";
      this.serviceInstaller.ServiceName = "WinService";
      this.serviceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
      // 
      // ProjectInstaller
      // 
      this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller,
            this.serviceInstaller});
      ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();

    }

    #endregion

    private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller;
    private System.ServiceProcess.ServiceInstaller serviceInstaller;
    private System.Diagnostics.EventLog eventLog;
  }
}