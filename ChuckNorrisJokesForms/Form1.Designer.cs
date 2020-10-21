namespace ChuckNorrisJokesForms
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
            this.generateJokeBtn = new System.Windows.Forms.Button();
            this.categoryCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // generateJokeBtn
            // 
            this.generateJokeBtn.Location = new System.Drawing.Point(35, 65);
            this.generateJokeBtn.Name = "generateJokeBtn";
            this.generateJokeBtn.Size = new System.Drawing.Size(135, 80);
            this.generateJokeBtn.TabIndex = 0;
            this.generateJokeBtn.Text = "Generate Joke";
            this.generateJokeBtn.UseVisualStyleBackColor = true;
            // 
            // categoryCbox
            // 
            this.categoryCbox.FormattingEnabled = true;
            this.categoryCbox.Location = new System.Drawing.Point(226, 65);
            this.categoryCbox.Name = "categoryCbox";
            this.categoryCbox.Size = new System.Drawing.Size(121, 21);
            this.categoryCbox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 226);
            this.Controls.Add(this.categoryCbox);
            this.Controls.Add(this.generateJokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateJokeBtn;
        private System.Windows.Forms.ComboBox categoryCbox;
    }
}

