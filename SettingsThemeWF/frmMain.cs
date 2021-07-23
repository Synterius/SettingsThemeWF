using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using SettingsThemeWF.Properties;

namespace SettingsThemeWF
{
    public partial class frmMain : Form
    {
        private int ProgressMinimum = 0;
        private int ProgressMaximum = 100;
        private int ProgressValue = 0;

        private int ProgressBarValue
        {
            get
            {
                return ProgressValue;
            }
            set
            {
                ProgressValue = value;
                if (ProgressValue > ProgressMaximum)
                {
                    ProgressValue = 0;
                }
                picProgress.Refresh();
            }

        }

        public frmMain()
        {
            InitializeComponent();
            //mnuTop.Renderer = new MyRenderer();

            // Apply localization and theme from settings
            RefreshForm();

            picStatus.Visible = false;
            tbxUserName.Text = Settings.Default.userName;
            tbxPassword.Text = Settings.Default.password;
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Settings.Default.darkTheme ? Settings.Default.colorMenuDark : base.MenuItemSelected; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Settings.Default.darkTheme ? Settings.Default.colorMenuDark : base.MenuItemSelectedGradientBegin; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Settings.Default.darkTheme ? Settings.Default.colorMenuDark : base.MenuItemSelectedGradientEnd; }
            }
            public override Color ImageMarginGradientBegin
            {
                get { return Settings.Default.darkTheme ? Settings.Default.colorMenuDark : Settings.Default.colorMenuOrigin; }
            }
            public override Color ImageMarginGradientMiddle
            {
                get { return Settings.Default.darkTheme ? Settings.Default.colorMenuDark : Settings.Default.colorMenuOrigin; }
            }
            public override Color ImageMarginGradientEnd
            {
                get { return Settings.Default.darkTheme ? Settings.Default.colorMenuDark : Settings.Default.colorMenuOrigin; }
            }
            public override Color MenuItemBorder    // Menu item!!!
            {
                get { return Settings.Default.darkTheme ? Settings.Default.colorMenuDark : base.MenuItemBorder; }
            }
            public override Color MenuBorder    // Strip menu border
            {
                get { return Settings.Default.darkTheme ? Settings.Default.colorMenuDark : base.MenuBorder; }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Settings.Default.darkTheme ? Color.FromArgb(37, 37, 38) : base.MenuItemPressedGradientBegin; }
            }
            public override Color MenuItemPressedGradientMiddle
            {
                get { return Settings.Default.darkTheme ? Color.FromArgb(37, 37, 38) : base.MenuItemPressedGradientMiddle; }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Settings.Default.darkTheme ? Color.FromArgb(37, 37, 38) : base.MenuItemPressedGradientEnd; }
            }
            public override Color ButtonPressedHighlight
            {
                get { return Settings.Default.darkTheme ? Color.FromArgb(37, 37, 38) : base.MenuItemPressedGradientEnd; }
            }
            public override Color ButtonSelectedBorder
            {
                get { return Color.Blue; }
            }
        }

        private void RefreshForm()
        {
            // Update the settings, if needed.  When the application updates, settings will persist.
            if (Settings.Default.updateNeeded)
            {
                Settings.Default.Upgrade();
                Settings.Default.updateNeeded = false;
                Settings.Default.Save();
            }

            // Set the interface language from the settings
            // If not - will be used system language 
            if (Settings.Default.language != "")
            {
                string language_string = "";
                switch (Settings.Default.language)
                {
                    case "English":
                        language_string = "en";
                        break;
                    case "Russian":
                        language_string = "ru";
                        break;
                    case "Ukrainian":
                        language_string = "uk";
                        break;
                    default:
                        language_string = "en";
                        break;
                }
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language_string);   // Reset app language
            }

            this.Text = localization.strings.main_text;

            cmdFile.Text = localization.strings.file;
            cmdView.Text = localization.strings.view;
            cmdHelp.Text = localization.strings.help;
            cmdSettings.Text = localization.strings.settings;
            cmdExit.Text = localization.strings.exit;

            lblWelcome.Text = localization.strings.welcome;
            lblTry.Text = localization.strings._try;

            lblUserName.Text = localization.strings.userName;
            lblPassword.Text = localization.strings.password;
            chbRememberMe.Text = localization.strings.remember_me;

            bntLogin.Text = localization.strings.bntLogin;

            SetTheme();
        }

        private void SetTheme()
        {
            // Read settings
            bool darkTheme = Settings.Default.darkTheme;

            // Define colors
            FlatStyle buttonStyle = darkTheme ? FlatStyle.Flat : FlatStyle.Standard;
            Color colorBgd = darkTheme ? Settings.Default.colorBgd : Settings.Default.colorBgdOriginal;
            Color colorTxt = darkTheme ? Settings.Default.colorTxt : Settings.Default.colorTxtOriginal;

            // --------------------------
            // -- APPLY THEME SETTINGS --
            // --------------------------

            // Main frame window
            this.BackColor = colorBgd;
            this.ForeColor = colorTxt;

            // ToolStripMenu Top
            mnuTop.BackColor = colorBgd;
            mnuTop.ForeColor = colorTxt;

            // ToolStripMenuItem and the ToolStripMenuItem dropdowns
            foreach (ToolStripMenuItem item in mnuTop.Items)
            {
                // Menu item coloring
                item.BackColor = colorBgd;
                item.ForeColor = colorTxt;

                // Dropdown coloring
                item.DropDown.BackColor = colorBgd;
                item.DropDown.ForeColor = colorTxt;
            }

            // Button
            bntLogin.FlatStyle = buttonStyle;
            bntLogin.BackColor = colorBgd;
            bntLogin.ForeColor = colorTxt;

            picStatus.Image = darkTheme ? Resources.select2_spinner_inverted : Resources.select2_spinner;
        }

        private void cmdSettings_Click(object sender, EventArgs e)
        {
            Form frm = new frmSettings();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                RefreshForm();
            }            
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (chbRememberMe.Checked)
            {
                Settings.Default.userName = tbxUserName.Text;
                Settings.Default.password = tbxPassword.Text;
                Settings.Default.Save();
            }

            picStatus.Visible = true;

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void cmdView_Click(object sender, EventArgs e)
        {
            //picStatus.Enabled = !picStatus.Enabled;
        }

        Random rnd = new Random();

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(rnd.Next(1, 40));
                try
                {
                    backgroundWorker1.ReportProgress(((i+1) * 100) / 100);
                }
                catch (InvalidOperationException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            //lblStatusNum.Text = e.ProgressPercentage.ToString();
            ProgressBarValue = e.ProgressPercentage;
            if(ProgressBarValue == 100)
            {
                picStatus.Visible = false;
                if (tbxUserName.Text == "admin" && tbxPassword.Text == "admin")
                {
                    MessageBox.Show("Seriously!?");
                }
            }
        }

        private void picProgress_Paint(object sender, PaintEventArgs e)
        {
            // Clear the background.
            e.Graphics.Clear(picProgress.BackColor);

            // Draw the progress bar.
            float fraction =
                (float)(ProgressValue - ProgressMinimum) /
                (ProgressMaximum - ProgressMinimum);
            int wid = (int)(fraction * picProgress.ClientSize.Width);
            e.Graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(6,176,37)), 0, 0, wid,
                picProgress.ClientSize.Height);

            // Draw the text.
            e.Graphics.TextRenderingHint =
                TextRenderingHint.AntiAliasGridFit;
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                int percent = (int)(fraction * 100);
                e.Graphics.DrawString(
                    percent.ToString() + "%",
                    this.Font, Brushes.Black,
                    picProgress.ClientRectangle, sf);
            }
        }
    }
}
