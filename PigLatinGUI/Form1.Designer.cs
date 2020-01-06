namespace PigLatinGUI
{
    partial class pigLatinForm
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
            this.enterLabel = new System.Windows.Forms.Label();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Enabled = false;
            this.enterLabel.Location = new System.Drawing.Point(31, 45);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(178, 13);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter a word to translate to Pig Latin";
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(215, 38);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(115, 20);
            this.wordTextBox.TabIndex = 0;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(134, 75);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 1;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Enabled = false;
            this.displayLabel.Location = new System.Drawing.Point(149, 113);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 0;
            // 
            // pigLatinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 202);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.enterLabel);
            this.Name = "pigLatinForm";
            this.Text = "Pig Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

