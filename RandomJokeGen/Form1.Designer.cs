namespace RandomJokeGen
{
    partial class FrmRandomJoke
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
            this.BtnRandomJoke = new System.Windows.Forms.Button();
            this.ComboBoxCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnRandomJoke
            // 
            this.BtnRandomJoke.CausesValidation = false;
            this.BtnRandomJoke.Location = new System.Drawing.Point(28, 118);
            this.BtnRandomJoke.Name = "BtnRandomJoke";
            this.BtnRandomJoke.Size = new System.Drawing.Size(180, 60);
            this.BtnRandomJoke.TabIndex = 0;
            this.BtnRandomJoke.Text = "Random Joke";
            this.BtnRandomJoke.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCategories
            // 
            this.ComboBoxCategories.FormattingEnabled = true;
            this.ComboBoxCategories.Location = new System.Drawing.Point(56, 54);
            this.ComboBoxCategories.Name = "ComboBoxCategories";
            this.ComboBoxCategories.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCategories.TabIndex = 1;
            // 
            // FrmRandomJoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 234);
            this.Controls.Add(this.ComboBoxCategories);
            this.Controls.Add(this.BtnRandomJoke);
            this.Name = "FrmRandomJoke";
            this.Text = "Random Joke";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRandomJoke;
        private System.Windows.Forms.ComboBox ComboBoxCategories;
    }
}

