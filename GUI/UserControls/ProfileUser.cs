using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GUI.UserControls
{
    public partial class ProfileUser : UserControl
    {
        public ProfileUser()
        {
            // Inisialisasi objek CurrentUser untuk mendapatkan informasi pengguna saat ini
            CurrentUser currentUser = new CurrentUser();
            InitializeComponent();

            // Menampilkan nama pengguna, email, dan nomor telepon pengguna saat ini
            DisplayUsername.Text = currentUser.GetCurrentUserName();
            DisplayEmail.Text = currentUser.getCurrentEmailUser();
            DisplayPhone.Text = currentUser.getCurrentPhoneUser();

            // Mengatur label1 untuk menyapa pengguna dengan nama mereka
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

        // Handler event button1_Click digunakan untuk membuka form EditProfiles
        private void button1_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form EditProfiles, dengan mengirim informasi pengguna saat ini
            CurrentUser currentUser = new CurrentUser();
            EditProfiles editProfileForm = new EditProfiles(currentUser);

            // Menampilkan form EditProfiles sebagai dialog
            if (editProfileForm.ShowDialog() == DialogResult.OK)
            {
                // Memperbarui informasi pengguna yang ditampilkan dengan nilai yang diperbarui dari EditProfiles
                DisplayUsername.Text = editProfileForm.UpdatedUserName;
                DisplayEmail.Text = editProfileForm.UpdatedEmail;
                DisplayPhone.Text = editProfileForm.UpdatedPhone;
                label1.Text = $"Hai, {editProfileForm.UpdatedUserName}";
            }
        }
    }
}
