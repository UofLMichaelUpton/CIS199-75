namespace ProjectedRaisesGUI
{
    partial class projectedRaiseForm
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
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.calculateSalaryButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(353, 90);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 0;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Enabled = false;
            this.salaryLabel.Location = new System.Drawing.Point(217, 97);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(121, 13);
            this.salaryLabel.TabIndex = 1;
            this.salaryLabel.Text = "Enter your current salary";
            // 
            // calculateSalaryButton
            // 
            this.calculateSalaryButton.Location = new System.Drawing.Point(353, 131);
            this.calculateSalaryButton.Name = "calculateSalaryButton";
            this.calculateSalaryButton.Size = new System.Drawing.Size(100, 23);
            this.calculateSalaryButton.TabIndex = 2;
            this.calculateSalaryButton.Text = "Calculate Salary";
            this.calculateSalaryButton.UseVisualStyleBackColor = true;
            this.calculateSalaryButton.Click += new System.EventHandler(this.CalculateSalaryButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Enabled = false;
            this.displayLabel.Location = new System.Drawing.Point(220, 168);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 3;
            // 
            // projectedRaiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.calculateSalaryButton);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Name = "projectedRaiseForm";
            this.Text = "Projected Raise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Button calculateSalaryButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

