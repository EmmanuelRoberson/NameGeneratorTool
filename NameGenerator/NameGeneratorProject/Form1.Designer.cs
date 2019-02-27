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
            this.nameGeneratedButton = new System.Windows.Forms.Button();
            this.nationalitiesDropDox = new System.Windows.Forms.ComboBox();
            this.maleSymbolButton = new System.Windows.Forms.Button();
            this.femaleSymbolButton = new System.Windows.Forms.Button();
            this.japaneseNameGeneratorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveNameButton
            // 
            this.saveNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveNameButton.Location = new System.Drawing.Point(154, 66);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(131, 38);
            this.saveNameButton.TabIndex = 1;
            this.saveNameButton.Text = "SAVE NAME";
            this.saveNameButton.UseVisualStyleBackColor = false;
            this.saveNameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameGeneratedButton
            // 
            this.nameGeneratedButton.Location = new System.Drawing.Point(154, 12);
            this.nameGeneratedButton.Name = "nameGeneratedButton";
            this.nameGeneratedButton.Size = new System.Drawing.Size(131, 21);
            this.nameGeneratedButton.TabIndex = 2;
            this.nameGeneratedButton.Text = "[No name generated]";
            this.nameGeneratedButton.UseVisualStyleBackColor = true;
            this.nameGeneratedButton.Click += new System.EventHandler(this.nameGeneratedButton_Click);
            // 
            // nationalitiesDropDox
            // 
            this.nationalitiesDropDox.FormattingEnabled = true;
            this.nationalitiesDropDox.Items.AddRange(new object[] {
            "American",
            "Hispanic",
            "Japanese",
            "French",
            "Russian",
            "Randomly Generated"});
            this.nationalitiesDropDox.Location = new System.Drawing.Point(12, 12);
            this.nationalitiesDropDox.Name = "nationalitiesDropDox";
            this.nationalitiesDropDox.Size = new System.Drawing.Size(131, 21);
            this.nationalitiesDropDox.TabIndex = 26;
            this.nationalitiesDropDox.SelectedIndexChanged += new System.EventHandler(this.nationalitiesDropDox_SelectedIndexChanged);
            // 
            // maleSymbolButton
            // 
            this.maleSymbolButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maleSymbolButton.BackgroundImage")));
            this.maleSymbolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maleSymbolButton.Location = new System.Drawing.Point(12, 39);
            this.maleSymbolButton.Name = "maleSymbolButton";
            this.maleSymbolButton.Size = new System.Drawing.Size(61, 65);
            this.maleSymbolButton.TabIndex = 27;
            this.maleSymbolButton.UseVisualStyleBackColor = true;
            this.maleSymbolButton.Click += new System.EventHandler(this.maleSymbolButton_Click);
            // 
            // femaleSymbolButton
            // 
            this.femaleSymbolButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("femaleSymbolButton.BackgroundImage")));
            this.femaleSymbolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.femaleSymbolButton.Location = new System.Drawing.Point(82, 39);
            this.femaleSymbolButton.Name = "femaleSymbolButton";
            this.femaleSymbolButton.Size = new System.Drawing.Size(61, 65);
            this.femaleSymbolButton.TabIndex = 28;
            this.femaleSymbolButton.UseVisualStyleBackColor = true;
            this.femaleSymbolButton.Click += new System.EventHandler(this.femaleSymbolButton_Click);
            // 
            // japaneseNameGeneratorButton
            // 
            this.japaneseNameGeneratorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("japaneseNameGeneratorButton.BackgroundImage")));
            this.japaneseNameGeneratorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.japaneseNameGeneratorButton.Location = new System.Drawing.Point(12, 110);
            this.japaneseNameGeneratorButton.Name = "japaneseNameGeneratorButton";
            this.japaneseNameGeneratorButton.Size = new System.Drawing.Size(131, 67);
            this.japaneseNameGeneratorButton.TabIndex = 29;
            this.japaneseNameGeneratorButton.UseVisualStyleBackColor = true;
            this.japaneseNameGeneratorButton.Click += new System.EventHandler(this.japaneseNameGeneratorButton_Click);
            // 
            // nameGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 107);
            this.Controls.Add(this.japaneseNameGeneratorButton);
            this.Controls.Add(this.femaleSymbolButton);
            this.Controls.Add(this.maleSymbolButton);
            this.Controls.Add(this.nationalitiesDropDox);
            this.Controls.Add(this.nameGeneratedButton);
            this.Controls.Add(this.saveNameButton);
            this.Name = "nameGeneratorForm";
            this.Text = "NameGeneratorTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Button nameGeneratedButton;
        private System.Windows.Forms.ComboBox nationalitiesDropDox;
        private System.Windows.Forms.Button maleSymbolButton;
        private System.Windows.Forms.Button femaleSymbolButton;
        private System.Windows.Forms.Button japaneseNameGeneratorButton;
    }
}