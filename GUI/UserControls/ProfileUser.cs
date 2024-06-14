using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ProfileUser : UserControl
    {
        public ProfileUser()
        {
            CurrentUser currentUser = new CurrentUser();    
            InitializeComponent();
            DisplayUsername.Text = currentUser.GetCurrentUserName();
            DisplayEmail.Text = currentUser.getCurrentEmailUser();
            DisplayPhone.Text = currentUser.getCurrentPhoneUser();
            label1.Text = $"Hai, {currentUser.GetCurrentUserName()}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfileUser_Load(object sender, EventArgs e)
        {

        }

        private void DisplayPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TombolKembali_Click(object sender, EventArgs e)
        {

        }
    }
}
