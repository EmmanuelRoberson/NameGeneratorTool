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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nameGeneratorForm));
            this.nationalitiesDropDox = new System.Windows.Forms.ComboBox();
            this.nameGeneratedText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSpecificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.addToListOfNamesButton = new System.Windows.Forms.Button();
            this.nameLenghNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generateNameButton = new System.Windows.Forms.Button();
            this.nameLengthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.availableHonorifics = new System.Windows.Forms.ComboBox();
            this.honorificTypeLabel = new System.Windows.Forms.Label();
            this.nameNationalityLabel = new System.Windows.Forms.Label();
            this.honorificComboBox = new System.Windows.Forms.ComboBox();
            this.nameGeneratorTab = new System.Windows.Forms.TabControl();
            this.speficicationsTab = new System.Windows.Forms.TabPage();
            this.listGeneratorTab = new System.Windows.Forms.TabPage();
            this.generateNameListButton = new System.Windows.Forms.Button();
            this.genderIncludedGroup = new System.Windows.Forms.GroupBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.honorificTypeIncludedGroup = new System.Windows.Forms.GroupBox();
            this.honorificCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfNamesGeneratedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameClassIncludedGroup = new System.Windows.Forms.GroupBox();
            this.nameClassCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.utilitiesToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listOfGeneratedNamesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.namesGeneratedGroupBox = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.nameLengthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.nameSpecificationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameLenghNumericUpDown)).BeginInit();
            this.nameGeneratorTab.SuspendLayout();
            this.speficicationsTab.SuspendLayout();
            this.listGeneratorTab.SuspendLayout();
            this.genderIncludedGroup.SuspendLayout();
            this.honorificTypeIncludedGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNamesGeneratedNumericUpDown)).BeginInit();
            this.nameClassIncludedGroup.SuspendLayout();
            this.utilitiesToolStrip.SuspendLayout();
            this.namesGeneratedGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.nameGeneratedText.Location = new System.Drawing.Point(292, 79);
            this.nameGeneratedText.Name = "nameGeneratedText";
            this.nameGeneratedText.Size = new System.Drawing.Size(173, 23);
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
            this.exitButton.Location = new System.Drawing.Point(770, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(38, 32);
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
            this.panel1.Size = new System.Drawing.Size(808, 29);
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
            this.nameSpecificationsGroupBox.Controls.Add(this.addToListOfNamesButton);
            this.nameSpecificationsGroupBox.Controls.Add(this.nameGeneratedText);
            this.nameSpecificationsGroupBox.Controls.Add(this.nameLenghNumericUpDown);
            this.nameSpecificationsGroupBox.Controls.Add(this.generateNameButton);
            this.nameSpecificationsGroupBox.Controls.Add(this.nameLengthLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.genderLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.genderComboBox);
            this.nameSpecificationsGroupBox.Controls.Add(this.label2);
            this.nameSpecificationsGroupBox.Controls.Add(this.availableHonorifics);
            this.nameSpecificationsGroupBox.Controls.Add(this.honorificTypeLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.nameNationalityLabel);
            this.nameSpecificationsGroupBox.Controls.Add(this.honorificComboBox);
            this.nameSpecificationsGroupBox.Controls.Add(this.nationalitiesDropDox);
            this.nameSpecificationsGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSpecificationsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.nameSpecificationsGroupBox.Name = "nameSpecificationsGroupBox";
            this.nameSpecificationsGroupBox.Size = new System.Drawing.Size(471, 163);
            this.nameSpecificationsGroupBox.TabIndex = 38;
            this.nameSpecificationsGroupBox.TabStop = false;
            this.nameSpecificationsGroupBox.Text = "Name Specifications";
            // 
            // addToListOfNamesButton
            // 
            this.addToListOfNamesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addToListOfNamesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToListOfNamesButton.FlatAppearance.BorderSize = 2;
            this.addToListOfNamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToListOfNamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.addToListOfNamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToListOfNamesButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToListOfNamesButton.Location = new System.Drawing.Point(292, 108);
            this.addToListOfNamesButton.Name = "addToListOfNamesButton";
            this.addToListOfNamesButton.Size = new System.Drawing.Size(173, 45);
            this.addToListOfNamesButton.TabIndex = 38;
            this.addToListOfNamesButton.Text = "Add to List of Names";
            this.addToListOfNamesButton.UseVisualStyleBackColor = false;
            this.addToListOfNamesButton.Click += new System.EventHandler(this.addToNamesGeneratedButton_Click);
            // 
            // nameLenghNumericUpDown
            // 
            this.nameLenghNumericUpDown.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nameLenghNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameLenghNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLenghNumericUpDown.Location = new System.Drawing.Point(106, 137);
            this.nameLenghNumericUpDown.Name = "nameLenghNumericUpDown";
            this.nameLenghNumericUpDown.Size = new System.Drawing.Size(48, 18);
            this.nameLenghNumericUpDown.TabIndex = 36;
            this.nameLenghNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameLenghNumericUpDown.ValueChanged += new System.EventHandler(this.nameLenghNumericUpDown_ValueChanged);
            // 
            // generateNameButton
            // 
            this.generateNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.generateNameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateNameButton.FlatAppearance.BorderSize = 2;
            this.generateNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.generateNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateNameButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNameButton.Location = new System.Drawing.Point(292, 14);
            this.generateNameButton.Name = "generateNameButton";
            this.generateNameButton.Size = new System.Drawing.Size(173, 59);
            this.generateNameButton.TabIndex = 33;
            this.generateNameButton.Text = "Generate";
            this.generateNameButton.UseVisualStyleBackColor = false;
            this.generateNameButton.Click += new System.EventHandler(this.generateNameButton_Click);
            // 
            // nameLengthLabel
            // 
            this.nameLengthLabel.AutoSize = true;
            this.nameLengthLabel.Location = new System.Drawing.Point(160, 137);
            this.nameLengthLabel.Name = "nameLengthLabel";
            this.nameLengthLabel.Size = new System.Drawing.Size(88, 17);
            this.nameLengthLabel.TabIndex = 35;
            this.nameLengthLabel.Text = "Name Length";
            this.nameLengthToolTip.SetToolTip(this.nameLengthLabel, "Leave at 0 for a short to medium length name");
            this.nameLengthLabel.Click += new System.EventHandler(this.nameLengthLabel_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(160, 110);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(53, 17);
            this.genderLabel.TabIndex = 33;
            this.genderLabel.Text = "Gender";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
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
            this.honorificTypeLabel.Size = new System.Drawing.Size(91, 17);
            this.honorificTypeLabel.TabIndex = 29;
            this.honorificTypeLabel.Text = "Honorific Type";
            // 
            // nameNationalityLabel
            // 
            this.nameNationalityLabel.AutoSize = true;
            this.nameNationalityLabel.Location = new System.Drawing.Point(160, 27);
            this.nameNationalityLabel.Name = "nameNationalityLabel";
            this.nameNationalityLabel.Size = new System.Drawing.Size(77, 17);
            this.nameNationalityLabel.TabIndex = 28;
            this.nameNationalityLabel.Text = "Name Class";
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
            // nameGeneratorTab
            // 
            this.nameGeneratorTab.Controls.Add(this.speficicationsTab);
            this.nameGeneratorTab.Controls.Add(this.listGeneratorTab);
            this.nameGeneratorTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGeneratorTab.Location = new System.Drawing.Point(8, 57);
            this.nameGeneratorTab.Name = "nameGeneratorTab";
            this.nameGeneratorTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameGeneratorTab.SelectedIndex = 0;
            this.nameGeneratorTab.Size = new System.Drawing.Size(494, 200);
            this.nameGeneratorTab.TabIndex = 41;
            this.nameGeneratorTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.nameGeneratorTab_DrawItem);
            // 
            // speficicationsTab
            // 
            this.speficicationsTab.BackColor = System.Drawing.Color.White;
            this.speficicationsTab.Controls.Add(this.nameSpecificationsGroupBox);
            this.speficicationsTab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speficicationsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.speficicationsTab.Location = new System.Drawing.Point(4, 26);
            this.speficicationsTab.Name = "speficicationsTab";
            this.speficicationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.speficicationsTab.Size = new System.Drawing.Size(486, 170);
            this.speficicationsTab.TabIndex = 0;
            this.speficicationsTab.Text = "Name Specifications";
            // 
            // listGeneratorTab
            // 
            this.listGeneratorTab.Controls.Add(this.generateNameListButton);
            this.listGeneratorTab.Controls.Add(this.genderIncludedGroup);
            this.listGeneratorTab.Controls.Add(this.honorificTypeIncludedGroup);
            this.listGeneratorTab.Controls.Add(this.label3);
            this.listGeneratorTab.Controls.Add(this.numberOfNamesGeneratedNumericUpDown);
            this.listGeneratorTab.Controls.Add(this.nameClassIncludedGroup);
            this.listGeneratorTab.Location = new System.Drawing.Point(4, 26);
            this.listGeneratorTab.Name = "listGeneratorTab";
            this.listGeneratorTab.Padding = new System.Windows.Forms.Padding(3);
            this.listGeneratorTab.Size = new System.Drawing.Size(486, 170);
            this.listGeneratorTab.TabIndex = 1;
            this.listGeneratorTab.Text = "List Specifications";
            this.listGeneratorTab.UseVisualStyleBackColor = true;
            // 
            // generateNameListButton
            // 
            this.generateNameListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.generateNameListButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.generateNameListButton.FlatAppearance.BorderSize = 0;
            this.generateNameListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateNameListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.generateNameListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateNameListButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNameListButton.Location = new System.Drawing.Point(306, 105);
            this.generateNameListButton.Name = "generateNameListButton";
            this.generateNameListButton.Size = new System.Drawing.Size(174, 55);
            this.generateNameListButton.TabIndex = 42;
            this.generateNameListButton.Text = "Generate Names";
            this.generateNameListButton.UseVisualStyleBackColor = false;
            this.generateNameListButton.Click += new System.EventHandler(this.generateNameListButton_Click);
            // 
            // genderIncludedGroup
            // 
            this.genderIncludedGroup.Controls.Add(this.checkedListBox2);
            this.genderIncludedGroup.Location = new System.Drawing.Point(306, 6);
            this.genderIncludedGroup.Name = "genderIncludedGroup";
            this.genderIncludedGroup.Size = new System.Drawing.Size(174, 68);
            this.genderIncludedGroup.TabIndex = 41;
            this.genderIncludedGroup.TabStop = false;
            this.genderIncludedGroup.Text = "Gender";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.checkedListBox2.Location = new System.Drawing.Point(6, 21);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(147, 34);
            this.checkedListBox2.TabIndex = 2;
            // 
            // honorificTypeIncludedGroup
            // 
            this.honorificTypeIncludedGroup.Controls.Add(this.honorificCheckBoxList);
            this.honorificTypeIncludedGroup.Location = new System.Drawing.Point(177, 6);
            this.honorificTypeIncludedGroup.Name = "honorificTypeIncludedGroup";
            this.honorificTypeIncludedGroup.Size = new System.Drawing.Size(123, 154);
            this.honorificTypeIncludedGroup.TabIndex = 40;
            this.honorificTypeIncludedGroup.TabStop = false;
            this.honorificTypeIncludedGroup.Text = "Honorific Type";
            // 
            // honorificCheckBoxList
            // 
            this.honorificCheckBoxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.honorificCheckBoxList.FormattingEnabled = true;
            this.honorificCheckBoxList.Items.AddRange(new object[] {
            "American",
            "Hispanic",
            "Japanese",
            "French",
            "Russian"});
            this.honorificCheckBoxList.Location = new System.Drawing.Point(6, 21);
            this.honorificCheckBoxList.Name = "honorificCheckBoxList";
            this.honorificCheckBoxList.Size = new System.Drawing.Size(111, 102);
            this.honorificCheckBoxList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "# of Names";
            // 
            // numberOfNamesGeneratedNumericUpDown
            // 
            this.numberOfNamesGeneratedNumericUpDown.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numberOfNamesGeneratedNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberOfNamesGeneratedNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfNamesGeneratedNumericUpDown.Location = new System.Drawing.Point(306, 80);
            this.numberOfNamesGeneratedNumericUpDown.Name = "numberOfNamesGeneratedNumericUpDown";
            this.numberOfNamesGeneratedNumericUpDown.Size = new System.Drawing.Size(85, 19);
            this.numberOfNamesGeneratedNumericUpDown.TabIndex = 37;
            this.numberOfNamesGeneratedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameClassIncludedGroup
            // 
            this.nameClassIncludedGroup.Controls.Add(this.nameClassCheckBoxList);
            this.nameClassIncludedGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameClassIncludedGroup.Location = new System.Drawing.Point(6, 6);
            this.nameClassIncludedGroup.Name = "nameClassIncludedGroup";
            this.nameClassIncludedGroup.Size = new System.Drawing.Size(165, 154);
            this.nameClassIncludedGroup.TabIndex = 39;
            this.nameClassIncludedGroup.TabStop = false;
            this.nameClassIncludedGroup.Text = "Name Class";
            // 
            // nameClassCheckBoxList
            // 
            this.nameClassCheckBoxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameClassCheckBoxList.FormattingEnabled = true;
            this.nameClassCheckBoxList.Items.AddRange(new object[] {
            "Randomly Generated",
            "American",
            "Hispanic",
            "Japanese",
            "French",
            "Russian"});
            this.nameClassCheckBoxList.Location = new System.Drawing.Point(6, 21);
            this.nameClassCheckBoxList.Name = "nameClassCheckBoxList";
            this.nameClassCheckBoxList.Size = new System.Drawing.Size(147, 119);
            this.nameClassCheckBoxList.TabIndex = 0;
            // 
            // utilitiesToolStrip
            // 
            this.utilitiesToolStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.utilitiesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.helpToolStripDropDownButton});
            this.utilitiesToolStrip.Location = new System.Drawing.Point(0, 29);
            this.utilitiesToolStrip.Name = "utilitiesToolStrip";
            this.utilitiesToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.utilitiesToolStrip.Size = new System.Drawing.Size(808, 25);
            this.utilitiesToolStrip.TabIndex = 42;
            // 
            // fileButton
            // 
            this.fileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileButton.ImageTransparentColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(41, 22);
            this.fileButton.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // helpToolStripDropDownButton
            // 
            this.helpToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripDropDownButton.Image")));
            this.helpToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripDropDownButton.Name = "helpToolStripDropDownButton";
            this.helpToolStripDropDownButton.Size = new System.Drawing.Size(45, 22);
            this.helpToolStripDropDownButton.Text = "Help";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // listOfGeneratedNamesRichTextBox
            // 
            this.listOfGeneratedNamesRichTextBox.AcceptsTab = true;
            this.listOfGeneratedNamesRichTextBox.AutoWordSelection = true;
            this.listOfGeneratedNamesRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.listOfGeneratedNamesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfGeneratedNamesRichTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfGeneratedNamesRichTextBox.Location = new System.Drawing.Point(6, 20);
            this.listOfGeneratedNamesRichTextBox.Name = "listOfGeneratedNamesRichTextBox";
            this.listOfGeneratedNamesRichTextBox.Size = new System.Drawing.Size(239, 174);
            this.listOfGeneratedNamesRichTextBox.TabIndex = 48;
            this.listOfGeneratedNamesRichTextBox.Text = "";
            this.listOfGeneratedNamesRichTextBox.TextChanged += new System.EventHandler(this.listOfGeneratedNamesRichTextBox_TextChanged);
            // 
            // namesGeneratedGroupBox
            // 
            this.namesGeneratedGroupBox.BackColor = System.Drawing.Color.White;
            this.namesGeneratedGroupBox.Controls.Add(this.listOfGeneratedNamesRichTextBox);
            this.namesGeneratedGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesGeneratedGroupBox.Location = new System.Drawing.Point(545, 57);
            this.namesGeneratedGroupBox.Name = "namesGeneratedGroupBox";
            this.namesGeneratedGroupBox.Size = new System.Drawing.Size(251, 200);
            this.namesGeneratedGroupBox.TabIndex = 49;
            this.namesGeneratedGroupBox.TabStop = false;
            this.namesGeneratedGroupBox.Text = "List of Names";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 54);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 210);
            this.splitter1.TabIndex = 50;
            this.splitter1.TabStop = false;
            // 
            // nameGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 264);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.namesGeneratedGroupBox);
            this.Controls.Add(this.utilitiesToolStrip);
            this.Controls.Add(this.nameGeneratorTab);
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
            ((System.ComponentModel.ISupportInitialize)(this.nameLenghNumericUpDown)).EndInit();
            this.nameGeneratorTab.ResumeLayout(false);
            this.speficicationsTab.ResumeLayout(false);
            this.listGeneratorTab.ResumeLayout(false);
            this.listGeneratorTab.PerformLayout();
            this.genderIncludedGroup.ResumeLayout(false);
            this.honorificTypeIncludedGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNamesGeneratedNumericUpDown)).EndInit();
            this.nameClassIncludedGroup.ResumeLayout(false);
            this.utilitiesToolStrip.ResumeLayout(false);
            this.utilitiesToolStrip.PerformLayout();
            this.namesGeneratedGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TabControl nameGeneratorTab;
        private System.Windows.Forms.TabPage speficicationsTab;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button generateNameButton;
        private System.Windows.Forms.Label nameLengthLabel;
        private System.Windows.Forms.NumericUpDown nameLenghNumericUpDown;
        private System.Windows.Forms.ToolStrip utilitiesToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton fileButton;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton helpToolStripDropDownButton;
        private System.Windows.Forms.RichTextBox listOfGeneratedNamesRichTextBox;
        private System.Windows.Forms.GroupBox namesGeneratedGroupBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button addToListOfNamesButton;
        private System.Windows.Forms.TabPage listGeneratorTab;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox honorificCheckBoxList;
        private System.Windows.Forms.CheckedListBox nameClassCheckBoxList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberOfNamesGeneratedNumericUpDown;
        private System.Windows.Forms.GroupBox nameClassIncludedGroup;
        private System.Windows.Forms.GroupBox honorificTypeIncludedGroup;
        private System.Windows.Forms.GroupBox genderIncludedGroup;
        private System.Windows.Forms.Button generateNameListButton;
        private System.Windows.Forms.ToolTip nameLengthToolTip;
    }
}