
namespace SettingsThemeWF
{
    partial class frmSettings
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
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.chbDarkTheme = new System.Windows.Forms.CheckBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.bntApply = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "English",
            "Russian",
            "Ukrainian"});
            this.cmbLanguage.Location = new System.Drawing.Point(24, 86);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cmbLanguage.TabIndex = 0;
            // 
            // chbDarkTheme
            // 
            this.chbDarkTheme.AutoSize = true;
            this.chbDarkTheme.Location = new System.Drawing.Point(27, 29);
            this.chbDarkTheme.Name = "chbDarkTheme";
            this.chbDarkTheme.Size = new System.Drawing.Size(87, 17);
            this.chbDarkTheme.TabIndex = 1;
            this.chbDarkTheme.Text = "Darck theme";
            this.chbDarkTheme.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(24, 67);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(99, 13);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Interface language:";
            // 
            // bntApply
            // 
            this.bntApply.AutoSize = true;
            this.bntApply.Location = new System.Drawing.Point(111, 136);
            this.bntApply.Name = "bntApply";
            this.bntApply.Size = new System.Drawing.Size(75, 23);
            this.bntApply.TabIndex = 3;
            this.bntApply.Text = "Apply";
            this.bntApply.UseVisualStyleBackColor = true;
            this.bntApply.Click += new System.EventHandler(this.bntApply_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.AutoSize = true;
            this.bntCancel.Location = new System.Drawing.Point(206, 136);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 3;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 171);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.bntApply);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.chbDarkTheme);
            this.Controls.Add(this.cmbLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.CheckBox chbDarkTheme;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button bntApply;
        private System.Windows.Forms.Button bntCancel;
    }
}