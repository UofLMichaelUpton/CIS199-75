namespace TestsInteractiveGUI
{
    partial class testAverageForm
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
            this.testOneLabel = new System.Windows.Forms.Label();
            this.testTwoLabel = new System.Windows.Forms.Label();
            this.testThreeLabel = new System.Windows.Forms.Label();
            this.testFourLabel = new System.Windows.Forms.Label();
            this.testFiveLabel = new System.Windows.Forms.Label();
            this.testOneTextBox = new System.Windows.Forms.TextBox();
            this.testTwoTextBox = new System.Windows.Forms.TextBox();
            this.testThreeTextBox = new System.Windows.Forms.TextBox();
            this.testFourTextBox = new System.Windows.Forms.TextBox();
            this.testFiveTextBox = new System.Windows.Forms.TextBox();
            this.calculateAverageButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testOneLabel
            // 
            this.testOneLabel.AutoSize = true;
            this.testOneLabel.Enabled = false;
            this.testOneLabel.Location = new System.Drawing.Point(85, 40);
            this.testOneLabel.Name = "testOneLabel";
            this.testOneLabel.Size = new System.Drawing.Size(68, 13);
            this.testOneLabel.TabIndex = 0;
            this.testOneLabel.Text = "Test 1 Score";
            // 
            // testTwoLabel
            // 
            this.testTwoLabel.AutoSize = true;
            this.testTwoLabel.Enabled = false;
            this.testTwoLabel.Location = new System.Drawing.Point(85, 62);
            this.testTwoLabel.Name = "testTwoLabel";
            this.testTwoLabel.Size = new System.Drawing.Size(68, 13);
            this.testTwoLabel.TabIndex = 0;
            this.testTwoLabel.Text = "Test 2 Score";
            // 
            // testThreeLabel
            // 
            this.testThreeLabel.AutoSize = true;
            this.testThreeLabel.Enabled = false;
            this.testThreeLabel.Location = new System.Drawing.Point(85, 84);
            this.testThreeLabel.Name = "testThreeLabel";
            this.testThreeLabel.Size = new System.Drawing.Size(68, 13);
            this.testThreeLabel.TabIndex = 0;
            this.testThreeLabel.Text = "Test 3 Score";
            // 
            // testFourLabel
            // 
            this.testFourLabel.AutoSize = true;
            this.testFourLabel.Enabled = false;
            this.testFourLabel.Location = new System.Drawing.Point(85, 106);
            this.testFourLabel.Name = "testFourLabel";
            this.testFourLabel.Size = new System.Drawing.Size(68, 13);
            this.testFourLabel.TabIndex = 0;
            this.testFourLabel.Text = "Test 4 Score";
            // 
            // testFiveLabel
            // 
            this.testFiveLabel.AutoSize = true;
            this.testFiveLabel.Enabled = false;
            this.testFiveLabel.Location = new System.Drawing.Point(85, 128);
            this.testFiveLabel.Name = "testFiveLabel";
            this.testFiveLabel.Size = new System.Drawing.Size(68, 13);
            this.testFiveLabel.TabIndex = 0;
            this.testFiveLabel.Text = "Test 5 Score";
            // 
            // testOneTextBox
            // 
            this.testOneTextBox.Location = new System.Drawing.Point(159, 33);
            this.testOneTextBox.Name = "testOneTextBox";
            this.testOneTextBox.Size = new System.Drawing.Size(67, 20);
            this.testOneTextBox.TabIndex = 0;
            // 
            // testTwoTextBox
            // 
            this.testTwoTextBox.Location = new System.Drawing.Point(159, 55);
            this.testTwoTextBox.Name = "testTwoTextBox";
            this.testTwoTextBox.Size = new System.Drawing.Size(67, 20);
            this.testTwoTextBox.TabIndex = 1;
            // 
            // testThreeTextBox
            // 
            this.testThreeTextBox.Location = new System.Drawing.Point(159, 77);
            this.testThreeTextBox.Name = "testThreeTextBox";
            this.testThreeTextBox.Size = new System.Drawing.Size(67, 20);
            this.testThreeTextBox.TabIndex = 2;
            // 
            // testFourTextBox
            // 
            this.testFourTextBox.Location = new System.Drawing.Point(159, 99);
            this.testFourTextBox.Name = "testFourTextBox";
            this.testFourTextBox.Size = new System.Drawing.Size(67, 20);
            this.testFourTextBox.TabIndex = 3;
            // 
            // testFiveTextBox
            // 
            this.testFiveTextBox.Location = new System.Drawing.Point(159, 121);
            this.testFiveTextBox.Name = "testFiveTextBox";
            this.testFiveTextBox.Size = new System.Drawing.Size(67, 20);
            this.testFiveTextBox.TabIndex = 4;
            // 
            // calculateAverageButton
            // 
            this.calculateAverageButton.Location = new System.Drawing.Point(141, 147);
            this.calculateAverageButton.Name = "calculateAverageButton";
            this.calculateAverageButton.Size = new System.Drawing.Size(102, 23);
            this.calculateAverageButton.TabIndex = 5;
            this.calculateAverageButton.Text = "Calculate Average";
            this.calculateAverageButton.UseVisualStyleBackColor = true;
            this.calculateAverageButton.Click += new System.EventHandler(this.calculateAverageButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Enabled = false;
            this.displayLabel.Location = new System.Drawing.Point(99, 175);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 6;
            // 
            // testAverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 316);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.calculateAverageButton);
            this.Controls.Add(this.testFiveTextBox);
            this.Controls.Add(this.testFourTextBox);
            this.Controls.Add(this.testThreeTextBox);
            this.Controls.Add(this.testTwoTextBox);
            this.Controls.Add(this.testOneTextBox);
            this.Controls.Add(this.testFiveLabel);
            this.Controls.Add(this.testFourLabel);
            this.Controls.Add(this.testThreeLabel);
            this.Controls.Add(this.testTwoLabel);
            this.Controls.Add(this.testOneLabel);
            this.Name = "testAverageForm";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testOneLabel;
        private System.Windows.Forms.Label testTwoLabel;
        private System.Windows.Forms.Label testThreeLabel;
        private System.Windows.Forms.Label testFourLabel;
        private System.Windows.Forms.Label testFiveLabel;
        private System.Windows.Forms.TextBox testOneTextBox;
        private System.Windows.Forms.TextBox testTwoTextBox;
        private System.Windows.Forms.TextBox testThreeTextBox;
        private System.Windows.Forms.TextBox testFourTextBox;
        private System.Windows.Forms.TextBox testFiveTextBox;
        private System.Windows.Forms.Button calculateAverageButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

