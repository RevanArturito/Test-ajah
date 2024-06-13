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
    public partial class HomePage : Form
    {
        Thread th;
        public HomePage()
        {
            InitializeComponent();
        }
        public void openLogin(object obj)
        {
            CurrentUser currentUser = new CurrentUser();
            Application.Run(new Lohjin());

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TambahButton_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            addUserControl(ap);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            ListProduct lp = new ListProduct();
            addUserControl(lp);
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Profile pr = new Profile();
            addUserControl(pr);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
