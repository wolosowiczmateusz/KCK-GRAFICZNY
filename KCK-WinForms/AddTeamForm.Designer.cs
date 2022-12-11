namespace KCK_WinForms
{
    partial class AddTeamForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.comboBoxFormations = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nazwę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz formację";
            // 
            // TeamName
            // 
            this.TeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamName.Location = new System.Drawing.Point(212, 51);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(184, 34);
            this.TeamName.TabIndex = 2;
            // 
            // comboBoxFormations
            // 
            this.comboBoxFormations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFormations.FormattingEnabled = true;
            this.comboBoxFormations.Location = new System.Drawing.Point(212, 106);
            this.comboBoxFormations.Name = "comboBoxFormations";
            this.comboBoxFormations.Size = new System.Drawing.Size(236, 36);
            this.comboBoxFormations.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj drużynę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(0, 289);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(116, 36);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Wróć do menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 326);
            this.ControlBox = false;
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxFormations);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TeamName;
        private ComboBox comboBoxFormations;
        private Button button1;
        private Button btnMenu;
    }
}