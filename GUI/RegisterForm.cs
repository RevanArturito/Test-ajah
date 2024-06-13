using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Authentication.Controllers;
using System.Diagnostics;

namespace GUI
{
    public partial class RegisterForm : Form
    {
        Thread th;
        public RegisterForm()
        {
            InitializeComponent();
        }

        public void openLohjin(object obj)
        {
            Application.Run(new Lohjin());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IAccountService accountService = new AccountService();

            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            string email = EmailInput.Text;
            string phone = PhoneInput.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("input tidak boleh kosong !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                if (!username.Contains("@gmail.com"))
                {
                    MessageBox.Show("Pastikan Email valid");
                } else
                {
                    AuthController auth = new AuthController(accountService);
                    auth.Post(new Account(username, password, email, phone));
                    MessageBox.Show("Akun berhasil terdaftar");
                    this.Close();
                    th = new Thread(openLohjin);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                
            }
        }
        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLohjin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
