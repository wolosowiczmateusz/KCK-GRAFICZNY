using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCK_WinForms
{
    public partial class MatchForm : Form
    {
        public static MatchForm instance;
        public MatchForm()
        {
            instance = this;
            InitializeComponent();
            foreach(Team t in Menu.instance.teams)
            {
                comboBoxTeamA.Items.Add(t.Nationality);
                comboBoxTeamB.Items.Add(t.Nationality);
            }
            Menu.instance.SetColors(this, Menu.instance.darkStyle);
        }

        private void btnPlayMatch_Click(object sender, EventArgs e)
        {

            if(comboBoxTeamA.SelectedIndex == -1 || comboBoxTeamB.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano drużyn!", "Błąd w wybraniu drużyn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {
                btnPlayMatch.Visible = false;
                btnMenu.Visible = false;
                Match match = new Match(Menu.instance.teams[comboBoxTeamA.SelectedIndex], Menu.instance.teams[comboBoxTeamB.SelectedIndex], Menu.instance.GroupMatch, lblMatch, Menu.instance.matchSpeed);
                if (Menu.instance.matchFast)
                {
                    match.startMatchFast();
                }
                else
                {
                    match.startMatch();
                }

                btnPlayMatch.Visible = true;
                btnMenu.Visible = true;
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.instance.Visible = true;
        }

    }
}
