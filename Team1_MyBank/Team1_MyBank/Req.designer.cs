namespace MyBank
{
    partial class Req
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
            this.passTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.Label();
            this.nothing = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(119, 76);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(100, 20);
            this.passTxt.TabIndex = 10;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(119, 44);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 20);
            this.userTxt.TabIndex = 9;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(57, 44);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(60, 13);
            this.no.TabIndex = 7;
            this.no.Text = "UserName:";
            // 
            // nothing
            // 
            this.nothing.AutoSize = true;
            this.nothing.Location = new System.Drawing.Point(57, 79);
            this.nothing.Name = "nothing";
            this.nothing.Size = new System.Drawing.Size(56, 13);
            this.nothing.TabIndex = 8;
            this.nothing.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 139);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.no);
            this.Controls.Add(this.nothing);
            this.Controls.Add(this.button1);
            this.Name = "Req";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReqForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label nothing;
        private System.Windows.Forms.Button button1;
    }
}