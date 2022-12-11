namespace KCK_WinForms
{
    partial class Menu
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
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnSaveTeams = new System.Windows.Forms.Button();
            this.btnLoadTeams = new System.Windows.Forms.Button();
            this.btnPlayMatch = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(41, 128);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(203, 80);
            this.btnAddTeam.TabIndex = 0;
            this.btnAddTeam.Text = "Dodaj drużynę";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.ItemHeight = 30;
            this.listBoxTeams.Location = new System.Drawing.Point(334, 27);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(212, 394);
            this.listBoxTeams.TabIndex = 1;
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Location = new System.Drawing.Point(41, 214);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(203, 80);
            this.btnEditTeam.TabIndex = 2;
            this.btnEditTeam.Text = "Edytuj drużynę";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(41, 300);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(203, 80);
            this.btnDeleteTeam.TabIndex = 3;
            this.btnDeleteTeam.Text = "Usuń drużynę";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnSaveTeams
            // 
            this.btnSaveTeams.Location = new System.Drawing.Point(277, 488);
            this.btnSaveTeams.Name = "btnSaveTeams";
            this.btnSaveTeams.Size = new System.Drawing.Size(142, 80);
            this.btnSaveTeams.TabIndex = 5;
            this.btnSaveTeams.Text = "Zapisz drużyny";
            this.btnSaveTeams.UseVisualStyleBackColor = true;
            this.btnSaveTeams.Click += new System.EventHandler(this.btnSaveTeams_Click);
            // 
            // btnLoadTeams
            // 
            this.btnLoadTeams.Location = new System.Drawing.Point(462, 488);
            this.btnLoadTeams.Name = "btnLoadTeams";
            this.btnLoadTeams.Size = new System.Drawing.Size(142, 80);
            this.btnLoadTeams.TabIndex = 6;
            this.btnLoadTeams.Text = "Wczytaj drużyny";
            this.btnLoadTeams.UseVisualStyleBackColor = true;
            this.btnLoadTeams.Click += new System.EventHandler(this.btnLoadTeams_Click);
            // 
            // btnPlayMatch
            // 
            this.btnPlayMatch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlayMatch.Location = new System.Drawing.Point(41, 27);
            this.btnPlayMatch.Name = "btnPlayMatch";
            this.btnPlayMatch.Size = new System.Drawing.Size(203, 80);
            this.btnPlayMatch.TabIndex = 7;
            this.btnPlayMatch.Text = "Zagraj mecz";
            this.btnPlayMatch.UseVisualStyleBackColor = true;
            this.btnPlayMatch.Click += new System.EventHandler(this.btnPlayMatch_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(41, 418);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(203, 80);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Ustawienia";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Zakończ program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 592);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPlayMatch);
            this.Controls.Add(this.btnLoadTeams);
            this.Controls.Add(this.btnSaveTeams);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.listBoxTeams);
            this.Controls.Add(this.btnAddTeam);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddTeam;
        private ListBox listBoxTeams;
        private Button btnEditTeam;
        private Button btnDeleteTeam;
        private Button btnSaveTeams;
        private Button btnLoadTeams;
        private Button btnPlayMatch;
        private Button btnSettings;
        private Button button1;
    }
}