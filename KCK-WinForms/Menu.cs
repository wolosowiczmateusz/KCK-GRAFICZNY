using KCK_WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCK_WinForms
{
    public partial class Menu : Form
    {
        public int OVR;
        public ListBox LBteams;
        public static Menu instance;
        public List<Player> players = new List<Player>();
        public List<Formation> formations = new List<Formation>();
        public FormationCreator creator = new FormationCreator();
        public List<Team> teams = new List<Team>();
        public Helper helper = new Helper();
        public List<Match> matches = new List<Match>();
        public Match match = new Match();
        //styl graficzny
        public bool darkStyle = false;
        //mecz normalny lub turniejowy
        public bool GroupMatch = true;
        //szybkość meczu
        public int matchSpeed = 5;
        //Mecz instant czy nie
        public bool matchFast = false;
        public int settingsComboBoxState = 2;

        public Menu()
        {
            instance = this;
            using (StreamReader sr = new StreamReader("options.txt"))
            {
                string[] opt = new string[5];
                var line = sr.ReadLine();
                opt = line.Split(",");
                darkStyle = Convert.ToBoolean(opt[0]);
                GroupMatch = Convert.ToBoolean(opt[1]);
                matchFast = Convert.ToBoolean(opt[3]);
                matchSpeed = Convert.ToInt32(opt[2]);
                settingsComboBoxState = Convert.ToInt32(opt[4]);
            }
            InitializeComponent();
            LBteams = listBoxTeams;
            string fileName = "fifadb.json";
            string jsonString = File.ReadAllText(fileName);
            players = JsonSerializer.Deserialize<List<Player>>(jsonString)!;
            foreach (var player in players)
            {
                player.setLineAndSplit();
            }
            formations = creator.getFormations();
            RefreshMenu();
            SetColors(this, darkStyle);

        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            AddTeamForm add = new AddTeamForm();
            add.Show();
            this.Visible = false;
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            if(listBoxTeams.SelectedIndex== -1)
            {
                MessageBox.Show("Nie wybrano zespołu", "Nie wybrano zespołu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditTeamForm edit= new EditTeamForm();
            edit.Show();
            this.Visible = false;
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (listBoxTeams.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano zespołu", "Nie wybrano zespołu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz usunąć wybraną drużynę?", "Usuwanie drużyny", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialogResult== DialogResult.Yes)
            {
                teams.RemoveAt(listBoxTeams.SelectedIndex);
                RefreshMenu();
            }
        }
            
        private void btnSaveTeams_Click(object sender, EventArgs e)
        {
            SaveTeamForm save = new SaveTeamForm();
            save.Show();
            this.Visible = false;
        }
        private void btnLoadTeams_Click(object sender, EventArgs e)
        {
            LoadTeamForm load = new LoadTeamForm();
            load.Show();
            this.Visible = false;
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
            this.Visible = false;
        }
        public void RefreshMenu()
        {
            listBoxTeams.Items.Clear();
            foreach (var team in teams)
            {
                listBoxTeams.Items.Add(team.Nationality);
            }
            SetColors(this, Menu.instance.darkStyle);
        }

        private void btnPlayMatch_Click(object sender, EventArgs e)
        {
            if (teams.Count >= 2)
            {
                MatchForm match = new MatchForm();
                match.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Brak wystarczającej ilości drużyn", "Niewystarczająca ilość drużyn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetColors(Control control, bool darkTheme)
        {
            if (control is Form)
            {
                Form form = (Form)control;
                if (darkTheme)
                {
                    form.BackColor = Color.FromArgb(40, 42, 58);
                }
                else
                {
                    form.BackColor = Color.FromArgb(238, 239, 239);
                }
            }
            if (control is ListBox)
            {
                ListBox listBox = (ListBox)control;
                if (darkTheme)
                {
                    listBox.BackColor = Color.FromArgb(72, 74, 88);
                    listBox.ForeColor = Color.White;
                }
                else
                {
                    listBox.ForeColor = Color.Black;
                    listBox.BackColor = Color.FromArgb(179, 217, 255);
                }
            }
            if (control is ComboBox)
            {
                ComboBox comboBox = (ComboBox)control;
                if (darkTheme)
                {
                    comboBox.BackColor = Color.FromArgb(20, 22, 38);
                    comboBox.ForeColor = Color.White;
                }
                else
                {
                    comboBox.ForeColor = Color.Black;
                    comboBox.BackColor = Color.FromArgb(179, 217, 255);
                }
            }
            if (control is TextBox)
            {
                TextBox textBox = (TextBox)control;
                if (darkTheme)
                {
                    textBox.BackColor = Color.FromArgb(72, 74, 88);
                    textBox.ForeColor = Color.White;
                }
                else
                {
                    textBox.ForeColor = Color.Black;
                    textBox.BackColor = Color.FromArgb(179, 217, 255);
                }
            }

            if (control is GroupBox)
            {
                GroupBox groupBox = (GroupBox)control;
                if (darkTheme)
                {
                    groupBox.BackColor = Color.FromArgb(72, 74, 88);
                    groupBox.ForeColor = Color.White;
                }
                else
                {
                    groupBox.ForeColor = Color.Black;
                    groupBox.BackColor = Color.FromArgb(179, 217, 255);
                }
            }


            if (control is Button)
            {
                Button button = (Button)control;
                if (darkTheme)
                {
                    button.BackColor = Color.FromArgb(20, 22, 38);
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.ForeColor = Color.Black;
                    button.BackColor = Color.FromArgb(77, 169, 255);
                }
            }

            if (control is Label)
            {
                Label lbl = (Label)control;
                if (darkTheme)
                {
                    lbl.ForeColor = Color.White;
                }
                else
                {
                    lbl.ForeColor = Color.Black;
                }
            }

            else
            {
                foreach (Control child in control.Controls)
                {
                    SetColors(child, Menu.instance.darkStyle);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz wyjść?", "Zamykanie programu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                using (StreamWriter sw = new StreamWriter("options.txt"))
                {
                    sw.WriteLine(darkStyle+","+GroupMatch+","+matchSpeed+","+matchFast+","+settingsComboBoxState);
                }
                this.Close();
            }

        }
    }
}
