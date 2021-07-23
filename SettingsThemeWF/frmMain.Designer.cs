
namespace SettingsThemeWF
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.cmdFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdView = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chbRememberMe = new System.Windows.Forms.CheckBox();
            this.bntLogin = new System.Windows.Forms.Button();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.picProgress = new System.Windows.Forms.PictureBox();
            this.mnuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdFile,
            this.cmdView,
            this.cmdHelp});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuTop.Size = new System.Drawing.Size(318, 24);
            this.mnuTop.TabIndex = 0;
            this.mnuTop.Text = "menuStrip1";
            // 
            // cmdFile
            // 
            this.cmdFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSettings,
            this.toolStripSeparator1,
            this.cmdExit});
            this.cmdFile.Name = "cmdFile";
            this.cmdFile.Size = new System.Drawing.Size(37, 20);
            this.cmdFile.Text = "&File";
            // 
            // cmdSettings
            // 
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(116, 22);
            this.cmdSettings.Text = "Settings";
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // cmdExit
            // 
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(116, 22);
            this.cmdExit.Text = "E&xit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdView
            // 
            this.cmdView.Name = "cmdView";
            this.cmdView.Size = new System.Drawing.Size(44, 20);
            this.cmdView.Text = "&View";
            this.cmdView.Click += new System.EventHandler(this.cmdView_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(44, 20);
            this.cmdHelp.Text = "&Help";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(318, 65);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to login simulator!\r\n";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTry
            // 
            this.lblTry.Location = new System.Drawing.Point(1, 76);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(318, 13);
            this.lblTry.TabIndex = 3;
            this.lblTry.Text = "Try to login, if you can!";
            this.lblTry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(50, 124);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(61, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // chbRememberMe
            // 
            this.chbRememberMe.AutoSize = true;
            this.chbRememberMe.Location = new System.Drawing.Point(64, 222);
            this.chbRememberMe.Name = "chbRememberMe";
            this.chbRememberMe.Size = new System.Drawing.Size(94, 17);
            this.chbRememberMe.TabIndex = 3;
            this.chbRememberMe.Text = "Remember me";
            this.chbRememberMe.UseVisualStyleBackColor = true;
            // 
            // bntLogin
            // 
            this.bntLogin.Location = new System.Drawing.Point(107, 262);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(89, 23);
            this.bntLogin.TabIndex = 4;
            this.bntLogin.Text = "Log in";
            this.bntLogin.UseVisualStyleBackColor = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(53, 140);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(204, 20);
            this.tbxUserName.TabIndex = 1;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(53, 196);
            this.tbxPassword.MaxLength = 14;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(204, 20);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // picStatus
            // 
            this.picStatus.Location = new System.Drawing.Point(286, 340);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(15, 16);
            this.picStatus.TabIndex = 10;
            this.picStatus.TabStop = false;
            // 
            // picProgress
            // 
            this.picProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.picProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProgress.Location = new System.Drawing.Point(12, 335);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(258, 24);
            this.picProgress.TabIndex = 12;
            this.picProgress.TabStop = false;
            this.picProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.picProgress_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 371);
            this.Controls.Add(this.picProgress);
            this.Controls.Add(this.picStatus);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.bntLogin);
            this.Controls.Add(this.chbRememberMe);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mnuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuTop;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login sumulator";
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem cmdFile;
        private System.Windows.Forms.ToolStripMenuItem cmdExit;
        private System.Windows.Forms.ToolStripMenuItem cmdView;
        private System.Windows.Forms.ToolStripMenuItem cmdHelp;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chbRememberMe;
        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.ToolStripMenuItem cmdSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.PictureBox picStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picProgress;
    }
}

