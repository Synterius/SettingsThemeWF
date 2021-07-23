using SettingsThemeWF.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsThemeWF
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (Settings.Default.language != "")
            {
                cmbLanguage.SelectedItem = Settings.Default.language;
            }

            chbDarkTheme.Checked = Settings.Default.darkTheme;

            this.Text = localization.strings.settings_text;
            chbDarkTheme.Text = localization.strings.dark_theme;
            lblLanguage.Text = localization.strings.interface_language;
            bntApply.Text = localization.strings.apply;
            bntCancel.Text = localization.strings.cancel;

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

            // Checkbox
            chbDarkTheme.BackColor = colorBgd;
            chbDarkTheme.ForeColor = colorTxt;

            // Dropdown
            cmbLanguage.BackColor = colorBgd;
            cmbLanguage.ForeColor = colorTxt;

            // Button
            bntApply.FlatStyle = bntCancel.FlatStyle = buttonStyle;
            bntApply.BackColor = bntCancel.BackColor = colorBgd;
            bntApply.ForeColor = bntCancel.ForeColor = colorTxt;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntApply_Click(object sender, EventArgs e)
        {
            if (cmbLanguage.Text != "")
            {
                //if (cmbLanguage.Text != Settings.Default.language)
                //{
                //    MessageBox.Show(localization.strings.please_restart);
                //}
                Settings.Default.language = cmbLanguage.Text;
            }

            Settings.Default.darkTheme = chbDarkTheme.Checked;

            Settings.Default.Save();

            this.DialogResult = DialogResult.OK;

            Close();
        }
    }
}
