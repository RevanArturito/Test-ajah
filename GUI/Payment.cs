using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Payment : Form
    {
        private IState CurrentState;
        private MBankingState StateMBanking;
        private DebitState StateDebit;
        private EWalletState StateEWallet;

        private const int HargaItem = 100;
        public Payment()
        {
            InitializeComponent();

            StateMBanking = new MBankingState(this);
            StateDebit = new DebitState(this);
            StateEWallet = new EWalletState(this);

            MBanking.CheckedChanged += RadioButton_CheckedChanged;
            Debit.CheckedChanged += RadioButton_CheckedChanged;
            EWallet.CheckedChanged += RadioButton_CheckedChanged;

            JumlahItem.Value = 1;
            UpdateTotalHarga();

            JumlahItem.ValueChanged += JumlahItem_ValueChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MBanking.Checked)
            {
                CurrentState = StateMBanking;
            }
            else if (Debit.Checked)
            {
                CurrentState = StateDebit;
            }
            else if (EWallet.Checked)
            {
                CurrentState = StateEWallet;
            }

            CurrentState.UpdateComboBox();
        }

        public ComboBox GetComboBox()
        {
            return BoxBankDigital;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TombolDashboard_Click(object sender, EventArgs e)
        {

        }

        private void TombolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NamaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gambar1_Click(object sender, EventArgs e)
        {

        }

        private void Gambar2_Click(object sender, EventArgs e)
        {

        }

        private void LabelDeskripsi_Click(object sender, EventArgs e)
        {

        }

        private void DeskripsiBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanjangBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void LebarBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void AreaPembayaran_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelJumlahItem_Click(object sender, EventArgs e)
        {

        }
        private void JumlahItem_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalHarga();
        }

        private void LabelTotalHarga_Click(object sender, EventArgs e)
        {

        }

        private void TotalHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTotalHarga()
        {
            decimal totalPrice = JumlahItem.Value * HargaItem;

            CultureInfo rupiah = new CultureInfo("id-ID");
            TotalHarga.Text = totalPrice.ToString("C", rupiah);
        }

        private void LabelPilihMetodePembayaran_Click(object sender, EventArgs e)
        {

        }

        private void MBanking_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Debit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EWallet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BoxBankDigital_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TombolBeli_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah Anda yakin Ingin Membeli Produk Ini", "Recycle Sukabirus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void TombolBatal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah Anda yakin Ingin Membatalkan Produk Ini", "Recycle Sukabirus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void NamaBarang_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

    public interface IState
    {
        void UpdateComboBox();
    }

    public class MBankingState : IState
    {
        private Payment form;

        public MBankingState(Payment form)
        {
            this.form = form;
        }

        public void UpdateComboBox()
        {
            var comboBox = form.GetComboBox();
            comboBox.Items.Clear();
            comboBox.Items.AddRange(new string[] { "BCA", "Mandiri", "CIMB", "BRI", "BNI" });
        }
    }

    public class DebitState : IState
    {
        private Payment form;

        public DebitState(Payment form)
        {
            this.form = form;
        }

        public void UpdateComboBox()
        {
            var comboBox = form.GetComboBox();
            comboBox.Items.Clear();
            comboBox.Items.AddRange(new string[] { "MasterCard", "VISA", "AMEX", "JBC" });
        }
    }

    public class EWalletState : IState
    {
        private Payment form;

        public EWalletState(Payment form)
        {
            this.form = form;
        }

        public void UpdateComboBox()
        {
            var comboBox = form.GetComboBox();
            comboBox.Items.Clear();
            comboBox.Items.AddRange(new string[] { "OVO", "Dana", "GoPay" });
        }
    }
}
