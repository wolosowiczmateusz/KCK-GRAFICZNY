using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCK_WinForms
{
    public partial class EditTeamForm : Form
    {
        public static EditTeamForm instance;
        List<Label> labels = new List<Label>();
        List<ComboBox> comboBoxes= new List<ComboBox>();
        Team team = new Team();
        List<Player> players = new List<Player>();
        List<Player> foundPlayers = new List<Player>();
        List<Player> teamPlayers = new List<Player>();
        public EditTeamForm()
        {
            instance = this;
            InitializeComponent();

            team = Menu.instance.teams[Menu.instance.LBteams.SelectedIndex];
            Init();
            foreach (Formation f in Menu.instance.formations)
            {
                comboBoxFormations.Items.Add(f.Name);
            }
            Menu.instance.SetColors(this,Menu.instance.darkStyle);
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
            if(control is ListBox) 
            {
                ListBox listBox = (ListBox)control;
                if (darkTheme)
                {
                    listBox.BackColor = Color.FromArgb(72, 74, 88);
                    listBox.ForeColor = Color.White;
                }
                else
                {
                    listBox.BackColor = Color.White;
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
                    comboBox.BackColor = Color.White;
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
                    textBox.BackColor = Color.White;
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
                    button.BackColor = Color.White;
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
                foreach(Control child in control.Controls)
                {
                    SetColors(child,darkTheme);
                }
            }
        }


        private void textBoxNameInput_TextChanged(object sender, EventArgs e)
        {
            listBoxPlayers.Items.Clear();
            foundPlayers.Clear();
            foreach (Player p in players)
            {
                if (p.FullName.Contains(textBoxNameInput.Text, StringComparison.OrdinalIgnoreCase))
                {
                    foundPlayers.Add(p);
                    listBoxPlayers.Items.Add(p.FullName + ", " + p.BestPosition + ", " +  p.Age);
                }
            }
        }

        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            bool duplicate = false;
            if(listBoxPlayers.SelectedIndex != -1)
            {
                foreach(Player p in teamPlayers) 
                {
                    if(p.ID == foundPlayers[listBoxPlayers.SelectedIndex].ID)
                    {
                        duplicate = true;
                    }
                }
                if (!duplicate)
                {
                    teamPlayers.Add(foundPlayers[listBoxPlayers.SelectedIndex]);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego gracza");
            }
            RefreshList();
            RefreshComboBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Team t in Menu.instance.teams)
            {
                if (team.Nationality == t.Nationality)
                {
                    //zapisywanie "ławki"
                    foreach (Player p in teamPlayers)
                    {
                        if (!t.teamData.PlayerList.Contains(p))
                        {
                            t.teamData.PlayerList.Add(p);
                        }
                    }
                    //zapisywanie indexów comboboxów
                    for (int i = 0; i < 11; i++)
                    {
                        t.teamData.comboBoxIndexes[i] = comboBoxes[i].SelectedIndex;
                    }
                    //zapisywanie piłkarzy w teamie
                    t.PlayerList.Clear();
                    for (int i = 0; i < 11; i++)
                    {
                        if (comboBoxes[i].SelectedIndex != -1)
                        {
                            teamPlayers[comboBoxes[i].SelectedIndex].PosNr = i + 1;
                            t.addPlayer(teamPlayers[comboBoxes[i].SelectedIndex]);
                        }
                    }

                }
            }
            MessageBox.Show("Pomyślnie zapisano drużynę");
        }

        // init labels text's and players from this country
        private void Init()
        {
            comboBoxes.Add(comboBox1);
            comboBoxes.Add(comboBox2);
            comboBoxes.Add(comboBox3);
            comboBoxes.Add(comboBox4);
            comboBoxes.Add(comboBox5);
            comboBoxes.Add(comboBox6);
            comboBoxes.Add(comboBox7);
            comboBoxes.Add(comboBox8);
            comboBoxes.Add(comboBox9);
            comboBoxes.Add(comboBox10);
            comboBoxes.Add(comboBox11);
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            for (int i = 0; i < 11; i++)
            {
                labels[i].Text = team.formation.Positions[i];
            }
            foreach(var c in comboBoxes)
            {
                c.SelectedIndex = -1;
            }
            //TeamData
            foreach (var p in team.teamData.PlayerList)
            {
                teamPlayers.Add(p);
            }
            RefreshComboBoxes();
            for (int i = 0; i < 11; i++)
            {
                comboBoxes[i].SelectedIndex = team.teamData.comboBoxIndexes[i];
            }

            RefreshComboBoxes();


            foreach (Player p in Menu.instance.players)
            {
                if (p.Nationality == team.Nationality)
                {
                    players.Add(p);
                }
            }
            listBoxPlayers.Items.Clear();
            foreach (Player p in players)
            {
                if (p.Nationality == team.Nationality)
                {
                    listBoxPlayers.Items.Add(p.FullName + ", " + p.BestPosition + ", " + p.Age);
                    foundPlayers.Add(p);
                }
            }
            lblTeamNationality.Text = team.Nationality;
            lblFormation.Text = team.formation.Name;
            RefreshList();
        }


        private void RefreshComboBoxes()
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                int index = comboBox.SelectedIndex;
                comboBox.Items.Clear();
                foreach (Player p in teamPlayers)
                {
                    comboBox.Items.Add(p.FullName + ", " + p.BestPosition + ", " + p.Age);
                }
                comboBox.SelectedIndex = index;
            }
        }
        private void RefreshList()
        {
            listBoxTeam.Items.Clear();
            foreach (Player p in teamPlayers)
            {
                listBoxTeam.Items.Add(p.FullName + ", " + p.BestPosition + ", " + p.Age);
            }
        }
        private void comboBoxFormations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formation f = new Formation();
            f = Menu.instance.formations[comboBoxFormations.SelectedIndex];
            team.formation = f;
            RefreshList();
            RefreshComboBoxes();
            lblFormation.Text = team.formation.Name;
            for (int i = 0; i < 11; i++)
            {
                labels[i].Text = team.formation.Positions[i];
            }
        }
        private void textBoxNameInput_Click(object sender, EventArgs e)
        {
            textBoxNameInput.SelectAll();
            textBoxNameInput.Focus();
        }
        private void DetectDuplicate(int cbID)
        {
            int i = 0;
            foreach(ComboBox cb in comboBoxes)
            {
                if(comboBoxes[cbID].SelectedIndex == cb.SelectedIndex  && i != cbID && cb.SelectedIndex != -1)
                {
                    cb.SelectedIndex = -1;
                }
                i++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(0);
            this.ActiveControl = null;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(1);
            this.ActiveControl = null;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(2);
            this.ActiveControl = null;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(3);
            this.ActiveControl = null;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(4);
            this.ActiveControl = null;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(5);
            this.ActiveControl = null;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(6);
            this.ActiveControl = null;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(7);
            this.ActiveControl = null;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(8);
            this.ActiveControl = null;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(9);
            this.ActiveControl = null;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectDuplicate(10);
            this.ActiveControl = null;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.instance.Visible = true;
        }
    }
}
