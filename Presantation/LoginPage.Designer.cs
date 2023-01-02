namespace Presantation
{
    partial class LoginPage
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtRetryPassword = new System.Windows.Forms.TextBox();
            this.chkNewUser = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(49, 274);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 23);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Text = "Kullanıcı Adı";
            this.txtUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserName_MouseClick);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(49, 326);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 23);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(34, 442);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(109, 36);
            this.btnGiris.TabIndex = 13;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Enabled = false;
            this.btnKayitOl.Location = new System.Drawing.Point(149, 442);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(109, 36);
            this.btnKayitOl.TabIndex = 13;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtRetryPassword
            // 
            this.txtRetryPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetryPassword.Enabled = false;
            this.txtRetryPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRetryPassword.Location = new System.Drawing.Point(49, 372);
            this.txtRetryPassword.Name = "txtRetryPassword";
            this.txtRetryPassword.Size = new System.Drawing.Size(209, 23);
            this.txtRetryPassword.TabIndex = 12;
            this.txtRetryPassword.Text = "Şifre Tekrarı";
            this.txtRetryPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRetryPassword_MouseClick);
            this.txtRetryPassword.TextChanged += new System.EventHandler(this.txtRetryPassword_TextChanged);
            // 
            // chkNewUser
            // 
            this.chkNewUser.AutoSize = true;
            this.chkNewUser.Location = new System.Drawing.Point(69, 419);
            this.chkNewUser.Name = "chkNewUser";
            this.chkNewUser.Size = new System.Drawing.Size(189, 17);
            this.chkNewUser.TabIndex = 14;
            this.chkNewUser.Text = "Yeni Kullanıcı Oluşturmak İstiyorum";
            this.chkNewUser.UseVisualStyleBackColor = true;
            this.chkNewUser.CheckedChanged += new System.EventHandler(this.chkNewUser_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Plak Kütüphanesi";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNewUser);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtRetryPassword);
            this.Controls.Add(this.txtPassword);
            this.Name = "LoginPage";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPage_FormClosed);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtRetryPassword;
        private System.Windows.Forms.CheckBox chkNewUser;
        private System.Windows.Forms.Label label1;
    }
}

