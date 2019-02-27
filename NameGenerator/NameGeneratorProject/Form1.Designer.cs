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
            this.SuspendLayout();
            // 
            // randomGeneratedNameButton
            // 
            this.randomGeneratedNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomGeneratedNameButton.Location = new System.Drawing.Point(212, 12);
            this.randomGeneratedNameButton.Name = "randomGeneratedNameButton";
            this.randomGeneratedNameButton.Size = new System.Drawing.Size(93, 38);
            this.randomGeneratedNameButton.TabIndex = 0;
            this.randomGeneratedNameButton.Text = "GENERATE";
            this.randomGeneratedNameButton.UseVisualStyleBackColor = true;
            this.randomGeneratedNameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveNameButton
            // 
            this.saveNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveNameButton.Location = new System.Drawing.Point(212, 56);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(93, 36);
            this.saveNameButton.TabIndex = 1;
            this.saveNameButton.Text = "SAVE NAME";
            this.saveNameButton.UseVisualStyleBackColor = false;
            this.saveNameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameGeneratedButton
            // 
            this.nameGeneratedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameGeneratedButton.Location = new System.Drawing.Point(12, 12);
            this.nameGeneratedButton.Name = "nameGeneratedButton";
            this.nameGeneratedButton.Size = new System.Drawing.Size(172, 80);
            this.nameGeneratedButton.TabIndex = 2;
            this.nameGeneratedButton.Text = "[No name generated]";
            this.nameGeneratedButton.UseVisualStyleBackColor = true;
            this.nameGeneratedButton.Click += new System.EventHandler(this.nameGeneratedButton_Click);
            // 
            // nameGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 105);
            this.Controls.Add(this.nameGeneratedButton);
            this.Controls.Add(this.saveNameButton);
            this.Controls.Add(this.randomGeneratedNameButton);
            this.Name = "nameGeneratorForm";
            this.Text = "NameGeneratorTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randomGeneratedNameButton;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Button nameGeneratedButton;
    }
}