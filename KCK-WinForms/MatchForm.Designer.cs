namespace KCK_WinForms
{
    partial class MatchForm
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
            this.comboBoxTeamA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTeamB = new System.Windows.Forms.ComboBox();
            this.btnPlayMatch = new System.Windows.Forms.Button();
            this.lblMatch = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTeamA
            // 
            this.comboBoxTeamA.DropDownHeight = 300;
            this.comboBoxTeamA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeamA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTeamA.FormattingEnabled = true;
            this.comboBoxTeamA.IntegralHeight = false;
            this.comboBoxTeamA.ItemHeight = 25;
            this.comboBoxTeamA.Location = new System.Drawing.Point(33, 71);
            this.comboBoxTeamA.Name = "comboBoxTeamA";
            this.comboBoxTeamA.Size = new System.Drawing.Size(175, 33);
            this.comboBoxTeamA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz drużynę 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz drużynę 2";
            // 
            // comboBoxTeamB
            // 
            this.comboBoxTeamB.DropDownHeight = 300;
            this.comboBoxTeamB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeamB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTeamB.FormattingEnabled = true;
            this.comboBoxTeamB.IntegralHeight = false;
            this.comboBoxTeamB.Location = new System.Drawing.Point(240, 71);
            this.comboBoxTeamB.Name = "comboBoxTeamB";
            this.comboBoxTeamB.Size = new System.Drawing.Size(175, 33);
            this.comboBoxTeamB.TabIndex = 3;
            // 
            // btnPlayMatch
            // 
            this.btnPlayMatch.Location = new System.Drawing.Point(106, 165);
            this.btnPlayMatch.Name = "btnPlayMatch";
            this.btnPlayMatch.Size = new System.Drawing.Size(239, 81);
            this.btnPlayMatch.TabIndex = 4;
            this.btnPlayMatch.Text = "Zagraj mecz";
            this.btnPlayMatch.UseVisualStyleBackColor = true;
            this.btnPlayMatch.Click += new System.EventHandler(this.btnPlayMatch_Click);
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatch.Location = new System.Drawing.Point(106, 130);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(0, 30);
            this.lblMatch.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(0, 266);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(116, 36);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Wróć do menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 302);
            this.ControlBox = false;
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.btnPlayMatch);
            this.Controls.Add(this.comboBoxTeamB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTeamA);
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mecz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxTeamA;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxTeamB;
        private Button btnPlayMatch;
        private Label lblMatch;
        private Button btnMenu;
    }
}