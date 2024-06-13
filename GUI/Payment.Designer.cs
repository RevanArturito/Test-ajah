namespace GUI
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TombolBatal = new Button();
            BoxBankDigital = new ComboBox();
            TombolExit = new Button();
            JumlahItem = new NumericUpDown();
            EWallet = new RadioButton();
            Debit = new RadioButton();
            MBanking = new RadioButton();
            TotalHarga = new TextBox();
            LabelPilihMetodePembayaran = new Label();
            LabelTotalHarga = new Label();
            LabelJumlahItem = new Label();
            TombolDashboard = new Button();
            Gambar2 = new PictureBox();
            Gambar1 = new PictureBox();
            LabelDeskripsi = new Label();
            LebarBarang = new TextBox();
            PanjangBarang = new TextBox();
            DeskripsiBarang = new TextBox();
            NamaBarang = new TextBox();
            Header = new Panel();
            TombolBeli = new Button();
            AreaPembayaran = new Panel();
            ((System.ComponentModel.ISupportInitialize)JumlahItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gambar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gambar1).BeginInit();
            AreaPembayaran.SuspendLayout();
            SuspendLayout();
            // 
            // TombolBatal
            // 
            TombolBatal.BackColor = Color.Crimson;
            TombolBatal.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TombolBatal.Location = new Point(18, 536);
            TombolBatal.Name = "TombolBatal";
            TombolBatal.Size = new Size(322, 50);
            TombolBatal.TabIndex = 10;
            TombolBatal.Text = "Batal";
            TombolBatal.UseVisualStyleBackColor = false;
            // 
            // BoxBankDigital
            // 
            BoxBankDigital.FormattingEnabled = true;
            BoxBankDigital.Items.AddRange(new object[] { "a", "s", "d" });
            BoxBankDigital.Location = new Point(18, 326);
            BoxBankDigital.Name = "BoxBankDigital";
            BoxBankDigital.Size = new Size(151, 28);
            BoxBankDigital.TabIndex = 8;
            // 
            // TombolExit
            // 
            TombolExit.Location = new Point(1105, 18);
            TombolExit.Name = "TombolExit";
            TombolExit.Size = new Size(31, 31);
            TombolExit.TabIndex = 21;
            TombolExit.UseVisualStyleBackColor = true;
            // 
            // JumlahItem
            // 
            JumlahItem.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JumlahItem.Location = new Point(83, 72);
            JumlahItem.Name = "JumlahItem";
            JumlahItem.Size = new Size(184, 27);
            JumlahItem.TabIndex = 11;
            // 
            // EWallet
            // 
            EWallet.AutoSize = true;
            EWallet.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EWallet.ForeColor = Color.White;
            EWallet.Location = new Point(239, 281);
            EWallet.Name = "EWallet";
            EWallet.Size = new Size(79, 21);
            EWallet.TabIndex = 7;
            EWallet.TabStop = true;
            EWallet.Text = "EWallet";
            EWallet.UseVisualStyleBackColor = true;
            // 
            // Debit
            // 
            Debit.AutoSize = true;
            Debit.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Debit.ForeColor = Color.White;
            Debit.Location = new Point(147, 281);
            Debit.Name = "Debit";
            Debit.Size = new Size(63, 21);
            Debit.TabIndex = 6;
            Debit.TabStop = true;
            Debit.Text = "Debit";
            Debit.UseVisualStyleBackColor = true;
            // 
            // MBanking
            // 
            MBanking.AutoSize = true;
            MBanking.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MBanking.ForeColor = Color.White;
            MBanking.Location = new Point(24, 281);
            MBanking.Name = "MBanking";
            MBanking.Size = new Size(92, 21);
            MBanking.TabIndex = 5;
            MBanking.TabStop = true;
            MBanking.Text = "MBanking";
            MBanking.UseVisualStyleBackColor = true;
            // 
            // TotalHarga
            // 
            TotalHarga.Location = new Point(83, 178);
            TotalHarga.Name = "TotalHarga";
            TotalHarga.Size = new Size(184, 27);
            TotalHarga.TabIndex = 4;
            // 
            // LabelPilihMetodePembayaran
            // 
            LabelPilihMetodePembayaran.AutoSize = true;
            LabelPilihMetodePembayaran.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPilihMetodePembayaran.ForeColor = Color.White;
            LabelPilihMetodePembayaran.Location = new Point(13, 232);
            LabelPilihMetodePembayaran.Name = "LabelPilihMetodePembayaran";
            LabelPilihMetodePembayaran.Size = new Size(269, 26);
            LabelPilihMetodePembayaran.TabIndex = 2;
            LabelPilihMetodePembayaran.Text = "Pilih Metode Pembayaran";
            // 
            // LabelTotalHarga
            // 
            LabelTotalHarga.AutoSize = true;
            LabelTotalHarga.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTotalHarga.ForeColor = Color.White;
            LabelTotalHarga.Location = new Point(14, 128);
            LabelTotalHarga.Name = "LabelTotalHarga";
            LabelTotalHarga.Size = new Size(128, 26);
            LabelTotalHarga.TabIndex = 1;
            LabelTotalHarga.Text = "Total Harga";
            // 
            // LabelJumlahItem
            // 
            LabelJumlahItem.AutoSize = true;
            LabelJumlahItem.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelJumlahItem.ForeColor = Color.White;
            LabelJumlahItem.Location = new Point(14, 21);
            LabelJumlahItem.Name = "LabelJumlahItem";
            LabelJumlahItem.Size = new Size(179, 26);
            LabelJumlahItem.TabIndex = 0;
            LabelJumlahItem.Text = "Atur Jumlah Item";
            // 
            // TombolDashboard
            // 
            TombolDashboard.Location = new Point(11, 7);
            TombolDashboard.Name = "TombolDashboard";
            TombolDashboard.Size = new Size(120, 52);
            TombolDashboard.TabIndex = 20;
            TombolDashboard.UseVisualStyleBackColor = true;
            // 
            // Gambar2
            // 
            Gambar2.Location = new Point(354, 162);
            Gambar2.Name = "Gambar2";
            Gambar2.Size = new Size(283, 241);
            Gambar2.TabIndex = 19;
            Gambar2.TabStop = false;
            // 
            // Gambar1
            // 
            Gambar1.BackColor = SystemColors.Control;
            Gambar1.Location = new Point(12, 162);
            Gambar1.Name = "Gambar1";
            Gambar1.Size = new Size(294, 241);
            Gambar1.SizeMode = PictureBoxSizeMode.StretchImage;
            Gambar1.TabIndex = 18;
            Gambar1.TabStop = false;
            // 
            // LabelDeskripsi
            // 
            LabelDeskripsi.AutoSize = true;
            LabelDeskripsi.BackColor = Color.Transparent;
            LabelDeskripsi.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDeskripsi.Location = new Point(11, 421);
            LabelDeskripsi.Name = "LabelDeskripsi";
            LabelDeskripsi.Size = new Size(185, 26);
            LabelDeskripsi.TabIndex = 17;
            LabelDeskripsi.Text = "Informasi Barang";
            // 
            // LebarBarang
            // 
            LebarBarang.BorderStyle = BorderStyle.None;
            LebarBarang.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LebarBarang.Location = new Point(14, 632);
            LebarBarang.Name = "LebarBarang";
            LebarBarang.Size = new Size(254, 21);
            LebarBarang.TabIndex = 16;
            LebarBarang.Text = "Lebar : ";
            // 
            // PanjangBarang
            // 
            PanjangBarang.BorderStyle = BorderStyle.None;
            PanjangBarang.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PanjangBarang.Location = new Point(14, 595);
            PanjangBarang.Name = "PanjangBarang";
            PanjangBarang.Size = new Size(254, 21);
            PanjangBarang.TabIndex = 15;
            PanjangBarang.Text = "Panjang : ";
            // 
            // DeskripsiBarang
            // 
            DeskripsiBarang.BorderStyle = BorderStyle.None;
            DeskripsiBarang.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeskripsiBarang.Location = new Point(16, 461);
            DeskripsiBarang.Multiline = true;
            DeskripsiBarang.Name = "DeskripsiBarang";
            DeskripsiBarang.Size = new Size(525, 124);
            DeskripsiBarang.TabIndex = 14;
            // 
            // NamaBarang
            // 
            NamaBarang.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaBarang.Location = new Point(16, 93);
            NamaBarang.Name = "NamaBarang";
            NamaBarang.Size = new Size(525, 27);
            NamaBarang.TabIndex = 13;
            NamaBarang.TextChanged += NamaBarang_TextChanged_1;
            // 
            // Header
            // 
            Header.BackColor = SystemColors.Window;
            Header.BorderStyle = BorderStyle.FixedSingle;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(1153, 68);
            Header.TabIndex = 11;
            Header.Paint += Header_Paint;
            // 
            // TombolBeli
            // 
            TombolBeli.BackColor = Color.ForestGreen;
            TombolBeli.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TombolBeli.Location = new Point(18, 444);
            TombolBeli.Name = "TombolBeli";
            TombolBeli.Size = new Size(322, 50);
            TombolBeli.TabIndex = 9;
            TombolBeli.Text = "Beli";
            TombolBeli.UseVisualStyleBackColor = false;
            // 
            // AreaPembayaran
            // 
            AreaPembayaran.BackColor = Color.FromArgb(0, 34, 49);
            AreaPembayaran.Controls.Add(JumlahItem);
            AreaPembayaran.Controls.Add(TombolBatal);
            AreaPembayaran.Controls.Add(TombolBeli);
            AreaPembayaran.Controls.Add(BoxBankDigital);
            AreaPembayaran.Controls.Add(EWallet);
            AreaPembayaran.Controls.Add(Debit);
            AreaPembayaran.Controls.Add(MBanking);
            AreaPembayaran.Controls.Add(TotalHarga);
            AreaPembayaran.Controls.Add(LabelPilihMetodePembayaran);
            AreaPembayaran.Controls.Add(LabelTotalHarga);
            AreaPembayaran.Controls.Add(LabelJumlahItem);
            AreaPembayaran.Location = new Point(795, 68);
            AreaPembayaran.Name = "AreaPembayaran";
            AreaPembayaran.Size = new Size(358, 610);
            AreaPembayaran.TabIndex = 12;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 679);
            Controls.Add(TombolExit);
            Controls.Add(TombolDashboard);
            Controls.Add(Gambar2);
            Controls.Add(Gambar1);
            Controls.Add(LabelDeskripsi);
            Controls.Add(LebarBarang);
            Controls.Add(PanjangBarang);
            Controls.Add(DeskripsiBarang);
            Controls.Add(NamaBarang);
            Controls.Add(Header);
            Controls.Add(AreaPembayaran);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)JumlahItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gambar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gambar1).EndInit();
            AreaPembayaran.ResumeLayout(false);
            AreaPembayaran.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TombolBatal;
        private ComboBox BoxBankDigital;
        private Button TombolExit;
        private NumericUpDown JumlahItem;
        private RadioButton EWallet;
        private RadioButton Debit;
        private RadioButton MBanking;
        private TextBox TotalHarga;
        private Label LabelPilihMetodePembayaran;
        private Label LabelTotalHarga;
        private Label LabelJumlahItem;
        private Button TombolDashboard;
        private PictureBox Gambar2;
        private PictureBox Gambar1;
        private Label LabelDeskripsi;
        private TextBox LebarBarang;
        private TextBox PanjangBarang;
        private TextBox DeskripsiBarang;
        private TextBox NamaBarang;
        private Panel Header;
        private Button TombolBeli;
        private Panel AreaPembayaran;
    }
}