namespace NameGeneratorProject
{
    partial class nameGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nameGeneratorForm));
            this.saveNameButton = new System.Windows.Forms.Button();
            this.nationalitiesDropDox = new System.Windows.Forms.ComboBox();
            this.maleSymbolButton = new System.Windows.Forms.Button();
            this.femaleSymbolButton = new System.Windows.Forms.Button();
            this.japaneseNameGeneratorButton = new System.Windows.Forms.Button();
            this.randomlyGeneratedNameButton = new System.Windows.Forms.Button();
            this.nameGeneratedText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSpecificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.honorificComboBox = new System.Windows.Forms.ComboBox();
            this.nameNationalityLabel = new System.Windows.Forms.Label();
            this.honorificLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.nameSpecificationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveNameButton
            // 
            this.saveNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveNameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveNameButton.FlatAppearance.BorderSize = 0;
            this.saveNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNameButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNameButton.Location = new System.Drawing.Point(395, 106);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(131, 38);
            this.saveNameButton.TabIndex = 1;
            this.saveNameButton.Text = "SAVE NAME";
            this.saveNameButton.UseVisualStyleBackColor = false;
            this.saveNameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // nationalitiesDropDox
            // 
            this.nationalitiesDropDox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nationalitiesDropDox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nationalitiesDropDox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalitiesDropDox.FormattingEnabled = true;
            this.nationalitiesDropDox.Items.AddRange(new object[] {
            "Randomly Generated"});
            this.nationalitiesDropDox.Location = new System.Drawing.Point(6, 19);
            this.nationalitiesDropDox.Name = "nationalitiesDropDox";
            this.nationalitiesDropDox.Size = new System.Drawing.Size(148, 24);
            this.nationalitiesDropDox.TabIndex = 26;
            this.nationalitiesDropDox.SelectedIndexChanged += new System.EventHandler(this.nationalitiesDropDox_SelectedIndexChanged);
            // 
            // maleSymbolButton
            // 
            this.maleSymbolButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maleSymbolButton.BackgroundImage")));
            this.maleSymbolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maleSymbolButton.Location = new System.Drawing.Point(395, 170);
            this.maleSymbolButton.Name = "maleSymbolButton";
            this.maleSymbolButton.Size = new System.Drawing.Size(42, 38);
            this.maleSymbolButton.TabIndex = 27;
            this.maleSymbolButton.UseVisualStyleBackColor = true;
            this.maleSymbolButton.Click += new System.EventHandler(this.maleSymbolButton_Click);
            // 
            // femaleSymbolButton
            // 
            this.femaleSymbolButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("femaleSymbolButton.BackgroundImage")));
            this.femaleSymbolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.femaleSymbolButton.Location = new System.Drawing.Point(443, 170);
            this.femaleSymbolButton.Name = "femaleSymbolButton";
            this.femaleSymbolButton.Size = new System.Drawing.Size(42, 38);
            this.femaleSymbolButton.TabIndex = 28;
            this.femaleSymbolButton.UseVisualStyleBackColor = true;
            this.femaleSymbolButton.Click += new System.EventHandler(this.femaleSymbolButton_Click);
            // 
            // japaneseNameGeneratorButton
            // 
            this.japaneseNameGeneratorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("japaneseNameGeneratorButton.BackgroundImage")));
            this.japaneseNameGeneratorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.japaneseNameGeneratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.japaneseNameGeneratorButton.Location = new System.Drawing.Point(294, 150);
            this.japaneseNameGeneratorButton.Name = "japaneseNameGeneratorButton";
            this.japaneseNameGeneratorButton.Size = new System.Drawing.Size(95, 58);
            this.japaneseNameGeneratorButton.TabIndex = 29;
            this.japaneseNameGeneratorButton.UseVisualStyleBackColor = true;
            this.japaneseNameGeneratorButton.Click += new System.EventHandler(this.japaneseNameGeneratorButton_Click);
            // 
            // randomlyGeneratedNameButton
            // 
            this.randomlyGeneratedNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.randomlyGeneratedNameButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.randomlyGeneratedNameButton.FlatAppearance.BorderSize = 0;
            this.randomlyGeneratedNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.randomlyGeneratedNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.randomlyGeneratedNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomlyGeneratedNameButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomlyGeneratedNameButton.Location = new System.Drawing.Point(294, 44);
            this.randomlyGeneratedNameButton.Name = "randomlyGeneratedNameButton";
            this.randomlyGeneratedNameButton.Size = new System.Drawing.Size(95, 100);
            this.randomlyGeneratedNameButton.TabIndex = 31;
            this.randomlyGeneratedNameButton.Text = "Generate";
            this.randomlyGeneratedNameButton.UseVisualStyleBackColor = false;
            this.randomlyGeneratedNameButton.Click += new System.EventHandler(this.randomlyGeneratedNameButton_Click);
            // 
            // nameGeneratedText
            // 
            this.nameGeneratedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameGeneratedText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGeneratedText.Location = new System.Drawing.Point(395, 77);
            this.nameGeneratedText.Name = "nameGeneratedText";
            this.nameGeneratedText.Size = new System.Drawing.Size(131, 23);
            this.nameGeneratedText.TabIndex = 32;
            this.nameGeneratedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameGeneratedText.TextChanged += new System.EventHandler(this.nameGeneratedText_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(499, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 24);
            this.exitButton.TabIndex = 36;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 29);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name Generator Tool\r\n";
            // 
            // nameSpecificationsGroupBox
            // 
            this.nameSpecificationsGroupBox.Controls.Add(this.comboBox1);
            this.nameSpecificationsGroupBox.Controls.Add(this.honorificLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.nameNationalityLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.honorificComboBox);
            this.nameSpecificationsGroupBox.Controls.Add(this.nationalitiesDropDox);
            this.nameSpecificationsGroupBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSpecificationsGroupBox.Location = new System.Drawing.Point(8, 35);
            this.nameSpecificationsGroupBox.Name = "nameSpecificationsGroupBox";
            this.nameSpecificationsGroupBox.Size = new System.Drawing.Size(269, 109);
            this.nameSpecificationsGroupBox.TabIndex = 38;
            this.nameSpecificationsGroupBox.TabStop = false;
            this.nameSpecificationsGroupBox.Text = "Name Specifications";
            // 
            // honorificComboBox
            // 
            this.honorificComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.honorificComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.honorificComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honorificComboBox.FormattingEnabled = true;
            this.honorificComboBox.Location = new System.Drawing.Point(6, 49);
            this.honorificComboBox.Name = "honorificComboBox";
            this.honorificComboBox.Size = new System.Drawing.Size(148, 24);
            this.honorificComboBox.TabIndex = 27;
            // 
            // nameNationalityLabel
            // 
            this.nameNationalityLabel.AutoSize = true;
            this.nameNationalityLabel.Location = new System.Drawing.Point(160, 27);
            this.nameNationalityLabel.Name = "nameNationalityLabel";
            this.nameNationalityLabel.Size = new System.Drawing.Size(102, 16);
            this.nameNationalityLabel.TabIndex = 28;
            this.nameNationalityLabel.Text = "Name Nationality";
            // 
            // honorificLabel
            // 
            this.honorificLabel.AutoSize = true;
            this.honorificLabel.Location = new System.Drawing.Point(160, 57);
            this.honorificLabel.Name = "honorificLabel";
            this.honorificLabel.Size = new System.Drawing.Size(54, 16);
            this.honorificLabel.TabIndex = 29;
            this.honorificLabel.Text = "Honorific";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // nameGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 215);
            this.Controls.Add(this.nameSpecificationsGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameGeneratedText);
            this.Controls.Add(this.randomlyGeneratedNameButton);
            this.Controls.Add(this.japaneseNameGeneratorButton);
            this.Controls.Add(this.femaleSymbolButton);
            this.Controls.Add(this.maleSymbolButton);
            this.Controls.Add(this.saveNameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nameGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameGeneratorTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameGeneratorForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nameGeneratorForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nameSpecificationsGroupBox.ResumeLayout(false);
            this.nameSpecificationsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.ComboBox nationalitiesDropDox;
        private System.Windows.Forms.Button maleSymbolButton;
        private System.Windows.Forms.Button femaleSymbolButton;
        private System.Windows.Forms.Button japaneseNameGeneratorButton;
        private System.Windows.Forms.Button randomlyGeneratedNameButton;
        private System.Windows.Forms.TextBox nameGeneratedText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox nameSpecificationsGroupBox;
        private System.Windows.Forms.ComboBox honorificComboBox;
        private System.Windows.Forms.Label honorificLabel;
        private System.Windows.Forms.Label nameNationalityLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}