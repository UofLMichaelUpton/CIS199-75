namespace MakeChangeGUI
{
    partial class makeChangeForm
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
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Enabled = false;
            this.enterLabel.Location = new System.Drawing.Point(43, 76);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(218, 13);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter a whole dollar amount to make change";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(268, 68);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(67, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Location = new System.Drawing.Point(252, 94);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(101, 23);
            this.calculateChangeButton.TabIndex = 1;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Enabled = false;
            this.displayLabel.Location = new System.Drawing.Point(252, 124);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 2;
            // 
            // makeChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 287);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.enterLabel);
            this.Name = "makeChangeForm";
            this.Text = "Make Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

