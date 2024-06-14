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
    public partial class EditProfiles : Form
    {

        // Properti untuk menyimpan nilai yang diperbarui dari form EditProfiles
        public string UpdatedUserName { get; private set; }
        public string UpdatedEmail { get; private set; }
        public string UpdatedPhone { get; private set; }

        // Konstruktor untuk form EditProfiles, menerima objek CurrentUser sebagai parameter
        public EditProfiles(CurrentUser currentUser)
        {
            InitializeComponent();

            // Mengisi nilai teks box dengan informasi pengguna saat ini
            textBoxUsername.Text = currentUser.GetCurrentUserName();
            textBoxEmail.Text = currentUser.getCurrentEmailUser();
            textBoxPhone.Text = currentUser.getCurrentPhoneUser();
        }

        // Handler event buttonSave_Click digunakan untuk menyimpan perubahan
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validasi input sebelum menyimpan
            if (!ValidateInput())
            {
                return; // Keluar dari metode jika validasi gagal
            }

            // Menyimpan data yang diperbarui ke properti-properti
            UpdatedUserName = textBoxUsername.Text;
            UpdatedEmail = textBoxEmail.Text;
            UpdatedPhone = textBoxPhone.Text;

            // Mengatur DialogResult dan menutup form
            DialogResult = DialogResult.OK;
            Close();
        }

        // Metode untuk validasi input sebelum penyimpanan
        private bool ValidateInput()
        {
            // Memeriksa apakah ada field yang kosong
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Semua field harus diisi.");
                return false;
            }

            // Memeriksa format email (minimal harus mengandung '@')
            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Format email tidak valid. Harus mengandung '@'.");
                return false;
            }

            // Memeriksa format nomor telepon (harus berupa angka dan tidak lebih dari 13 digit)
            if (!long.TryParse(textBoxPhone.Text, out long phoneNumber) || textBoxPhone.Text.Length > 13)
            {
                MessageBox.Show("Format nomor telepon tidak valid. Harap masukkan angka yang benar dan tidak lebih dari 13 digit.");
                return false;
            }

            return true;
        }
    }
}
