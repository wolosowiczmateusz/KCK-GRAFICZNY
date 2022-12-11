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
    public partial class LoadTeamForm : Form
    {
        public LoadTeamForm()
        {
            InitializeComponent();
            Menu.instance.SetColors(this, Menu.instance.darkStyle);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool failedtoopen = false;
            string fileName = textBox1.Text;
            fileName += ".xml";
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(List<Team>));
            try
            {
                using (Stream reader = new FileStream(fileName, FileMode.Open))
                {
                    Menu.instance.teams = (List<Team>)xml.Deserialize(reader);
                }
            }
            catch (FileNotFoundException ex)
            {
                failedtoopen = true;
                MessageBox.Show("Nie znaleziono takiego pliku\nSpróbuj jeszcze raz","Nie ma takiego pliku",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            if(!failedtoopen) 
            {
                foreach (var team in Menu.instance.teams)
                {
                    foreach (var player in team.PlayerList)
                    {
                        player.setLineAndSplit();
                    }
                }
                Menu.instance.RefreshMenu();
                MessageBox.Show("Pomyślnie wczytano drużyny z pliku " + fileName);
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.instance.Visible = true;
        }
    }
}
