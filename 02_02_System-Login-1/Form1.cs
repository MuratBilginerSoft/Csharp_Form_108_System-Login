using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02_02_System_Login_1
{
    public partial class Form1 : Form
    {
        #region Parameters

        string UserName = "MuratBilginer";
        string Password = "123456";

        string UserNameT, PasswordT;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            UserNameT = TextUserName.Text;
            PasswordT = TextPassword.Text;

            if (UserNameT == UserName && PasswordT == Password)
            {
                MessageBox.Show("Başarılı Giriş Yapıldı");
            }

            else
            {
                MessageBox.Show("Başarısız Şifre veya Kullanıcı Adı");
            }
        }
    }
}
