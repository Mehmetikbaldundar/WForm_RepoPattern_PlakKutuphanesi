using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presantation
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        MyDbContext db;
        Albumler albumler = new Albumler();
        private void LoginPage_Load(object sender, EventArgs e)
        {
            db = new MyDbContext();
            txtPassword.UseSystemPasswordChar = false;

        }

        public static int id;
        public static string userName;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var sorgulama = db.Users.Where(x => x.UserName == txtUserName.Text).FirstOrDefault();
            if (sorgulama != null)
            {
                userName = sorgulama.UserName;
                id = sorgulama.UserID;
                GirisYapKontrol();
            }
            else
            {
                MessageBox.Show("Lütfen GEÇERLİ Kullanıcı Adı ve Şifre Giriniz.");
            }

        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtRetryPassword_TextChanged(object sender, EventArgs e)
        {
            txtRetryPassword.UseSystemPasswordChar = true;
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtRetryPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtRetryPassword.Clear();
        }

        private void chkNewUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewUser.Checked)
            {
                txtRetryPassword.Enabled = true;
                btnKayitOl.Enabled = true;
            }
            else
            {
                txtRetryPassword.Enabled = false;
                btnKayitOl.Enabled = false;
            }
        }
        private void GirisYapKontrol()
        {
            var userNameControl = db.Users.Where(x => x.UserName == txtUserName.Text).FirstOrDefault();
            if (userNameControl != null)
            {
                if (userNameControl.Password == PasswordWithSha256(txtPassword.Text))
                {
                    MessageBox.Show("Giriş başarılı");
                    albumler = new Albumler();
                    albumler.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre ya da Email hatalı!\n"
                        + "Lütfen tekrar deneyiniz.");
                }
            }
            else
                MessageBox.Show("Kayıtlı kullanıcı bulunamadı");
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOlKontrol();
        }

        private void KayitOlKontrol()
        {
            if (txtPassword.Text != "" && txtRetryPassword.Text != "")
            {
                if (GenelKontrol() == true)
                {


                    if (UserNameUsage(txtUserName.Text) == false)
                    {

                        User NewUser = new User()
                        {
                            UserName = txtUserName.Text,
                            Password = PasswordWithSha256(txtPassword.Text),
                        };
                        db.Users.Add(NewUser);
                        db.SaveChanges();

                        MessageBox.Show("Üyelik Başarılı");
                    }
                    else
                        MessageBox.Show("Sistemde bu email ile kayıt vardır. Lütfen başka bir email giriniz.");


                }
                else
                {
                    if (UserNameCheck(txtUserName.Text) == false)
                        MessageBox.Show("Kullanıcı adı boş bırakılamaz.");

                    if (PasswordRules(txtPassword.Text) == false)
                        MessageBox.Show("Girdiğiniz şifre doğru biçimde değil.");

                    if (PasswordCheck(txtPassword.Text, txtRetryPassword.Text) == false)
                        MessageBox.Show("Girdiğiniz şifreler aynı değil.");
                }
            }

            else if (txtUserName.Text == "" && txtPassword.Text == "" && txtRetryPassword.Text == "")
            {

                if (UserNameCheck(txtUserName.Text) == false)
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz.");

                if (PasswordCheck(txtPassword.Text, txtRetryPassword.Text) == false)
                    MessageBox.Show("Şifre boş bırakılamaz.");


            }

        }
        private bool UserNameCheck(string userName)
        {
            if (userName == null || userName == "")
                return false;
            else
                return true;
        }
        private bool PasswordCheck(string password, string retryPassword)
        {
            if (password != retryPassword)
                return false;

            else
                return true;
        }
        public bool PasswordRules(string password)
        {
            int totalCharacter = 0, totalLowerChar = 0, totalUpperChar = 0, totalSpecialChar = 0;
            foreach (var item in password.ToCharArray())
            {
                if (char.IsUpper(item))
                    totalUpperChar++;
                if (char.IsLower(item))
                    totalLowerChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }
            if (totalCharacter < 8 || totalUpperChar < 2 || totalLowerChar < 3 || totalSpecialChar < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool GenelKontrol()
        {
            if (PasswordRules(txtPassword.Text) && PasswordCheck(txtPassword.Text, txtRetryPassword.Text) && UserNameCheck(txtUserName.Text))
                return true;

            else
                return false;
        }

        public bool UserNameUsage(string userName)
        {
            var userNameControl = db.Users.Where(x => x.UserName == userName).FirstOrDefault();
            if (userNameControl != null)
            {
                return true;
            }
            else return false;
        }

        private string PasswordWithSha256(string text)
        {
            SHA256 sha256Encrypting = new SHA256CryptoServiceProvider();
            byte[] bytes = sha256Encrypting.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
