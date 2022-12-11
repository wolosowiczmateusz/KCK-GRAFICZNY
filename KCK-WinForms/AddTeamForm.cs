using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCK_WinForms
{
    public partial class AddTeamForm : Form
    {
        public static AddTeamForm instance;

        public AddTeamForm()
        {
            instance = this;
            InitializeComponent();
            foreach(Formation f in Menu.instance.formations)
            {
                comboBoxFormations.Items.Add(f.Name);
            }
            Menu.instance.SetColors(this, Menu.instance.darkStyle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu.instance.Visible = false;

            Formation f = new Formation();
            if(comboBoxFormations.SelectedIndex != -1)
            {
                f = Menu.instance.formations[comboBoxFormations.SelectedIndex];
                Team team = new Team();
                string teamName = "";
                teamName = FirstToUpper(TeamName.Text);
                if (TeamName.Text.Length == 0)
                {
                    MessageBox.Show("Podaj nazwę drużyny!", "Podaj nazwę drużyny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (teamName.Length > 0 && comboBoxFormations.SelectedIndex != -1)
                {
                    team.Nationality = teamName;
                    team.formation = f;
                }
                bool duplicate = false;
                foreach (Team t in Menu.instance.teams)
                {
                    if (t.Nationality == team.Nationality)
                    {
                        duplicate = true;
                    }
                }
                if (!duplicate)
                {
                    Menu.instance.teams.Add(team);
                    Menu.instance.RefreshMenu();
                    MessageBox.Show("Dodano drużynę " + teamName);
                }
                else
                {
                    MessageBox.Show("Drużyna o podanej nazwie już istnieje", "Istnieje już taka drużyna", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Wybierz formację!", "Błąd! Brak formacji!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string FirstToUpper(string s)
        {
            string tmp = s;
            tmp = tmp.ToLower();
            string[] words = tmp.Split();
            List<string> newwords = new List<string>();
            if (s == null)
            {
                return null;
            }

            string returnWord = "";
            if (tmp.Length > 0)
            {
                foreach (string word in words)
                {
                    newwords.Add(char.ToUpper(word[0]) + word.Substring(1));
                }
                foreach (string word in newwords)
                {
                    returnWord += word;
                    returnWord += " ";
                }
                returnWord = returnWord.Trim();
            }
            return returnWord;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.instance.Visible = true;
        }
    }
}
