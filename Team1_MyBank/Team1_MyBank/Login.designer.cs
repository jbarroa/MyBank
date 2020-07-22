namespace MyBank
{
    partial class Login
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
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.nothing = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(106, 182);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 35);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(269, 182);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 35);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // nothing
            // 
            this.nothing.AutoSize = true;
            this.nothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothing.Location = new System.Drawing.Point(107, 114);
            this.nothing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nothing.Name = "nothing";
            this.nothing.Size = new System.Drawing.Size(91, 20);
            this.nothing.TabIndex = 2;
            this.nothing.Text = "Password:";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(102, 62);
            this.no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(96, 20);
            this.no.TabIndex = 2;
            this.no.Text = "Username:";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(206, 62);
            this.userTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(148, 26);
            this.userTxt.TabIndex = 3;
            this.userTxt.TextChanged += new System.EventHandler(this.UserTxt_TextChanged);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(206, 111);
            this.passTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(148, 26);
            this.passTxt.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(190, 248);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 311);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.no);
            this.Controls.Add(this.nothing);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label nothing;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button exitButton;
    }
}

