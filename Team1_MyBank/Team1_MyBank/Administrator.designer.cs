namespace MyBank
{
    partial class Administrator
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
            this.restoreButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.backupButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountsTextBox = new System.Windows.Forms.TextBox();
            this.loansTextBox = new System.Windows.Forms.TextBox();
            this.customersTextBox = new System.Windows.Forms.TextBox();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.loansListBox = new System.Windows.Forms.ListBox();
            this.accountsListBox = new System.Windows.Forms.ListBox();
            this.customersCheckBox = new System.Windows.Forms.CheckBox();
            this.loansCheckBox = new System.Windows.Forms.CheckBox();
            this.accountsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // restoreButton
            // 
            this.restoreButton.AutoSize = true;
            this.restoreButton.Location = new System.Drawing.Point(214, 509);
            this.restoreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(84, 34);
            this.restoreButton.TabIndex = 0;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(420, 509);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 34);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addRecordButton
            // 
            this.addRecordButton.AutoSize = true;
            this.addRecordButton.Location = new System.Drawing.Point(158, 568);
            this.addRecordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(105, 34);
            this.addRecordButton.TabIndex = 2;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.AutoSize = true;
            this.backupButton.Location = new System.Drawing.Point(320, 568);
            this.backupButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(84, 34);
            this.backupButton.TabIndex = 3;
            this.backupButton.Text = "Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(471, 568);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(84, 34);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "To add records to DB enter data into the textboxes below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 682);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Programmed  by Madison Cox Group 1";
            // 
            // accountsTextBox
            // 
            this.accountsTextBox.Location = new System.Drawing.Point(507, 419);
            this.accountsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountsTextBox.Name = "accountsTextBox";
            this.accountsTextBox.Size = new System.Drawing.Size(134, 26);
            this.accountsTextBox.TabIndex = 7;
            // 
            // loansTextBox
            // 
            this.loansTextBox.Location = new System.Drawing.Point(298, 419);
            this.loansTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loansTextBox.Name = "loansTextBox";
            this.loansTextBox.Size = new System.Drawing.Size(134, 26);
            this.loansTextBox.TabIndex = 8;
            // 
            // customersTextBox
            // 
            this.customersTextBox.Location = new System.Drawing.Point(83, 419);
            this.customersTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersTextBox.Name = "customersTextBox";
            this.customersTextBox.Size = new System.Drawing.Size(134, 26);
            this.customersTextBox.TabIndex = 9;
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 20;
            this.customersListBox.Location = new System.Drawing.Point(83, 144);
            this.customersListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(134, 204);
            this.customersListBox.TabIndex = 10;
            // 
            // loansListBox
            // 
            this.loansListBox.FormattingEnabled = true;
            this.loansListBox.ItemHeight = 20;
            this.loansListBox.Location = new System.Drawing.Point(298, 144);
            this.loansListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loansListBox.Name = "loansListBox";
            this.loansListBox.Size = new System.Drawing.Size(134, 204);
            this.loansListBox.TabIndex = 11;
            // 
            // accountsListBox
            // 
            this.accountsListBox.FormattingEnabled = true;
            this.accountsListBox.ItemHeight = 20;
            this.accountsListBox.Location = new System.Drawing.Point(507, 144);
            this.accountsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountsListBox.Name = "accountsListBox";
            this.accountsListBox.Size = new System.Drawing.Size(134, 204);
            this.accountsListBox.TabIndex = 12;
            // 
            // customersCheckBox
            // 
            this.customersCheckBox.AutoSize = true;
            this.customersCheckBox.Location = new System.Drawing.Point(83, 82);
            this.customersCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersCheckBox.Name = "customersCheckBox";
            this.customersCheckBox.Size = new System.Drawing.Size(112, 24);
            this.customersCheckBox.TabIndex = 13;
            this.customersCheckBox.Text = "Customers";
            this.customersCheckBox.UseVisualStyleBackColor = true;
            // 
            // loansCheckBox
            // 
            this.loansCheckBox.AutoSize = true;
            this.loansCheckBox.Location = new System.Drawing.Point(298, 82);
            this.loansCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loansCheckBox.Name = "loansCheckBox";
            this.loansCheckBox.Size = new System.Drawing.Size(79, 24);
            this.loansCheckBox.TabIndex = 14;
            this.loansCheckBox.Text = "Loans";
            this.loansCheckBox.UseVisualStyleBackColor = true;
            // 
            // accountsCheckBox
            // 
            this.accountsCheckBox.AutoSize = true;
            this.accountsCheckBox.Location = new System.Drawing.Point(507, 82);
            this.accountsCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountsCheckBox.Name = "accountsCheckBox";
            this.accountsCheckBox.Size = new System.Drawing.Size(102, 24);
            this.accountsCheckBox.TabIndex = 15;
            this.accountsCheckBox.Text = "Accounts";
            this.accountsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 715);
            this.Controls.Add(this.accountsCheckBox);
            this.Controls.Add(this.loansCheckBox);
            this.Controls.Add(this.customersCheckBox);
            this.Controls.Add(this.accountsListBox);
            this.Controls.Add(this.loansListBox);
            this.Controls.Add(this.customersListBox);
            this.Controls.Add(this.customersTextBox);
            this.Controls.Add(this.loansTextBox);
            this.Controls.Add(this.accountsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.restoreButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountsTextBox;
        private System.Windows.Forms.TextBox loansTextBox;
        private System.Windows.Forms.TextBox customersTextBox;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.ListBox loansListBox;
        private System.Windows.Forms.ListBox accountsListBox;
        private System.Windows.Forms.CheckBox customersCheckBox;
        private System.Windows.Forms.CheckBox loansCheckBox;
        private System.Windows.Forms.CheckBox accountsCheckBox;
    }
}