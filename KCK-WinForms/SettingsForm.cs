using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KCK_WinForms
{
    public partial class SettingsForm : Form
    {
        private static SettingsForm instance;
        private bool dark;
        private bool matchType;
        private bool instaMatch;
        public SettingsForm()
        {
            instance = this;
            InitializeComponent();
            if(Menu.instance.darkStyle == true)
            {
                btnDark.Checked= true;
                btnLight.Checked= false;
            }
            else 
            {
                btnDark.Checked = false;
                btnLight.Checked = true;
            }

            if(Menu.instance.matchFast== true)
            {
                btnFastMatchYes.Checked= true;
                btnFastMatchNo.Checked= false;
                comboBoxMatchSpeed.Visible = false;
                label4.Visible = false;
            }
            else
            {
                btnFastMatchYes.Checked = false;
                btnFastMatchNo.Checked = true;
                comboBoxMatchSpeed.Visible = true;
                label4.Visible = true;
            }

            if (Menu.instance.GroupMatch == true)
            {
                btnNormal.Checked = true;
                btnTournament.Checked = false;
            }
            else
            {
                btnNormal.Checked = false;
                btnTournament.Checked = true;
            }

            comboBoxMatchSpeed.SelectedIndex = Menu.instance.settingsComboBoxState;
            Menu.instance.SetColors(this, Menu.instance.darkStyle);
        }

        private void btnLight_CheckedChanged(object sender, EventArgs e)
        {
            if(btnLight.Checked)
            {
                btnDark.Checked = false;
                dark = false;
            }
        }
        private void btnDark_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDark.Checked)
            {
                btnLight.Checked = false;
                dark = true;
                Menu.instance.RefreshMenu();
                Menu.instance.SetColors(this, Menu.instance.darkStyle);
            }
        }

        private void btnNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (btnNormal.Checked)
            {
                btnTournament.Checked = false;
                matchType = true;
            }
        }

        private void btnTournament_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTournament.Checked)
            {
                btnNormal.Checked = false;
                matchType = false;
            }
        }

        private void btnFastMatchNo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnFastMatchNo.Checked)
            {
                btnFastMatchYes.Checked = false;
                instaMatch = false;
                comboBoxMatchSpeed.Visible = true;
                label4.Visible = true;
            }
        }

        private void btnFastMatchYes_CheckedChanged(object sender, EventArgs e)
        {
            if (btnFastMatchYes.Checked)
            {
                btnFastMatchNo.Checked = false;
                instaMatch = true;
                comboBoxMatchSpeed.Visible = false;
                label4.Visible = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.instance.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu.instance.GroupMatch = matchType;
            Menu.instance.darkStyle = dark;
            Menu.instance.matchFast = instaMatch;
            Menu.instance.RefreshMenu();
            Menu.instance.SetColors(this, Menu.instance.darkStyle);
            if (comboBoxMatchSpeed.SelectedIndex == 0)
            {
                Menu.instance.matchSpeed = 1;
                Menu.instance.settingsComboBoxState = 0;
            }
            if (comboBoxMatchSpeed.SelectedIndex == 1)
            {
                Menu.instance.matchSpeed = 2;
                Menu.instance.settingsComboBoxState = 1;
            }
            if (comboBoxMatchSpeed.SelectedIndex == 2)
            {
                Menu.instance.matchSpeed = 5;
                Menu.instance.settingsComboBoxState = 2;
            }
            if (comboBoxMatchSpeed.SelectedIndex == 3)
            {
                Menu.instance.matchSpeed = 10;
                Menu.instance.settingsComboBoxState = 3;
            }
            if (comboBoxMatchSpeed.SelectedIndex == 4)
            {
                Menu.instance.matchSpeed = 22;
                Menu.instance.settingsComboBoxState = 4;
            }
            if (comboBoxMatchSpeed.SelectedIndex == -1)
            {
                Menu.instance.settingsComboBoxState = -1;
            }
            MessageBox.Show("Pomyślnie zapisano");
        }
    }
}
