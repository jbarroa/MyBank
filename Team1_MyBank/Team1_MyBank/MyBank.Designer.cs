namespace MyBank
{
    partial class MyBank
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mortgageCalcButton = new System.Windows.Forms.Button();
            this.ATMButton = new System.Windows.Forms.Button();
            this.loanAppButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mortgageCalcButton);
            this.groupBox1.Controls.Add(this.ATMButton);
            this.groupBox1.Controls.Add(this.loanAppButton);
            this.groupBox1.Controls.Add(this.adminButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank";
            // 
            // mortgageCalcButton
            // 
            this.mortgageCalcButton.Location = new System.Drawing.Point(453, 221);
            this.mortgageCalcButton.Name = "mortgageCalcButton";
            this.mortgageCalcButton.Size = new System.Drawing.Size(185, 64);
            this.mortgageCalcButton.TabIndex = 3;
            this.mortgageCalcButton.Text = "Mortgage Calculator";
            this.mortgageCalcButton.UseVisualStyleBackColor = true;
            this.mortgageCalcButton.Click += new System.EventHandler(this.MortgageCalcButton_Click);
            // 
            // ATMButton
            // 
            this.ATMButton.Location = new System.Drawing.Point(453, 63);
            this.ATMButton.Name = "ATMButton";
            this.ATMButton.Size = new System.Drawing.Size(185, 64);
            this.ATMButton.TabIndex = 2;
            this.ATMButton.Text = "ATM";
            this.ATMButton.UseVisualStyleBackColor = true;
            this.ATMButton.Click += new System.EventHandler(this.ATMButton_Click);
            // 
            // loanAppButton
            // 
            this.loanAppButton.Location = new System.Drawing.Point(105, 221);
            this.loanAppButton.Name = "loanAppButton";
            this.loanAppButton.Size = new System.Drawing.Size(185, 64);
            this.loanAppButton.TabIndex = 1;
            this.loanAppButton.Text = "Loan Application";
            this.loanAppButton.UseVisualStyleBackColor = true;
            this.loanAppButton.Click += new System.EventHandler(this.LoanAppButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(105, 63);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(185, 64);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Administrator";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(291, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(185, 64);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MyBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyBank";
            this.Text = "Team1_MyBank";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mortgageCalcButton;
        private System.Windows.Forms.Button ATMButton;
        private System.Windows.Forms.Button loanAppButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button exitButton;
    }
}

