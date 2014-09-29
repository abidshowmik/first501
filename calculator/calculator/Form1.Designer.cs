namespace calculator
{
    partial class CalculatorForm
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
            this.firstnumberLabel = new System.Windows.Forms.Label();
            this.secondnumberLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.firstnumberTextBox = new System.Windows.Forms.TextBox();
            this.secondnumberTextbox = new System.Windows.Forms.TextBox();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstnumberLabel
            // 
            this.firstnumberLabel.AutoSize = true;
            this.firstnumberLabel.Location = new System.Drawing.Point(42, 41);
            this.firstnumberLabel.Name = "firstnumberLabel";
            this.firstnumberLabel.Size = new System.Drawing.Size(64, 13);
            this.firstnumberLabel.TabIndex = 0;
            this.firstnumberLabel.Text = "First number";
            // 
            // secondnumberLabel
            // 
            this.secondnumberLabel.AutoSize = true;
            this.secondnumberLabel.Location = new System.Drawing.Point(37, 72);
            this.secondnumberLabel.Name = "secondnumberLabel";
            this.secondnumberLabel.Size = new System.Drawing.Size(82, 13);
            this.secondnumberLabel.TabIndex = 1;
            this.secondnumberLabel.Text = "Second number";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(43, 104);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result";
            // 
            // firstnumberTextBox
            // 
            this.firstnumberTextBox.Location = new System.Drawing.Point(124, 38);
            this.firstnumberTextBox.Name = "firstnumberTextBox";
            this.firstnumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnumberTextBox.TabIndex = 3;
            // 
            // secondnumberTextbox
            // 
            this.secondnumberTextbox.Location = new System.Drawing.Point(124, 68);
            this.secondnumberTextbox.Name = "secondnumberTextbox";
            this.secondnumberTextbox.Size = new System.Drawing.Size(100, 20);
            this.secondnumberTextbox.TabIndex = 4;
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(124, 100);
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(100, 20);
            this.resultTextbox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 209);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(108, 209);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "SUBTRACT";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(201, 209);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "MULTIPLY";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(297, 209);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 9;
            this.divideButton.Text = "DIVIDE";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 329);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.secondnumberTextbox);
            this.Controls.Add(this.firstnumberTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondnumberLabel);
            this.Controls.Add(this.firstnumberLabel);
            this.Name = "CalculatorForm";
            this.Text = "CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnumberLabel;
        private System.Windows.Forms.Label secondnumberLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox firstnumberTextBox;
        private System.Windows.Forms.TextBox secondnumberTextbox;
        private System.Windows.Forms.TextBox resultTextbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
    }
}

