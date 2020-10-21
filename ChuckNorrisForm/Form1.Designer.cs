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
            this.DdCategories = new System.Windows.Forms.ComboBox();
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
            // DdCategories
            // 
            this.DdCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdCategories.FormattingEnabled = true;
            this.DdCategories.Location = new System.Drawing.Point(12, 52);
            this.DdCategories.Name = "DdCategories";
            this.DdCategories.Size = new System.Drawing.Size(121, 21);
            this.DdCategories.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 186);
            this.Controls.Add(this.DdCategories);
            this.Controls.Add(this.BtnGetJoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetJoke;
        private System.Windows.Forms.ComboBox DdCategories;
    }
}

