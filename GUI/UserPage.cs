using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UserPage : Form
    {
        Thread th; 
        public UserPage()
        {
            InitializeComponent();
        }

        public void openLogin(object obj)
        {
            CurrentUser currentUser = new CurrentUser();
            Application.Run(new Lohjin());

        }

        private void TambahButton_Click(object sender, EventArgs e)
        {
            BeliProduk pk = new BeliProduk();
            addUserControl(pk);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer2.Controls.Clear();
            PanelContainer2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            ProfileUser pe = new ProfileUser();
            addUserControl(pe);
        }

        private void UserPage_Load(object sender, EventArgs e)
        {

        }

        private void Beli_Click(object sender, EventArgs e)
        {
            BeliProduk ap = new BeliProduk();
            addUserControl(ap);
        }

        private void PanelContainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Konfirmasi Logout ?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (r == DialogResult.OK)
            {
                this.Close();
                th = new Thread(openLogin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
    }
}
