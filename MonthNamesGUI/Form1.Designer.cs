namespace MonthNamesGUI
{
    partial class monthNameForm
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
            this.enterMonthLabel = new System.Windows.Forms.Label();
            this.monthNumberTextBox = new System.Windows.Forms.TextBox();
            this.monthNameButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterMonthLabel
            // 
            this.enterMonthLabel.AutoSize = true;
            this.enterMonthLabel.Enabled = false;
            this.enterMonthLabel.Location = new System.Drawing.Point(104, 57);
            this.enterMonthLabel.Name = "enterMonthLabel";
            this.enterMonthLabel.Size = new System.Drawing.Size(141, 13);
            this.enterMonthLabel.TabIndex = 0;
            this.enterMonthLabel.Text = "Enter the number of a month";
            // 
            // monthNumberTextBox
            // 
            this.monthNumberTextBox.Location = new System.Drawing.Point(251, 50);
            this.monthNumberTextBox.Name = "monthNumberTextBox";
            this.monthNumberTextBox.Size = new System.Drawing.Size(34, 20);
            this.monthNumberTextBox.TabIndex = 0;
            // 
            // monthNameButton
            // 
            this.monthNameButton.Location = new System.Drawing.Point(159, 85);
            this.monthNameButton.Name = "monthNameButton";
            this.monthNameButton.Size = new System.Drawing.Size(86, 23);
            this.monthNameButton.TabIndex = 1;
            this.monthNameButton.Text = "Month Name";
            this.monthNameButton.UseVisualStyleBackColor = true;
            this.monthNameButton.Click += new System.EventHandler(this.monthNameButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Enabled = false;
            this.displayLabel.Location = new System.Drawing.Point(104, 124);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 0;
            // 
            // monthNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 222);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.monthNameButton);
            this.Controls.Add(this.monthNumberTextBox);
            this.Controls.Add(this.enterMonthLabel);
            this.Name = "monthNameForm";
            this.Text = "Month Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterMonthLabel;
        private System.Windows.Forms.TextBox monthNumberTextBox;
        private System.Windows.Forms.Button monthNameButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

