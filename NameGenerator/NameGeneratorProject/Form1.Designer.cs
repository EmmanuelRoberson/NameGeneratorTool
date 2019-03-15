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
            this.saveNameButton = new System.Windows.Forms.Button();
            this.nationalitiesDropDox = new System.Windows.Forms.ComboBox();
            this.nameGeneratedText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSpecificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.availableHonorifics = new System.Windows.Forms.ComboBox();
            this.honorificTypeLabel = new System.Windows.Forms.Label();
            this.nameNationalityLabel = new System.Windows.Forms.Label();
            this.honorificComboBox = new System.Windows.Forms.ComboBox();
            this.addTypesOfSpecificationsGroupbox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addNameNationalityButton = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.nameGeneratorTab = new System.Windows.Forms.TabControl();
            this.speficicationsTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.generateNameButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.nameSpecificationsGroupBox.SuspendLayout();
            this.addTypesOfSpecificationsGroupbox.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.nameGeneratorTab.SuspendLayout();
            this.speficicationsTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveNameButton
            // 
            this.saveNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveNameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveNameButton.FlatAppearance.BorderSize = 0;
            this.saveNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNameButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNameButton.Location = new System.Drawing.Point(15, 141);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(171, 45);
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
            // nameGeneratedText
            // 
            this.nameGeneratedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameGeneratedText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGeneratedText.Location = new System.Drawing.Point(15, 107);
            this.nameGeneratedText.Name = "nameGeneratedText";
            this.nameGeneratedText.Size = new System.Drawing.Size(171, 23);
            this.nameGeneratedText.TabIndex = 32;
            this.nameGeneratedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameGeneratedText.TextChanged += new System.EventHandler(this.nameGeneratedText_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(650, -6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(38, 38);
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
            this.panel1.Size = new System.Drawing.Size(688, 29);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            this.nameSpecificationsGroupBox.Controls.Add(this.genderLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.genderComboBox);
            this.nameSpecificationsGroupBox.Controls.Add(this.label2);
            this.nameSpecificationsGroupBox.Controls.Add(this.availableHonorifics);
            this.nameSpecificationsGroupBox.Controls.Add(this.honorificTypeLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.nameNationalityLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.honorificComboBox);
            this.nameSpecificationsGroupBox.Controls.Add(this.nationalitiesDropDox);
            this.nameSpecificationsGroupBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSpecificationsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.nameSpecificationsGroupBox.Name = "nameSpecificationsGroupBox";
            this.nameSpecificationsGroupBox.Size = new System.Drawing.Size(301, 137);
            this.nameSpecificationsGroupBox.TabIndex = 38;
            this.nameSpecificationsGroupBox.TabStop = false;
            this.nameSpecificationsGroupBox.Text = "Name Specifications";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Available Honorifics";
            // 
            // availableHonorifics
            // 
            this.availableHonorifics.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.availableHonorifics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableHonorifics.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableHonorifics.FormattingEnabled = true;
            this.availableHonorifics.Location = new System.Drawing.Point(6, 79);
            this.availableHonorifics.Name = "availableHonorifics";
            this.availableHonorifics.Size = new System.Drawing.Size(148, 24);
            this.availableHonorifics.TabIndex = 30;
            // 
            // honorificTypeLabel
            // 
            this.honorificTypeLabel.AutoSize = true;
            this.honorificTypeLabel.Location = new System.Drawing.Point(160, 52);
            this.honorificTypeLabel.Name = "honorificTypeLabel";
            this.honorificTypeLabel.Size = new System.Drawing.Size(83, 16);
            this.honorificTypeLabel.TabIndex = 29;
            this.honorificTypeLabel.Text = "Honorific Type";
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
            this.honorificComboBox.SelectedIndexChanged += new System.EventHandler(this.honorificComboBox_SelectedIndexChanged);
            // 
            // addTypesOfSpecificationsGroupbox
            // 
            this.addTypesOfSpecificationsGroupbox.Controls.Add(this.textBox1);
            this.addTypesOfSpecificationsGroupbox.Controls.Add(this.addNameNationalityButton);
            this.addTypesOfSpecificationsGroupbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTypesOfSpecificationsGroupbox.Location = new System.Drawing.Point(6, 6);
            this.addTypesOfSpecificationsGroupbox.Name = "addTypesOfSpecificationsGroupbox";
            this.addTypesOfSpecificationsGroupbox.Size = new System.Drawing.Size(445, 155);
            this.addTypesOfSpecificationsGroupbox.TabIndex = 39;
            this.addTypesOfSpecificationsGroupbox.TabStop = false;
            this.addTypesOfSpecificationsGroupbox.Text = "Add Your Own";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 3;
            // 
            // addNameNationalityButton
            // 
            this.addNameNationalityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNameNationalityButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addNameNationalityButton.FlatAppearance.BorderSize = 0;
            this.addNameNationalityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.addNameNationalityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNameNationalityButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNameNationalityButton.Location = new System.Drawing.Point(142, 19);
            this.addNameNationalityButton.Name = "addNameNationalityButton";
            this.addNameNationalityButton.Size = new System.Drawing.Size(108, 24);
            this.addNameNationalityButton.TabIndex = 2;
            this.addNameNationalityButton.Text = "Add  Nationality";
            this.addNameNationalityButton.UseVisualStyleBackColor = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripContainer1.ContentPanel.Controls.Add(this.generateNameButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.saveNameButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.nameGeneratedText);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(201, 202);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripContainer1.Location = new System.Drawing.Point(483, 35);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(201, 202);
            this.toolStripContainer1.TabIndex = 40;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // nameGeneratorTab
            // 
            this.nameGeneratorTab.Controls.Add(this.speficicationsTab);
            this.nameGeneratorTab.Controls.Add(this.tabPage2);
            this.nameGeneratorTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.nameGeneratorTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGeneratorTab.Location = new System.Drawing.Point(12, 35);
            this.nameGeneratorTab.Name = "nameGeneratorTab";
            this.nameGeneratorTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameGeneratorTab.SelectedIndex = 0;
            this.nameGeneratorTab.Size = new System.Drawing.Size(465, 202);
            this.nameGeneratorTab.TabIndex = 41;
            this.nameGeneratorTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.nameGeneratorTab_DrawItem);
            // 
            // speficicationsTab
            // 
            this.speficicationsTab.BackColor = System.Drawing.Color.White;
            this.speficicationsTab.Controls.Add(this.nameSpecificationsGroupBox);
            this.speficicationsTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speficicationsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.speficicationsTab.Location = new System.Drawing.Point(4, 25);
            this.speficicationsTab.Name = "speficicationsTab";
            this.speficicationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.speficicationsTab.Size = new System.Drawing.Size(457, 173);
            this.speficicationsTab.TabIndex = 0;
            this.speficicationsTab.Text = "Specifications";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addTypesOfSpecificationsGroupbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(457, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.genderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(6, 107);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(148, 24);
            this.genderComboBox.TabIndex = 32;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(160, 110);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(50, 16);
            this.genderLabel.TabIndex = 33;
            this.genderLabel.Text = "Gender";
            // 
            // generateNameButton
            // 
            this.generateNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.generateNameButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.generateNameButton.FlatAppearance.BorderSize = 0;
            this.generateNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.generateNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateNameButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNameButton.Location = new System.Drawing.Point(15, 16);
            this.generateNameButton.Name = "generateNameButton";
            this.generateNameButton.Size = new System.Drawing.Size(171, 83);
            this.generateNameButton.TabIndex = 33;
            this.generateNameButton.Text = "Generate";
            this.generateNameButton.UseVisualStyleBackColor = false;
            this.generateNameButton.Click += new System.EventHandler(this.generateNameButton_Click);
            // 
            // nameGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 245);
            this.Controls.Add(this.nameGeneratorTab);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nameGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameGeneratorForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nameGeneratorForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nameSpecificationsGroupBox.ResumeLayout(false);
            this.nameSpecificationsGroupBox.PerformLayout();
            this.addTypesOfSpecificationsGroupbox.ResumeLayout(false);
            this.addTypesOfSpecificationsGroupbox.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.nameGeneratorTab.ResumeLayout(false);
            this.speficicationsTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.ComboBox nationalitiesDropDox;
        private System.Windows.Forms.TextBox nameGeneratedText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox nameSpecificationsGroupBox;
        private System.Windows.Forms.ComboBox honorificComboBox;
        private System.Windows.Forms.Label honorificTypeLabel;
        private System.Windows.Forms.Label nameNationalityLabel;
        private System.Windows.Forms.ComboBox availableHonorifics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox addTypesOfSpecificationsGroupbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addNameNationalityButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl nameGeneratorTab;
        private System.Windows.Forms.TabPage speficicationsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button generateNameButton;
    }
}