namespace MyBank
{
    partial class ATM
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
            this.ATMTab = new System.Windows.Forms.TabControl();
            this.depositTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.balSDLabel = new System.Windows.Forms.Label();
            this.amtDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.balCDLabel = new System.Windows.Forms.Label();
            this.amtDLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sDepositRadioButton = new System.Windows.Forms.RadioButton();
            this.cDepositRadioButton = new System.Windows.Forms.RadioButton();
            this.exitDButton = new System.Windows.Forms.Button();
            this.clearDButton = new System.Windows.Forms.Button();
            this.submitDButton = new System.Windows.Forms.Button();
            this.withdrawTabPage = new System.Windows.Forms.TabPage();
            this.balSWLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amtWTextBox = new System.Windows.Forms.TextBox();
            this.balCWLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sWRadioButton = new System.Windows.Forms.RadioButton();
            this.cWRadioButton = new System.Windows.Forms.RadioButton();
            this.exitWButton = new System.Windows.Forms.Button();
            this.clearWButton = new System.Windows.Forms.Button();
            this.submitWButton = new System.Windows.Forms.Button();
            this.fastCashTabPage = new System.Windows.Forms.TabPage();
            this.balSFLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amtFTextBox = new System.Windows.Forms.TextBox();
            this.balCFLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exitFButton = new System.Windows.Forms.Button();
            this.clearFButton = new System.Windows.Forms.Button();
            this.submitFButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sFRadioButton = new System.Windows.Forms.RadioButton();
            this.cFRadioButton = new System.Windows.Forms.RadioButton();
            this.transferTabPage = new System.Windows.Forms.TabPage();
            this.amtTTextBox = new System.Windows.Forms.TextBox();
            this.depBalLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.wthBalLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.exitTButton = new System.Windows.Forms.Button();
            this.clearTButton = new System.Windows.Forms.Button();
            this.submitTButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toSRadioButton = new System.Windows.Forms.RadioButton();
            this.toCRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.frSRadioButton = new System.Windows.Forms.RadioButton();
            this.frCRadioButton = new System.Windows.Forms.RadioButton();
            this.balanceTabPage = new System.Windows.Forms.TabPage();
            this.clearBButton = new System.Windows.Forms.Button();
            this.exitBButton = new System.Windows.Forms.Button();
            this.submitBButton = new System.Windows.Forms.Button();
            this.balDisLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sBRadioButton = new System.Windows.Forms.RadioButton();
            this.cBRadioButton = new System.Windows.Forms.RadioButton();
            this.statementTabPage = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.sMRadioButton = new System.Windows.Forms.RadioButton();
            this.cMRadioButton = new System.Windows.Forms.RadioButton();
            this.exitMButton = new System.Windows.Forms.Button();
            this.clearMButton = new System.Windows.Forms.Button();
            this.submitMButton = new System.Windows.Forms.Button();
            this.statementListBox = new System.Windows.Forms.ListBox();
            this.ATMTab.SuspendLayout();
            this.depositTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.withdrawTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.fastCashTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.transferTabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.balanceTabPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statementTabPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // ATMTab
            // 
            this.ATMTab.AccessibleName = "";
            this.ATMTab.Controls.Add(this.depositTabPage);
            this.ATMTab.Controls.Add(this.withdrawTabPage);
            this.ATMTab.Controls.Add(this.fastCashTabPage);
            this.ATMTab.Controls.Add(this.transferTabPage);
            this.ATMTab.Controls.Add(this.balanceTabPage);
            this.ATMTab.Controls.Add(this.statementTabPage);
            this.ATMTab.Location = new System.Drawing.Point(12, 24);
            this.ATMTab.Name = "ATMTab";
            this.ATMTab.SelectedIndex = 0;
            this.ATMTab.Size = new System.Drawing.Size(876, 680);
            this.ATMTab.TabIndex = 0;
            // 
            // depositTabPage
            // 
            this.depositTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.depositTabPage.Controls.Add(this.label2);
            this.depositTabPage.Controls.Add(this.balSDLabel);
            this.depositTabPage.Controls.Add(this.amtDTextBox);
            this.depositTabPage.Controls.Add(this.label3);
            this.depositTabPage.Controls.Add(this.balCDLabel);
            this.depositTabPage.Controls.Add(this.amtDLabel);
            this.depositTabPage.Controls.Add(this.groupBox1);
            this.depositTabPage.Controls.Add(this.exitDButton);
            this.depositTabPage.Controls.Add(this.clearDButton);
            this.depositTabPage.Controls.Add(this.submitDButton);
            this.depositTabPage.Location = new System.Drawing.Point(4, 29);
            this.depositTabPage.Name = "depositTabPage";
            this.depositTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.depositTabPage.Size = new System.Drawing.Size(868, 647);
            this.depositTabPage.TabIndex = 0;
            this.depositTabPage.Text = "Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Savings Balance";
            // 
            // balSDLabel
            // 
            this.balSDLabel.BackColor = System.Drawing.Color.White;
            this.balSDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balSDLabel.Location = new System.Drawing.Point(476, 335);
            this.balSDLabel.Name = "balSDLabel";
            this.balSDLabel.Size = new System.Drawing.Size(243, 28);
            this.balSDLabel.TabIndex = 8;
            // 
            // amtDTextBox
            // 
            this.amtDTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.amtDTextBox.Location = new System.Drawing.Point(476, 126);
            this.amtDTextBox.Name = "amtDTextBox";
            this.amtDTextBox.Size = new System.Drawing.Size(243, 26);
            this.amtDTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Checking Balance";
            // 
            // balCDLabel
            // 
            this.balCDLabel.BackColor = System.Drawing.Color.White;
            this.balCDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balCDLabel.Location = new System.Drawing.Point(476, 225);
            this.balCDLabel.Name = "balCDLabel";
            this.balCDLabel.Size = new System.Drawing.Size(243, 30);
            this.balCDLabel.TabIndex = 5;
            // 
            // amtDLabel
            // 
            this.amtDLabel.AutoSize = true;
            this.amtDLabel.Location = new System.Drawing.Point(567, 92);
            this.amtDLabel.Name = "amtDLabel";
            this.amtDLabel.Size = new System.Drawing.Size(65, 20);
            this.amtDLabel.TabIndex = 4;
            this.amtDLabel.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sDepositRadioButton);
            this.groupBox1.Controls.Add(this.cDepositRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(65, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit";
            // 
            // sDepositRadioButton
            // 
            this.sDepositRadioButton.AutoSize = true;
            this.sDepositRadioButton.Location = new System.Drawing.Point(70, 128);
            this.sDepositRadioButton.Name = "sDepositRadioButton";
            this.sDepositRadioButton.Size = new System.Drawing.Size(90, 24);
            this.sDepositRadioButton.TabIndex = 1;
            this.sDepositRadioButton.TabStop = true;
            this.sDepositRadioButton.Text = "Savings";
            this.sDepositRadioButton.UseVisualStyleBackColor = true;
            // 
            // cDepositRadioButton
            // 
            this.cDepositRadioButton.AutoSize = true;
            this.cDepositRadioButton.Location = new System.Drawing.Point(70, 66);
            this.cDepositRadioButton.Name = "cDepositRadioButton";
            this.cDepositRadioButton.Size = new System.Drawing.Size(100, 24);
            this.cDepositRadioButton.TabIndex = 0;
            this.cDepositRadioButton.TabStop = true;
            this.cDepositRadioButton.Text = "Checking";
            this.cDepositRadioButton.UseVisualStyleBackColor = true;
            // 
            // exitDButton
            // 
            this.exitDButton.Location = new System.Drawing.Point(625, 509);
            this.exitDButton.Name = "exitDButton";
            this.exitDButton.Size = new System.Drawing.Size(117, 49);
            this.exitDButton.TabIndex = 2;
            this.exitDButton.Text = "Exit";
            this.exitDButton.UseVisualStyleBackColor = true;
            this.exitDButton.Click += new System.EventHandler(this.ExitDButton_Click);
            // 
            // clearDButton
            // 
            this.clearDButton.Location = new System.Drawing.Point(378, 509);
            this.clearDButton.Name = "clearDButton";
            this.clearDButton.Size = new System.Drawing.Size(117, 49);
            this.clearDButton.TabIndex = 1;
            this.clearDButton.Text = "Clear";
            this.clearDButton.UseVisualStyleBackColor = true;
            this.clearDButton.Click += new System.EventHandler(this.ClearDButton_Click);
            // 
            // submitDButton
            // 
            this.submitDButton.Location = new System.Drawing.Point(118, 509);
            this.submitDButton.Name = "submitDButton";
            this.submitDButton.Size = new System.Drawing.Size(117, 49);
            this.submitDButton.TabIndex = 0;
            this.submitDButton.Text = "Submit";
            this.submitDButton.UseVisualStyleBackColor = true;
            this.submitDButton.Click += new System.EventHandler(this.SubmitDButton_Click);
            // 
            // withdrawTabPage
            // 
            this.withdrawTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.withdrawTabPage.Controls.Add(this.balSWLabel);
            this.withdrawTabPage.Controls.Add(this.label1);
            this.withdrawTabPage.Controls.Add(this.amtWTextBox);
            this.withdrawTabPage.Controls.Add(this.balCWLabel);
            this.withdrawTabPage.Controls.Add(this.label5);
            this.withdrawTabPage.Controls.Add(this.label4);
            this.withdrawTabPage.Controls.Add(this.groupBox2);
            this.withdrawTabPage.Controls.Add(this.exitWButton);
            this.withdrawTabPage.Controls.Add(this.clearWButton);
            this.withdrawTabPage.Controls.Add(this.submitWButton);
            this.withdrawTabPage.Location = new System.Drawing.Point(4, 29);
            this.withdrawTabPage.Name = "withdrawTabPage";
            this.withdrawTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.withdrawTabPage.Size = new System.Drawing.Size(868, 647);
            this.withdrawTabPage.TabIndex = 1;
            this.withdrawTabPage.Text = "Withdraw";
            // 
            // balSWLabel
            // 
            this.balSWLabel.BackColor = System.Drawing.Color.White;
            this.balSWLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balSWLabel.Location = new System.Drawing.Point(501, 337);
            this.balSWLabel.Name = "balSWLabel";
            this.balSWLabel.Size = new System.Drawing.Size(247, 23);
            this.balSWLabel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Savings Balance";
            // 
            // amtWTextBox
            // 
            this.amtWTextBox.Location = new System.Drawing.Point(501, 130);
            this.amtWTextBox.Name = "amtWTextBox";
            this.amtWTextBox.Size = new System.Drawing.Size(247, 26);
            this.amtWTextBox.TabIndex = 7;
            // 
            // balCWLabel
            // 
            this.balCWLabel.BackColor = System.Drawing.Color.White;
            this.balCWLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balCWLabel.Location = new System.Drawing.Point(501, 223);
            this.balCWLabel.Name = "balCWLabel";
            this.balCWLabel.Size = new System.Drawing.Size(247, 25);
            this.balCWLabel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Checking Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sWRadioButton);
            this.groupBox2.Controls.Add(this.cWRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(58, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 211);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Withdraw";
            // 
            // sWRadioButton
            // 
            this.sWRadioButton.AutoSize = true;
            this.sWRadioButton.Location = new System.Drawing.Point(64, 135);
            this.sWRadioButton.Name = "sWRadioButton";
            this.sWRadioButton.Size = new System.Drawing.Size(90, 24);
            this.sWRadioButton.TabIndex = 1;
            this.sWRadioButton.TabStop = true;
            this.sWRadioButton.Text = "Savings";
            this.sWRadioButton.UseVisualStyleBackColor = true;
            // 
            // cWRadioButton
            // 
            this.cWRadioButton.AutoSize = true;
            this.cWRadioButton.Location = new System.Drawing.Point(64, 61);
            this.cWRadioButton.Name = "cWRadioButton";
            this.cWRadioButton.Size = new System.Drawing.Size(100, 24);
            this.cWRadioButton.TabIndex = 0;
            this.cWRadioButton.TabStop = true;
            this.cWRadioButton.Text = "Checking";
            this.cWRadioButton.UseVisualStyleBackColor = true;
            // 
            // exitWButton
            // 
            this.exitWButton.Location = new System.Drawing.Point(639, 496);
            this.exitWButton.Name = "exitWButton";
            this.exitWButton.Size = new System.Drawing.Size(109, 45);
            this.exitWButton.TabIndex = 2;
            this.exitWButton.Text = "Exit";
            this.exitWButton.UseVisualStyleBackColor = true;
            this.exitWButton.Click += new System.EventHandler(this.ExitWButton_Click);
            // 
            // clearWButton
            // 
            this.clearWButton.Location = new System.Drawing.Point(381, 496);
            this.clearWButton.Name = "clearWButton";
            this.clearWButton.Size = new System.Drawing.Size(109, 45);
            this.clearWButton.TabIndex = 1;
            this.clearWButton.Text = "Clear";
            this.clearWButton.UseVisualStyleBackColor = true;
            this.clearWButton.Click += new System.EventHandler(this.ClearWButton_Click);
            // 
            // submitWButton
            // 
            this.submitWButton.Location = new System.Drawing.Point(103, 496);
            this.submitWButton.Name = "submitWButton";
            this.submitWButton.Size = new System.Drawing.Size(109, 45);
            this.submitWButton.TabIndex = 0;
            this.submitWButton.Text = "Submit";
            this.submitWButton.UseVisualStyleBackColor = true;
            this.submitWButton.Click += new System.EventHandler(this.SubmitWButton_Click);
            // 
            // fastCashTabPage
            // 
            this.fastCashTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fastCashTabPage.Controls.Add(this.balSFLabel);
            this.fastCashTabPage.Controls.Add(this.label6);
            this.fastCashTabPage.Controls.Add(this.amtFTextBox);
            this.fastCashTabPage.Controls.Add(this.balCFLabel);
            this.fastCashTabPage.Controls.Add(this.label8);
            this.fastCashTabPage.Controls.Add(this.label7);
            this.fastCashTabPage.Controls.Add(this.exitFButton);
            this.fastCashTabPage.Controls.Add(this.clearFButton);
            this.fastCashTabPage.Controls.Add(this.submitFButton);
            this.fastCashTabPage.Controls.Add(this.groupBox3);
            this.fastCashTabPage.Location = new System.Drawing.Point(4, 29);
            this.fastCashTabPage.Name = "fastCashTabPage";
            this.fastCashTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fastCashTabPage.Size = new System.Drawing.Size(868, 647);
            this.fastCashTabPage.TabIndex = 2;
            this.fastCashTabPage.Text = "Fast Cash";
            // 
            // balSFLabel
            // 
            this.balSFLabel.BackColor = System.Drawing.Color.White;
            this.balSFLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balSFLabel.Location = new System.Drawing.Point(459, 368);
            this.balSFLabel.Name = "balSFLabel";
            this.balSFLabel.Size = new System.Drawing.Size(271, 29);
            this.balSFLabel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Savings Balance";
            // 
            // amtFTextBox
            // 
            this.amtFTextBox.Location = new System.Drawing.Point(459, 187);
            this.amtFTextBox.Name = "amtFTextBox";
            this.amtFTextBox.Size = new System.Drawing.Size(271, 26);
            this.amtFTextBox.TabIndex = 7;
            // 
            // balCFLabel
            // 
            this.balCFLabel.BackColor = System.Drawing.Color.White;
            this.balCFLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balCFLabel.Location = new System.Drawing.Point(459, 273);
            this.balCFLabel.Name = "balCFLabel";
            this.balCFLabel.Size = new System.Drawing.Size(271, 26);
            this.balCFLabel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Checking Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amount";
            // 
            // exitFButton
            // 
            this.exitFButton.Location = new System.Drawing.Point(621, 511);
            this.exitFButton.Name = "exitFButton";
            this.exitFButton.Size = new System.Drawing.Size(109, 47);
            this.exitFButton.TabIndex = 3;
            this.exitFButton.Text = "Exit";
            this.exitFButton.UseVisualStyleBackColor = true;
            this.exitFButton.Click += new System.EventHandler(this.ExitFButton_Click);
            // 
            // clearFButton
            // 
            this.clearFButton.Location = new System.Drawing.Point(385, 511);
            this.clearFButton.Name = "clearFButton";
            this.clearFButton.Size = new System.Drawing.Size(109, 47);
            this.clearFButton.TabIndex = 2;
            this.clearFButton.Text = "Clear";
            this.clearFButton.UseVisualStyleBackColor = true;
            this.clearFButton.Click += new System.EventHandler(this.ClearFButton_Click);
            // 
            // submitFButton
            // 
            this.submitFButton.Location = new System.Drawing.Point(143, 511);
            this.submitFButton.Name = "submitFButton";
            this.submitFButton.Size = new System.Drawing.Size(109, 47);
            this.submitFButton.TabIndex = 1;
            this.submitFButton.Text = "Submit";
            this.submitFButton.UseVisualStyleBackColor = true;
            this.submitFButton.Click += new System.EventHandler(this.SubmitFButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sFRadioButton);
            this.groupBox3.Controls.Add(this.cFRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(94, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 210);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fast Cash";
            // 
            // sFRadioButton
            // 
            this.sFRadioButton.AutoSize = true;
            this.sFRadioButton.Location = new System.Drawing.Point(49, 134);
            this.sFRadioButton.Name = "sFRadioButton";
            this.sFRadioButton.Size = new System.Drawing.Size(90, 24);
            this.sFRadioButton.TabIndex = 1;
            this.sFRadioButton.TabStop = true;
            this.sFRadioButton.Text = "Savings";
            this.sFRadioButton.UseVisualStyleBackColor = true;
            // 
            // cFRadioButton
            // 
            this.cFRadioButton.AutoSize = true;
            this.cFRadioButton.Location = new System.Drawing.Point(49, 64);
            this.cFRadioButton.Name = "cFRadioButton";
            this.cFRadioButton.Size = new System.Drawing.Size(100, 24);
            this.cFRadioButton.TabIndex = 0;
            this.cFRadioButton.TabStop = true;
            this.cFRadioButton.Text = "Checking";
            this.cFRadioButton.UseVisualStyleBackColor = true;
            // 
            // transferTabPage
            // 
            this.transferTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.transferTabPage.Controls.Add(this.amtTTextBox);
            this.transferTabPage.Controls.Add(this.depBalLabel);
            this.transferTabPage.Controls.Add(this.label13);
            this.transferTabPage.Controls.Add(this.wthBalLabel);
            this.transferTabPage.Controls.Add(this.label11);
            this.transferTabPage.Controls.Add(this.label10);
            this.transferTabPage.Controls.Add(this.exitTButton);
            this.transferTabPage.Controls.Add(this.clearTButton);
            this.transferTabPage.Controls.Add(this.submitTButton);
            this.transferTabPage.Controls.Add(this.groupBox5);
            this.transferTabPage.Controls.Add(this.groupBox4);
            this.transferTabPage.Location = new System.Drawing.Point(4, 29);
            this.transferTabPage.Name = "transferTabPage";
            this.transferTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.transferTabPage.Size = new System.Drawing.Size(868, 647);
            this.transferTabPage.TabIndex = 3;
            this.transferTabPage.Text = "Transfer";
            // 
            // amtTTextBox
            // 
            this.amtTTextBox.Location = new System.Drawing.Point(509, 121);
            this.amtTTextBox.Name = "amtTTextBox";
            this.amtTTextBox.Size = new System.Drawing.Size(274, 26);
            this.amtTTextBox.TabIndex = 10;
            // 
            // depBalLabel
            // 
            this.depBalLabel.BackColor = System.Drawing.Color.White;
            this.depBalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depBalLabel.Location = new System.Drawing.Point(509, 446);
            this.depBalLabel.Name = "depBalLabel";
            this.depBalLabel.Size = new System.Drawing.Size(274, 25);
            this.depBalLabel.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Account Deposited Balance";
            // 
            // wthBalLabel
            // 
            this.wthBalLabel.BackColor = System.Drawing.Color.White;
            this.wthBalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wthBalLabel.Location = new System.Drawing.Point(509, 341);
            this.wthBalLabel.Name = "wthBalLabel";
            this.wthBalLabel.Size = new System.Drawing.Size(274, 25);
            this.wthBalLabel.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Account Withdrawn Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Amount";
            // 
            // exitTButton
            // 
            this.exitTButton.Location = new System.Drawing.Point(684, 535);
            this.exitTButton.Name = "exitTButton";
            this.exitTButton.Size = new System.Drawing.Size(99, 37);
            this.exitTButton.TabIndex = 4;
            this.exitTButton.Text = "Exit";
            this.exitTButton.UseVisualStyleBackColor = true;
            this.exitTButton.Click += new System.EventHandler(this.ExitTButton_Click);
            // 
            // clearTButton
            // 
            this.clearTButton.Location = new System.Drawing.Point(402, 535);
            this.clearTButton.Name = "clearTButton";
            this.clearTButton.Size = new System.Drawing.Size(100, 37);
            this.clearTButton.TabIndex = 3;
            this.clearTButton.Text = "Clear";
            this.clearTButton.UseVisualStyleBackColor = true;
            this.clearTButton.Click += new System.EventHandler(this.ClearTButton_Click);
            // 
            // submitTButton
            // 
            this.submitTButton.Location = new System.Drawing.Point(124, 534);
            this.submitTButton.Name = "submitTButton";
            this.submitTButton.Size = new System.Drawing.Size(99, 39);
            this.submitTButton.TabIndex = 2;
            this.submitTButton.Text = "Submit";
            this.submitTButton.UseVisualStyleBackColor = true;
            this.submitTButton.Click += new System.EventHandler(this.SubmitTButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.toSRadioButton);
            this.groupBox5.Controls.Add(this.toCRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(87, 301);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(238, 170);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transfer To";
            // 
            // toSRadioButton
            // 
            this.toSRadioButton.AutoSize = true;
            this.toSRadioButton.Location = new System.Drawing.Point(37, 108);
            this.toSRadioButton.Name = "toSRadioButton";
            this.toSRadioButton.Size = new System.Drawing.Size(90, 24);
            this.toSRadioButton.TabIndex = 1;
            this.toSRadioButton.TabStop = true;
            this.toSRadioButton.Text = "Savings";
            this.toSRadioButton.UseVisualStyleBackColor = true;
            // 
            // toCRadioButton
            // 
            this.toCRadioButton.AutoSize = true;
            this.toCRadioButton.Location = new System.Drawing.Point(37, 60);
            this.toCRadioButton.Name = "toCRadioButton";
            this.toCRadioButton.Size = new System.Drawing.Size(100, 24);
            this.toCRadioButton.TabIndex = 0;
            this.toCRadioButton.TabStop = true;
            this.toCRadioButton.Text = "Checking";
            this.toCRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.frSRadioButton);
            this.groupBox4.Controls.Add(this.frCRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(87, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 170);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transfer From";
            // 
            // frSRadioButton
            // 
            this.frSRadioButton.AutoSize = true;
            this.frSRadioButton.Location = new System.Drawing.Point(37, 103);
            this.frSRadioButton.Name = "frSRadioButton";
            this.frSRadioButton.Size = new System.Drawing.Size(90, 24);
            this.frSRadioButton.TabIndex = 1;
            this.frSRadioButton.TabStop = true;
            this.frSRadioButton.Text = "Savings";
            this.frSRadioButton.UseVisualStyleBackColor = true;
            // 
            // frCRadioButton
            // 
            this.frCRadioButton.AutoSize = true;
            this.frCRadioButton.Location = new System.Drawing.Point(37, 54);
            this.frCRadioButton.Name = "frCRadioButton";
            this.frCRadioButton.Size = new System.Drawing.Size(100, 24);
            this.frCRadioButton.TabIndex = 0;
            this.frCRadioButton.TabStop = true;
            this.frCRadioButton.Text = "Checking";
            this.frCRadioButton.UseVisualStyleBackColor = true;
            // 
            // balanceTabPage
            // 
            this.balanceTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.balanceTabPage.Controls.Add(this.clearBButton);
            this.balanceTabPage.Controls.Add(this.exitBButton);
            this.balanceTabPage.Controls.Add(this.submitBButton);
            this.balanceTabPage.Controls.Add(this.balDisLabel);
            this.balanceTabPage.Controls.Add(this.label15);
            this.balanceTabPage.Controls.Add(this.groupBox6);
            this.balanceTabPage.Location = new System.Drawing.Point(4, 29);
            this.balanceTabPage.Name = "balanceTabPage";
            this.balanceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.balanceTabPage.Size = new System.Drawing.Size(868, 647);
            this.balanceTabPage.TabIndex = 4;
            this.balanceTabPage.Text = "Balance Display";
            // 
            // clearBButton
            // 
            this.clearBButton.Location = new System.Drawing.Point(402, 485);
            this.clearBButton.Name = "clearBButton";
            this.clearBButton.Size = new System.Drawing.Size(119, 45);
            this.clearBButton.TabIndex = 5;
            this.clearBButton.Text = "Clear";
            this.clearBButton.UseVisualStyleBackColor = true;
            this.clearBButton.Click += new System.EventHandler(this.ClearBButton_Click);
            // 
            // exitBButton
            // 
            this.exitBButton.Location = new System.Drawing.Point(678, 485);
            this.exitBButton.Name = "exitBButton";
            this.exitBButton.Size = new System.Drawing.Size(119, 45);
            this.exitBButton.TabIndex = 4;
            this.exitBButton.Text = "Exit";
            this.exitBButton.UseVisualStyleBackColor = true;
            this.exitBButton.Click += new System.EventHandler(this.ExitBButton_Click);
            // 
            // submitBButton
            // 
            this.submitBButton.Location = new System.Drawing.Point(97, 485);
            this.submitBButton.Name = "submitBButton";
            this.submitBButton.Size = new System.Drawing.Size(119, 45);
            this.submitBButton.TabIndex = 3;
            this.submitBButton.Text = "Submit";
            this.submitBButton.UseVisualStyleBackColor = true;
            this.submitBButton.Click += new System.EventHandler(this.SubmitBButton_Click);
            // 
            // balDisLabel
            // 
            this.balDisLabel.BackColor = System.Drawing.Color.White;
            this.balDisLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balDisLabel.Location = new System.Drawing.Point(465, 264);
            this.balDisLabel.Name = "balDisLabel";
            this.balDisLabel.Size = new System.Drawing.Size(264, 45);
            this.balDisLabel.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(556, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Balance";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sBRadioButton);
            this.groupBox6.Controls.Add(this.cBRadioButton);
            this.groupBox6.Location = new System.Drawing.Point(97, 164);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(229, 193);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Balance Display";
            // 
            // sBRadioButton
            // 
            this.sBRadioButton.AutoSize = true;
            this.sBRadioButton.Location = new System.Drawing.Point(59, 121);
            this.sBRadioButton.Name = "sBRadioButton";
            this.sBRadioButton.Size = new System.Drawing.Size(90, 24);
            this.sBRadioButton.TabIndex = 1;
            this.sBRadioButton.TabStop = true;
            this.sBRadioButton.Text = "Savings";
            this.sBRadioButton.UseVisualStyleBackColor = true;
            // 
            // cBRadioButton
            // 
            this.cBRadioButton.AutoSize = true;
            this.cBRadioButton.Location = new System.Drawing.Point(59, 60);
            this.cBRadioButton.Name = "cBRadioButton";
            this.cBRadioButton.Size = new System.Drawing.Size(100, 24);
            this.cBRadioButton.TabIndex = 0;
            this.cBRadioButton.TabStop = true;
            this.cBRadioButton.Text = "Checking";
            this.cBRadioButton.UseVisualStyleBackColor = true;
            // 
            // statementTabPage
            // 
            this.statementTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statementTabPage.Controls.Add(this.statementListBox);
            this.statementTabPage.Controls.Add(this.label17);
            this.statementTabPage.Controls.Add(this.groupBox7);
            this.statementTabPage.Controls.Add(this.exitMButton);
            this.statementTabPage.Controls.Add(this.clearMButton);
            this.statementTabPage.Controls.Add(this.submitMButton);
            this.statementTabPage.Location = new System.Drawing.Point(4, 29);
            this.statementTabPage.Name = "statementTabPage";
            this.statementTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statementTabPage.Size = new System.Drawing.Size(868, 647);
            this.statementTabPage.TabIndex = 5;
            this.statementTabPage.Text = "Mini Statement";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(558, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Statement";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.sMRadioButton);
            this.groupBox7.Controls.Add(this.cMRadioButton);
            this.groupBox7.Location = new System.Drawing.Point(120, 219);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(236, 175);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Mini Statement";
            // 
            // sMRadioButton
            // 
            this.sMRadioButton.AutoSize = true;
            this.sMRadioButton.Location = new System.Drawing.Point(48, 118);
            this.sMRadioButton.Name = "sMRadioButton";
            this.sMRadioButton.Size = new System.Drawing.Size(90, 24);
            this.sMRadioButton.TabIndex = 1;
            this.sMRadioButton.TabStop = true;
            this.sMRadioButton.Text = "Savings";
            this.sMRadioButton.UseVisualStyleBackColor = true;
            // 
            // cMRadioButton
            // 
            this.cMRadioButton.AutoSize = true;
            this.cMRadioButton.Location = new System.Drawing.Point(49, 63);
            this.cMRadioButton.Name = "cMRadioButton";
            this.cMRadioButton.Size = new System.Drawing.Size(100, 24);
            this.cMRadioButton.TabIndex = 0;
            this.cMRadioButton.TabStop = true;
            this.cMRadioButton.Text = "Checking";
            this.cMRadioButton.UseVisualStyleBackColor = true;
            // 
            // exitMButton
            // 
            this.exitMButton.Location = new System.Drawing.Point(655, 549);
            this.exitMButton.Name = "exitMButton";
            this.exitMButton.Size = new System.Drawing.Size(122, 46);
            this.exitMButton.TabIndex = 2;
            this.exitMButton.Text = "Exit";
            this.exitMButton.UseVisualStyleBackColor = true;
            this.exitMButton.Click += new System.EventHandler(this.ExitMButton_Click);
            // 
            // clearMButton
            // 
            this.clearMButton.Location = new System.Drawing.Point(397, 549);
            this.clearMButton.Name = "clearMButton";
            this.clearMButton.Size = new System.Drawing.Size(121, 46);
            this.clearMButton.TabIndex = 1;
            this.clearMButton.Text = "Clear";
            this.clearMButton.UseVisualStyleBackColor = true;
            this.clearMButton.Click += new System.EventHandler(this.ClearMButton_Click);
            // 
            // submitMButton
            // 
            this.submitMButton.Location = new System.Drawing.Point(120, 549);
            this.submitMButton.Name = "submitMButton";
            this.submitMButton.Size = new System.Drawing.Size(122, 46);
            this.submitMButton.TabIndex = 0;
            this.submitMButton.Text = "Submit";
            this.submitMButton.UseVisualStyleBackColor = true;
            this.submitMButton.Click += new System.EventHandler(this.SubmitMButton_Click);
            // 
            // statementListBox
            // 
            this.statementListBox.FormattingEnabled = true;
            this.statementListBox.ItemHeight = 20;
            this.statementListBox.Location = new System.Drawing.Point(440, 146);
            this.statementListBox.Name = "statementListBox";
            this.statementListBox.Size = new System.Drawing.Size(337, 304);
            this.statementListBox.TabIndex = 5;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 725);
            this.Controls.Add(this.ATMTab);
            this.Name = "ATM";
            this.Text = "ATM";
            this.ATMTab.ResumeLayout(false);
            this.depositTabPage.ResumeLayout(false);
            this.depositTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.withdrawTabPage.ResumeLayout(false);
            this.withdrawTabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.fastCashTabPage.ResumeLayout(false);
            this.fastCashTabPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.transferTabPage.ResumeLayout(false);
            this.transferTabPage.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.balanceTabPage.ResumeLayout(false);
            this.balanceTabPage.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.statementTabPage.ResumeLayout(false);
            this.statementTabPage.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ATMTab;
        private System.Windows.Forms.TabPage depositTabPage;
        private System.Windows.Forms.TabPage withdrawTabPage;
        private System.Windows.Forms.TextBox amtDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label balCDLabel;
        private System.Windows.Forms.Label amtDLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sDepositRadioButton;
        private System.Windows.Forms.RadioButton cDepositRadioButton;
        private System.Windows.Forms.Button exitDButton;
        private System.Windows.Forms.Button clearDButton;
        private System.Windows.Forms.Button submitDButton;
        private System.Windows.Forms.TextBox amtWTextBox;
        private System.Windows.Forms.Label balCWLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sWRadioButton;
        private System.Windows.Forms.RadioButton cWRadioButton;
        private System.Windows.Forms.Button exitWButton;
        private System.Windows.Forms.Button clearWButton;
        private System.Windows.Forms.Button submitWButton;
        private System.Windows.Forms.TabPage fastCashTabPage;
        private System.Windows.Forms.TextBox amtFTextBox;
        private System.Windows.Forms.Label balCFLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exitFButton;
        private System.Windows.Forms.Button clearFButton;
        private System.Windows.Forms.Button submitFButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton sFRadioButton;
        private System.Windows.Forms.RadioButton cFRadioButton;
        private System.Windows.Forms.TabPage transferTabPage;
        private System.Windows.Forms.TextBox amtTTextBox;
        private System.Windows.Forms.Label depBalLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label wthBalLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exitTButton;
        private System.Windows.Forms.Button clearTButton;
        private System.Windows.Forms.Button submitTButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage balanceTabPage;
        private System.Windows.Forms.Button clearBButton;
        private System.Windows.Forms.Button exitBButton;
        private System.Windows.Forms.Button submitBButton;
        private System.Windows.Forms.Label balDisLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage statementTabPage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button exitMButton;
        private System.Windows.Forms.Button clearMButton;
        private System.Windows.Forms.Button submitMButton;
        private System.Windows.Forms.RadioButton toSRadioButton;
        private System.Windows.Forms.RadioButton toCRadioButton;
        private System.Windows.Forms.RadioButton frSRadioButton;
        private System.Windows.Forms.RadioButton frCRadioButton;
        private System.Windows.Forms.RadioButton sBRadioButton;
        private System.Windows.Forms.RadioButton cBRadioButton;
        private System.Windows.Forms.RadioButton sMRadioButton;
        private System.Windows.Forms.RadioButton cMRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label balSDLabel;
        private System.Windows.Forms.Label balSWLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label balSFLabel;
        private System.Windows.Forms.ListBox statementListBox;
    }
}

