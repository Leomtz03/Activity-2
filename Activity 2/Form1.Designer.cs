
namespace Activity_2
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
            this.weightLbsLabel = new System.Windows.Forms.Label();
            this.yourWeightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.displayWeightTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightLbsLabel
            // 
            this.weightLbsLabel.AutoSize = true;
            this.weightLbsLabel.Location = new System.Drawing.Point(38, 42);
            this.weightLbsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.weightLbsLabel.Name = "weightLbsLabel";
            this.weightLbsLabel.Size = new System.Drawing.Size(119, 13);
            this.weightLbsLabel.TabIndex = 0;
            this.weightLbsLabel.Text = "Enter your weight in lbs:";
            // 
            // yourWeightLabel
            // 
            this.yourWeightLabel.AutoSize = true;
            this.yourWeightLabel.Location = new System.Drawing.Point(38, 103);
            this.yourWeightLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.yourWeightLabel.Name = "yourWeightLabel";
            this.yourWeightLabel.Size = new System.Drawing.Size(92, 13);
            this.yourWeightLabel.TabIndex = 1;
            this.yourWeightLabel.Text = "Your weight in kg:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(177, 39);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 2;
            // 
            // displayWeightTextBox
            // 
            this.displayWeightTextBox.Location = new System.Drawing.Point(177, 100);
            this.displayWeightTextBox.Name = "displayWeightTextBox";
            this.displayWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.displayWeightTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(202, 160);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 211);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.displayWeightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.yourWeightLabel);
            this.Controls.Add(this.weightLbsLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Your Weight in Kilograms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLbsLabel;
        private System.Windows.Forms.Label yourWeightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox displayWeightTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

