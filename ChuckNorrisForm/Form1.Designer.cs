namespace ChuckNorrisForm
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
            this.BtnGetJoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGetJoke
            // 
            this.BtnGetJoke.Location = new System.Drawing.Point(194, 52);
            this.BtnGetJoke.Name = "BtnGetJoke";
            this.BtnGetJoke.Size = new System.Drawing.Size(110, 53);
            this.BtnGetJoke.TabIndex = 0;
            this.BtnGetJoke.Text = "Get Joke";
            this.BtnGetJoke.UseVisualStyleBackColor = true;
            this.BtnGetJoke.Click += new System.EventHandler(this.BtnGetJoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 186);
            this.Controls.Add(this.BtnGetJoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetJoke;
    }
}

