using Newtonsoft.Json;
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
    public partial class SaveTeamForm : Form
    {
        public SaveTeamForm()
        {
            InitializeComponent();
            Menu.instance.SetColors(this, Menu.instance.darkStyle);
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
                foreach (Control child in control.Controls)
                {
                    SetColors(child, darkTheme);
                }
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text;
            fileName += ".xml";
            StreamWriter writer = new StreamWriter(fileName);
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(List<Team>));
            x.Serialize(writer, Menu.instance.teams);
            writer.Dispose();
            MessageBox.Show("Zapisano drużyny do pliku o nazwie: " + textBox1.Text + ".xml");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.instance.Visible = true;
        }
    }
}
