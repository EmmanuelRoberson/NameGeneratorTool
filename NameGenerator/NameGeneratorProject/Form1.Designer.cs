namespace NameGeneratorProject
{
    partial class Form1
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
            this.generateName = new System.Windows.Forms.Button();
            this.saveName = new System.Windows.Forms.Button();
            this.nameGeneratedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateName
            // 
            this.generateName.Location = new System.Drawing.Point(12, 12);
            this.generateName.Name = "generateName";
            this.generateName.Size = new System.Drawing.Size(198, 93);
            this.generateName.TabIndex = 0;
            this.generateName.Text = "GENERATE NAME";
            this.generateName.UseVisualStyleBackColor = true;
            this.generateName.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(214, 12);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(198, 93);
            this.saveName.TabIndex = 1;
            this.saveName.Text = "SAVE NAME";
            this.saveName.UseVisualStyleBackColor = true;
            this.saveName.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameGeneratedButton
            // 
            this.nameGeneratedButton.Location = new System.Drawing.Point(13, 112);
            this.nameGeneratedButton.Name = "nameGeneratedButton";
            this.nameGeneratedButton.Size = new System.Drawing.Size(399, 59);
            this.nameGeneratedButton.TabIndex = 2;
            this.nameGeneratedButton.Text = "[No name generated]";
            this.nameGeneratedButton.UseVisualStyleBackColor = true;
            this.nameGeneratedButton.Click += new System.EventHandler(this.nameGeneratedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 183);
            this.Controls.Add(this.nameGeneratedButton);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.generateName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateName;
        private System.Windows.Forms.Button saveName;
        private System.Windows.Forms.Button nameGeneratedButton;
    }
}