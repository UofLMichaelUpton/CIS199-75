namespace MoveEstimatorGUI
{
    partial class moveEstimatorForm
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
            this.hoursLabel = new System.Windows.Forms.Label();
            this.milesLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.calculateMoveEstimateButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Enabled = false;
            this.hoursLabel.Location = new System.Drawing.Point(117, 53);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(109, 13);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Enter estimated hours";
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Enabled = false;
            this.milesLabel.Location = new System.Drawing.Point(117, 88);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(106, 13);
            this.milesLabel.TabIndex = 1;
            this.milesLabel.Text = "Enter estimated miles";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(233, 45);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(84, 20);
            this.hoursTextBox.TabIndex = 0;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(233, 80);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(84, 20);
            this.milesTextBox.TabIndex = 1;
            // 
            // calculateMoveEstimateButton
            // 
            this.calculateMoveEstimateButton.Location = new System.Drawing.Point(221, 118);
            this.calculateMoveEstimateButton.Name = "calculateMoveEstimateButton";
            this.calculateMoveEstimateButton.Size = new System.Drawing.Size(108, 23);
            this.calculateMoveEstimateButton.TabIndex = 2;
            this.calculateMoveEstimateButton.Text = "Calculate Estimate";
            this.calculateMoveEstimateButton.UseVisualStyleBackColor = true;
            this.calculateMoveEstimateButton.Click += new System.EventHandler(this.calculateMoveEstimateButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Enabled = false;
            this.displayLabel.Location = new System.Drawing.Point(218, 149);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 3;
            // 
            // moveEstimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.calculateMoveEstimateButton);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.milesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Name = "moveEstimatorForm";
            this.Text = "Move Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Button calculateMoveEstimateButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

