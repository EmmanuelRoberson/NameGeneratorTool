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
            this.randomGeneratedNameButton = new System.Windows.Forms.Button();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.nameGeneratedButton = new System.Windows.Forms.Button();
            this.hispanicFemaleNameButton = new System.Windows.Forms.Button();
            this.hispanicMaleNameButton = new System.Windows.Forms.Button();
            this.americanMaleName = new System.Windows.Forms.Button();
            this.americanFemaleName = new System.Windows.Forms.Button();
            this.americanNameLabel = new System.Windows.Forms.Label();
            this.hispanicNameLabel = new System.Windows.Forms.Label();
            this.japaneseNameLabel = new System.Windows.Forms.Label();
            this.japaneseMaleButton = new System.Windows.Forms.Button();
            this.japaneseFemaleNameButton = new System.Windows.Forms.Button();
            this.japaneseRandomGeneratedNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomGeneratedNameButton
            // 
            this.randomGeneratedNameButton.Location = new System.Drawing.Point(12, 204);
            this.randomGeneratedNameButton.Name = "randomGeneratedNameButton";
            this.randomGeneratedNameButton.Size = new System.Drawing.Size(206, 46);
            this.randomGeneratedNameButton.TabIndex = 0;
            this.randomGeneratedNameButton.Text = "RANDOM GENERATED NAME";
            this.randomGeneratedNameButton.UseVisualStyleBackColor = true;
            this.randomGeneratedNameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveNameButton
            // 
            this.saveNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveNameButton.Location = new System.Drawing.Point(416, 256);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(198, 93);
            this.saveNameButton.TabIndex = 1;
            this.saveNameButton.Text = "SAVE NAME";
            this.saveNameButton.UseVisualStyleBackColor = false;
            this.saveNameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameGeneratedButton
            // 
            this.nameGeneratedButton.Location = new System.Drawing.Point(12, 256);
            this.nameGeneratedButton.Name = "nameGeneratedButton";
            this.nameGeneratedButton.Size = new System.Drawing.Size(398, 93);
            this.nameGeneratedButton.TabIndex = 2;
            this.nameGeneratedButton.Text = "[No name generated]";
            this.nameGeneratedButton.UseVisualStyleBackColor = true;
            this.nameGeneratedButton.Click += new System.EventHandler(this.nameGeneratedButton_Click);
            // 
            // hispanicFemaleNameButton
            // 
            this.hispanicFemaleNameButton.Location = new System.Drawing.Point(125, 72);
            this.hispanicFemaleNameButton.Name = "hispanicFemaleNameButton";
            this.hispanicFemaleNameButton.Size = new System.Drawing.Size(93, 41);
            this.hispanicFemaleNameButton.TabIndex = 7;
            this.hispanicFemaleNameButton.Text = "FEMALE NAME";
            this.hispanicFemaleNameButton.UseVisualStyleBackColor = true;
            this.hispanicFemaleNameButton.Click += new System.EventHandler(this.hispanicFemaleNameButton_Click);
            // 
            // hispanicMaleNameButton
            // 
            this.hispanicMaleNameButton.Location = new System.Drawing.Point(125, 25);
            this.hispanicMaleNameButton.Name = "hispanicMaleNameButton";
            this.hispanicMaleNameButton.Size = new System.Drawing.Size(93, 41);
            this.hispanicMaleNameButton.TabIndex = 8;
            this.hispanicMaleNameButton.Text = "MALE NAME";
            this.hispanicMaleNameButton.UseVisualStyleBackColor = true;
            this.hispanicMaleNameButton.Click += new System.EventHandler(this.hispanicMaleNameButton_Click);
            // 
            // americanMaleName
            // 
            this.americanMaleName.Location = new System.Drawing.Point(12, 25);
            this.americanMaleName.Name = "americanMaleName";
            this.americanMaleName.Size = new System.Drawing.Size(93, 41);
            this.americanMaleName.TabIndex = 10;
            this.americanMaleName.Text = "MALE NAME";
            this.americanMaleName.UseVisualStyleBackColor = true;
            this.americanMaleName.Click += new System.EventHandler(this.americanMaleName_Click);
            // 
            // americanFemaleName
            // 
            this.americanFemaleName.Location = new System.Drawing.Point(12, 72);
            this.americanFemaleName.Name = "americanFemaleName";
            this.americanFemaleName.Size = new System.Drawing.Size(93, 41);
            this.americanFemaleName.TabIndex = 11;
            this.americanFemaleName.Text = "FEMALE NAME";
            this.americanFemaleName.UseVisualStyleBackColor = true;
            this.americanFemaleName.Click += new System.EventHandler(this.americanFemaleName_Click);
            // 
            // americanNameLabel
            // 
            this.americanNameLabel.AutoSize = true;
            this.americanNameLabel.Location = new System.Drawing.Point(44, 9);
            this.americanNameLabel.Name = "americanNameLabel";
            this.americanNameLabel.Size = new System.Drawing.Size(29, 13);
            this.americanNameLabel.TabIndex = 12;
            this.americanNameLabel.Text = "USA";
            this.americanNameLabel.Click += new System.EventHandler(this.americanNameLabel_Click);
            // 
            // hispanicNameLabel
            // 
            this.hispanicNameLabel.AutoSize = true;
            this.hispanicNameLabel.Location = new System.Drawing.Point(160, 9);
            this.hispanicNameLabel.Name = "hispanicNameLabel";
            this.hispanicNameLabel.Size = new System.Drawing.Size(25, 13);
            this.hispanicNameLabel.TabIndex = 13;
            this.hispanicNameLabel.Text = "HIS";
            this.hispanicNameLabel.Click += new System.EventHandler(this.hispanicNameLabel_Click);
            // 
            // japaneseNameLabel
            // 
            this.japaneseNameLabel.AutoSize = true;
            this.japaneseNameLabel.Location = new System.Drawing.Point(270, 9);
            this.japaneseNameLabel.Name = "japaneseNameLabel";
            this.japaneseNameLabel.Size = new System.Drawing.Size(26, 13);
            this.japaneseNameLabel.TabIndex = 14;
            this.japaneseNameLabel.Text = "JAP";
            this.japaneseNameLabel.Click += new System.EventHandler(this.japaneseNameLabel_Click);
            // 
            // japaneseMaleButton
            // 
            this.japaneseMaleButton.Location = new System.Drawing.Point(238, 25);
            this.japaneseMaleButton.Name = "japaneseMaleButton";
            this.japaneseMaleButton.Size = new System.Drawing.Size(93, 41);
            this.japaneseMaleButton.TabIndex = 15;
            this.japaneseMaleButton.Text = "MALE NAME";
            this.japaneseMaleButton.UseVisualStyleBackColor = true;
            this.japaneseMaleButton.Click += new System.EventHandler(this.japaneseMaleButton_Click);
            // 
            // japaneseFemaleNameButton
            // 
            this.japaneseFemaleNameButton.Location = new System.Drawing.Point(238, 72);
            this.japaneseFemaleNameButton.Name = "japaneseFemaleNameButton";
            this.japaneseFemaleNameButton.Size = new System.Drawing.Size(93, 41);
            this.japaneseFemaleNameButton.TabIndex = 16;
            this.japaneseFemaleNameButton.Text = "FEMALE NAME";
            this.japaneseFemaleNameButton.UseVisualStyleBackColor = true;
            this.japaneseFemaleNameButton.Click += new System.EventHandler(this.japaneseFemaleNameButton_Click);
            // 
            // japaneseRandomGeneratedNameButton
            // 
            this.japaneseRandomGeneratedNameButton.Location = new System.Drawing.Point(238, 119);
            this.japaneseRandomGeneratedNameButton.Name = "japaneseRandomGeneratedNameButton";
            this.japaneseRandomGeneratedNameButton.Size = new System.Drawing.Size(93, 41);
            this.japaneseRandomGeneratedNameButton.TabIndex = 17;
            this.japaneseRandomGeneratedNameButton.Text = "RANDOM NAME";
            this.japaneseRandomGeneratedNameButton.UseVisualStyleBackColor = true;
            this.japaneseRandomGeneratedNameButton.Click += new System.EventHandler(this.japaneseRandomGeneratedNameButton_Click);
            // 
            // nameGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 353);
            this.Controls.Add(this.japaneseRandomGeneratedNameButton);
            this.Controls.Add(this.japaneseFemaleNameButton);
            this.Controls.Add(this.japaneseMaleButton);
            this.Controls.Add(this.japaneseNameLabel);
            this.Controls.Add(this.hispanicNameLabel);
            this.Controls.Add(this.americanNameLabel);
            this.Controls.Add(this.americanFemaleName);
            this.Controls.Add(this.americanMaleName);
            this.Controls.Add(this.hispanicMaleNameButton);
            this.Controls.Add(this.hispanicFemaleNameButton);
            this.Controls.Add(this.nameGeneratedButton);
            this.Controls.Add(this.saveNameButton);
            this.Controls.Add(this.randomGeneratedNameButton);
            this.Name = "nameGeneratorForm";
            this.Text = "NameGeneratorTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomGeneratedNameButton;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Button nameGeneratedButton;
        private System.Windows.Forms.Button hispanicFemaleNameButton;
        private System.Windows.Forms.Button hispanicMaleNameButton;
        private System.Windows.Forms.Button americanMaleName;
        private System.Windows.Forms.Button americanFemaleName;
        private System.Windows.Forms.Label americanNameLabel;
        private System.Windows.Forms.Label hispanicNameLabel;
        private System.Windows.Forms.Label japaneseNameLabel;
        private System.Windows.Forms.Button japaneseMaleButton;
        private System.Windows.Forms.Button japaneseFemaleNameButton;
        private System.Windows.Forms.Button japaneseRandomGeneratedNameButton;
    }
}