namespace WinServiceInstall
{
  partial class MainForm
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

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBoxLoopCnt = new System.Windows.Forms.TextBox();
      this.buttonExecuteLoop = new System.Windows.Forms.Button();
      this.buttonExecuteOnce = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textBoxInstallCmd2 = new System.Windows.Forms.TextBox();
      this.buttonInstall = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.textBoxStatus = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBoxInstallCmd1 = new System.Windows.Forms.TextBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxServiceDescription = new System.Windows.Forms.TextBox();
      this.textBoxServiceName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.textBoxLoopInterval = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.textBoxLoopCnt);
      this.groupBox1.Controls.Add(this.buttonExecuteLoop);
      this.groupBox1.Controls.Add(this.buttonExecuteOnce);
      this.groupBox1.Location = new System.Drawing.Point(12, 235);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(544, 68);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Test";
      // 
      // textBoxLoopCnt
      // 
      this.textBoxLoopCnt.Location = new System.Drawing.Point(430, 27);
      this.textBoxLoopCnt.Name = "textBoxLoopCnt";
      this.textBoxLoopCnt.Size = new System.Drawing.Size(100, 25);
      this.textBoxLoopCnt.TabIndex = 2;
      // 
      // buttonExecuteLoop
      // 
      this.buttonExecuteLoop.Location = new System.Drawing.Point(223, 24);
      this.buttonExecuteLoop.Name = "buttonExecuteLoop";
      this.buttonExecuteLoop.Size = new System.Drawing.Size(197, 30);
      this.buttonExecuteLoop.TabIndex = 1;
      this.buttonExecuteLoop.Text = "Execute Loop";
      this.buttonExecuteLoop.UseVisualStyleBackColor = true;
      this.buttonExecuteLoop.Click += new System.EventHandler(this.buttonExecuteLoop_Click);
      // 
      // buttonExecuteOnce
      // 
      this.buttonExecuteOnce.Location = new System.Drawing.Point(20, 24);
      this.buttonExecuteOnce.Name = "buttonExecuteOnce";
      this.buttonExecuteOnce.Size = new System.Drawing.Size(197, 30);
      this.buttonExecuteOnce.TabIndex = 0;
      this.buttonExecuteOnce.Text = "Execute Once";
      this.buttonExecuteOnce.UseVisualStyleBackColor = true;
      this.buttonExecuteOnce.Click += new System.EventHandler(this.buttonExecuteOnce_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.textBoxInstallCmd2);
      this.groupBox2.Controls.Add(this.buttonInstall);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.textBoxStatus);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.textBoxInstallCmd1);
      this.groupBox2.Location = new System.Drawing.Point(12, 309);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1072, 606);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Installer";
      // 
      // textBoxInstallCmd2
      // 
      this.textBoxInstallCmd2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxInstallCmd2.Location = new System.Drawing.Point(112, 56);
      this.textBoxInstallCmd2.Name = "textBoxInstallCmd2";
      this.textBoxInstallCmd2.ReadOnly = true;
      this.textBoxInstallCmd2.Size = new System.Drawing.Size(954, 25);
      this.textBoxInstallCmd2.TabIndex = 10;
      // 
      // buttonInstall
      // 
      this.buttonInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonInstall.Location = new System.Drawing.Point(916, 570);
      this.buttonInstall.Name = "buttonInstall";
      this.buttonInstall.Size = new System.Drawing.Size(150, 30);
      this.buttonInstall.TabIndex = 9;
      this.buttonInstall.Text = "Install";
      this.buttonInstall.UseVisualStyleBackColor = true;
      this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(0, 90);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(57, 18);
      this.label7.TabIndex = 3;
      this.label7.Text = "Status";
      // 
      // textBoxStatus
      // 
      this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxStatus.Location = new System.Drawing.Point(112, 87);
      this.textBoxStatus.Multiline = true;
      this.textBoxStatus.Name = "textBoxStatus";
      this.textBoxStatus.ReadOnly = true;
      this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxStatus.Size = new System.Drawing.Size(954, 471);
      this.textBoxStatus.TabIndex = 2;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 27);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(82, 18);
      this.label6.TabIndex = 1;
      this.label6.Text = "Command";
      // 
      // textBoxInstallCmd1
      // 
      this.textBoxInstallCmd1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxInstallCmd1.Location = new System.Drawing.Point(112, 24);
      this.textBoxInstallCmd1.Name = "textBoxInstallCmd1";
      this.textBoxInstallCmd1.ReadOnly = true;
      this.textBoxInstallCmd1.Size = new System.Drawing.Size(954, 25);
      this.textBoxInstallCmd1.TabIndex = 0;
      // 
      // groupBox4
      // 
      this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox4.Controls.Add(this.textBoxLoopInterval);
      this.groupBox4.Controls.Add(this.label5);
      this.groupBox4.Controls.Add(this.textBoxServiceDescription);
      this.groupBox4.Controls.Add(this.textBoxServiceName);
      this.groupBox4.Controls.Add(this.label3);
      this.groupBox4.Controls.Add(this.label2);
      this.groupBox4.Controls.Add(this.label1);
      this.groupBox4.Location = new System.Drawing.Point(12, 50);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(1072, 179);
      this.groupBox4.TabIndex = 2;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Configuration";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(325, 140);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(39, 18);
      this.label5.TabIndex = 8;
      this.label5.Text = "(ms)";
      // 
      // textBoxServiceDescription
      // 
      this.textBoxServiceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxServiceDescription.Location = new System.Drawing.Point(199, 56);
      this.textBoxServiceDescription.Multiline = true;
      this.textBoxServiceDescription.Name = "textBoxServiceDescription";
      this.textBoxServiceDescription.ReadOnly = true;
      this.textBoxServiceDescription.Size = new System.Drawing.Size(867, 73);
      this.textBoxServiceDescription.TabIndex = 6;
      // 
      // textBoxServiceName
      // 
      this.textBoxServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxServiceName.Location = new System.Drawing.Point(199, 24);
      this.textBoxServiceName.Name = "textBoxServiceName";
      this.textBoxServiceName.ReadOnly = true;
      this.textBoxServiceName.Size = new System.Drawing.Size(867, 25);
      this.textBoxServiceName.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(17, 137);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(106, 18);
      this.label3.TabIndex = 2;
      this.label3.Text = "Loop Interval";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(17, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(150, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Service Discription";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(113, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Service Name";
      // 
      // timer
      // 
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // textBoxLoopInterval
      // 
      this.textBoxLoopInterval.Location = new System.Drawing.Point(199, 137);
      this.textBoxLoopInterval.Name = "textBoxLoopInterval";
      this.textBoxLoopInterval.ReadOnly = true;
      this.textBoxLoopInterval.Size = new System.Drawing.Size(120, 25);
      this.textBoxLoopInterval.TabIndex = 9;
      this.textBoxLoopInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 18);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(275, 18);
      this.label4.TabIndex = 10;
      this.label4.Text = "At First, Edit \"ServiceCore.Setting\"";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1096, 927);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "Windows Service Instller";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button buttonExecuteLoop;
    private System.Windows.Forms.Button buttonExecuteOnce;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxServiceDescription;
    private System.Windows.Forms.TextBox textBoxServiceName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxInstallCmd1;
    private System.Windows.Forms.Button buttonInstall;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBoxStatus;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBoxInstallCmd2;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.TextBox textBoxLoopCnt;
    private System.Windows.Forms.TextBox textBoxLoopInterval;
    private System.Windows.Forms.Label label4;
  }
}

