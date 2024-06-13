using Authentication.Controllers;
using GUI.Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{

    public partial class Lohjin : Form
    {
        Thread th;
        public Lohjin()
        {
            InitializeComponent();
            List<Account> accounts = new List<Account>();
        }

        public void openRegister(object obj)
        {
            Application.Run(new RegisterForm());
        }

        public void openHomePage(object obj)
        {
            Application.Run(new HomePage());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openRegister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            CheckingFunc checkingFunc = new CheckingFunc();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("input tidak boleh kosong !","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                if (checkingFunc.LoginCheck(username, password))
                {
                    
                    MessageBox.Show("Login Berhasil");
                    this.Close();
                    th = new Thread(openHomePage);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Login Gagal");
                }
            }
        }
    }
}
