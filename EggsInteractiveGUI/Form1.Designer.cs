namespace EggsInteractiveGUI
{
    partial class eggsInteractiveForm
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
            this.eggsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Enabled = false;
            this.enterLabel.Location = new System.Drawing.Point(91, 79);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(156, 13);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter how many eggs you have";
            // 
            // eggsTextBox
            // 
            this.eggsTextBox.Location = new System.Drawing.Point(253, 72);
            this.eggsTextBox.Name = "eggsTextBox";
            this.eggsTextBox.Size = new System.Drawing.Size(78, 20);
            this.eggsTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(244, 98);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate Dozens";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Enabled = false;
            this.displayLabel.Location = new System.Drawing.Point(222, 132);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 2;
            // 
            // eggsInteractiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.eggsTextBox);
            this.Controls.Add(this.enterLabel);
            this.Name = "eggsInteractiveForm";
            this.Text = "Egg Dozen Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox eggsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

