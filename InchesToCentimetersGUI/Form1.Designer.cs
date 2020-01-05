namespace InchesToCentimetersGUI
{
    partial class InchesToCentimetersForm
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
            this.inchesTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.solutionDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Enabled = false;
            this.enterLabel.Location = new System.Drawing.Point(81, 113);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(119, 13);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter a length in Inches";
            // 
            // inchesTextBox
            // 
            this.inchesTextBox.Location = new System.Drawing.Point(207, 106);
            this.inchesTextBox.Name = "inchesTextBox";
            this.inchesTextBox.Size = new System.Drawing.Size(75, 20);
            this.inchesTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(207, 148);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // solutionDisplayLabel
            // 
            this.solutionDisplayLabel.AutoSize = true;
            this.solutionDisplayLabel.Location = new System.Drawing.Point(81, 186);
            this.solutionDisplayLabel.Name = "solutionDisplayLabel";
            this.solutionDisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.solutionDisplayLabel.TabIndex = 2;
            // 
            // InchesToCentimetersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solutionDisplayLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.inchesTextBox);
            this.Controls.Add(this.enterLabel);
            this.Name = "InchesToCentimetersForm";
            this.Text = "Inches To Centimeters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox inchesTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label solutionDisplayLabel;
    }
}

