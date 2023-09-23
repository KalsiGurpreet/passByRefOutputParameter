namespace passByRefOutputParameter
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
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.countriesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 25;
            this.countriesListBox.Location = new System.Drawing.Point(108, 50);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.countriesListBox.Size = new System.Drawing.Size(516, 254);
            this.countriesListBox.TabIndex = 0;
            // 
            // countriesButton
            // 
            this.countriesButton.Location = new System.Drawing.Point(108, 353);
            this.countriesButton.Name = "countriesButton";
            this.countriesButton.Size = new System.Drawing.Size(178, 60);
            this.countriesButton.TabIndex = 1;
            this.countriesButton.Text = "Get Countries";
            this.countriesButton.UseVisualStyleBackColor = true;
            this.countriesButton.Click += new System.EventHandler(this.countriesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(430, 353);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 60);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit && &Save";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.countriesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countriesButton);
            this.Controls.Add(this.countriesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Button countriesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

