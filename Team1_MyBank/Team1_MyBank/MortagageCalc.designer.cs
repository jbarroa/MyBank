namespace MyBank
{
    partial class MortagageCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalLoansLabel = new System.Windows.Forms.Label();
            this.totalMonthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.monthlyPaymentResult = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.amountOfLoanTextBox = new System.Windows.Forms.TextBox();
            this.annualRateOfInterestTextBox = new System.Windows.Forms.TextBox();
            this.numberOfYearsTextBox = new System.Windows.Forms.TextBox();
            this.monthlyPaymentLabel = new System.Windows.Forms.Label();
            this.numberTimesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of Loan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Rate of Interest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total of All Loans";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Monthly Payments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average Monthly Payment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.totalLoansLabel);
            this.groupBox1.Controls.Add(this.totalMonthlyPaymentsLabel);
            this.groupBox1.Controls.Add(this.monthlyPaymentResult);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(4, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // totalLoansLabel
            // 
            this.totalLoansLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLoansLabel.Location = new System.Drawing.Point(220, 38);
            this.totalLoansLabel.Name = "totalLoansLabel";
            this.totalLoansLabel.Size = new System.Drawing.Size(139, 23);
            this.totalLoansLabel.TabIndex = 16;
            // 
            // totalMonthlyPaymentsLabel
            // 
            this.totalMonthlyPaymentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalMonthlyPaymentsLabel.Location = new System.Drawing.Point(220, 79);
            this.totalMonthlyPaymentsLabel.Name = "totalMonthlyPaymentsLabel";
            this.totalMonthlyPaymentsLabel.Size = new System.Drawing.Size(139, 23);
            this.totalMonthlyPaymentsLabel.TabIndex = 17;
            // 
            // monthlyPaymentResult
            // 
            this.monthlyPaymentResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlyPaymentResult.Location = new System.Drawing.Point(220, 152);
            this.monthlyPaymentResult.Name = "monthlyPaymentResult";
            this.monthlyPaymentResult.Size = new System.Drawing.Size(139, 23);
            this.monthlyPaymentResult.TabIndex = 18;
            // 
            // CalculateButton
            // 
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.Location = new System.Drawing.Point(46, 554);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(76, 27);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click_1);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.Location = new System.Drawing.Point(190, 554);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 27);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(337, 554);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 27);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Number of Times";
            // 
            // amountOfLoanTextBox
            // 
            this.amountOfLoanTextBox.Location = new System.Drawing.Point(224, 30);
            this.amountOfLoanTextBox.Name = "amountOfLoanTextBox";
            this.amountOfLoanTextBox.Size = new System.Drawing.Size(139, 22);
            this.amountOfLoanTextBox.TabIndex = 12;
            // 
            // annualRateOfInterestTextBox
            // 
            this.annualRateOfInterestTextBox.Location = new System.Drawing.Point(224, 60);
            this.annualRateOfInterestTextBox.Name = "annualRateOfInterestTextBox";
            this.annualRateOfInterestTextBox.Size = new System.Drawing.Size(139, 22);
            this.annualRateOfInterestTextBox.TabIndex = 13;
            // 
            // numberOfYearsTextBox
            // 
            this.numberOfYearsTextBox.Location = new System.Drawing.Point(224, 91);
            this.numberOfYearsTextBox.Name = "numberOfYearsTextBox";
            this.numberOfYearsTextBox.Size = new System.Drawing.Size(139, 22);
            this.numberOfYearsTextBox.TabIndex = 14;
            // 
            // monthlyPaymentLabel
            // 
            this.monthlyPaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlyPaymentLabel.Location = new System.Drawing.Point(224, 152);
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            this.monthlyPaymentLabel.Size = new System.Drawing.Size(139, 23);
            this.monthlyPaymentLabel.TabIndex = 15;
            // 
            // numberTimesLabel
            // 
            this.numberTimesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberTimesLabel.Location = new System.Drawing.Point(224, 441);
            this.numberTimesLabel.Name = "numberTimesLabel";
            this.numberTimesLabel.Size = new System.Drawing.Size(139, 23);
            this.numberTimesLabel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 675);
            this.Controls.Add(this.numberTimesLabel);
            this.Controls.Add(this.monthlyPaymentLabel);
            this.Controls.Add(this.numberOfYearsTextBox);
            this.Controls.Add(this.annualRateOfInterestTextBox);
            this.Controls.Add(this.amountOfLoanTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mortgage Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalLoansLabel;
        private System.Windows.Forms.Label totalMonthlyPaymentsLabel;
        private System.Windows.Forms.Label monthlyPaymentResult;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amountOfLoanTextBox;
        private System.Windows.Forms.TextBox annualRateOfInterestTextBox;
        private System.Windows.Forms.TextBox numberOfYearsTextBox;
        private System.Windows.Forms.Label monthlyPaymentLabel;
        private System.Windows.Forms.Label numberTimesLabel;
    }
}

