namespace KCK_WinForms
{
    partial class SettingsForm
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
            this.btnDark = new System.Windows.Forms.RadioButton();
            this.btnLight = new System.Windows.Forms.RadioButton();
            this.btnNormal = new System.Windows.Forms.RadioButton();
            this.btnTournament = new System.Windows.Forms.RadioButton();
            this.comboBoxMatchSpeed = new System.Windows.Forms.ComboBox();
            this.btnFastMatchNo = new System.Windows.Forms.RadioButton();
            this.btnFastMatchYes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDark
            // 
            this.btnDark.AutoSize = true;
            this.btnDark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDark.Location = new System.Drawing.Point(105, 35);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(98, 32);
            this.btnDark.TabIndex = 0;
            this.btnDark.TabStop = true;
            this.btnDark.Text = "Ciemny";
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.CheckedChanged += new System.EventHandler(this.btnDark_CheckedChanged);
            // 
            // btnLight
            // 
            this.btnLight.AutoSize = true;
            this.btnLight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLight.Location = new System.Drawing.Point(6, 35);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(79, 32);
            this.btnLight.TabIndex = 1;
            this.btnLight.TabStop = true;
            this.btnLight.Text = "Jasny";
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.CheckedChanged += new System.EventHandler(this.btnLight_CheckedChanged);
            // 
            // btnNormal
            // 
            this.btnNormal.AutoSize = true;
            this.btnNormal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNormal.Location = new System.Drawing.Point(6, 35);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(113, 32);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.TabStop = true;
            this.btnNormal.Text = "Grupowy";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.CheckedChanged += new System.EventHandler(this.btnNormal_CheckedChanged);
            // 
            // btnTournament
            // 
            this.btnTournament.AutoSize = true;
            this.btnTournament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTournament.Location = new System.Drawing.Point(122, 35);
            this.btnTournament.Name = "btnTournament";
            this.btnTournament.Size = new System.Drawing.Size(128, 32);
            this.btnTournament.TabIndex = 4;
            this.btnTournament.TabStop = true;
            this.btnTournament.Text = "Turniejowy";
            this.btnTournament.UseVisualStyleBackColor = true;
            this.btnTournament.CheckedChanged += new System.EventHandler(this.btnTournament_CheckedChanged);
            // 
            // comboBoxMatchSpeed
            // 
            this.comboBoxMatchSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatchSpeed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMatchSpeed.FormattingEnabled = true;
            this.comboBoxMatchSpeed.Items.AddRange(new object[] {
            "Bardzo wolny",
            "Wolny",
            "Normalny",
            "Szybki",
            "Bardzo szybki"});
            this.comboBoxMatchSpeed.Location = new System.Drawing.Point(49, 354);
            this.comboBoxMatchSpeed.Name = "comboBoxMatchSpeed";
            this.comboBoxMatchSpeed.Size = new System.Drawing.Size(157, 33);
            this.comboBoxMatchSpeed.TabIndex = 5;
            // 
            // btnFastMatchNo
            // 
            this.btnFastMatchNo.AutoSize = true;
            this.btnFastMatchNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFastMatchNo.Location = new System.Drawing.Point(6, 32);
            this.btnFastMatchNo.Name = "btnFastMatchNo";
            this.btnFastMatchNo.Size = new System.Drawing.Size(63, 32);
            this.btnFastMatchNo.TabIndex = 6;
            this.btnFastMatchNo.TabStop = true;
            this.btnFastMatchNo.Text = "Nie";
            this.btnFastMatchNo.UseVisualStyleBackColor = true;
            this.btnFastMatchNo.CheckedChanged += new System.EventHandler(this.btnFastMatchNo_CheckedChanged);
            // 
            // btnFastMatchYes
            // 
            this.btnFastMatchYes.AutoSize = true;
            this.btnFastMatchYes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFastMatchYes.Location = new System.Drawing.Point(75, 32);
            this.btnFastMatchYes.Name = "btnFastMatchYes";
            this.btnFastMatchYes.Size = new System.Drawing.Size(61, 32);
            this.btnFastMatchYes.TabIndex = 7;
            this.btnFastMatchYes.TabStop = true;
            this.btnFastMatchYes.Text = "Tak";
            this.btnFastMatchYes.UseVisualStyleBackColor = true;
            this.btnFastMatchYes.CheckedChanged += new System.EventHandler(this.btnFastMatchYes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prędkość meczu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLight);
            this.groupBox1.Controls.Add(this.btnDark);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(49, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 94);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNormal);
            this.groupBox2.Controls.Add(this.btnTournament);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(49, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 87);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Typ meczu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFastMatchNo);
            this.groupBox3.Controls.Add(this.btnFastMatchYes);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(49, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 101);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instant mecz";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(251, 438);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(116, 36);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Wróć do menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 474);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMatchSpeed);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton btnDark;
        private RadioButton btnLight;
        private RadioButton btnNormal;
        private RadioButton btnTournament;
        private ComboBox comboBoxMatchSpeed;
        private RadioButton btnFastMatchNo;
        private RadioButton btnFastMatchYes;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnMenu;
        private Button button1;
    }
}