namespace GUI.UserControls
{
    partial class BeliProduk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idProdukColumn = new ColumnHeader();
            NamaProdukColumn = new ColumnHeader();
            TipeProdukColumn = new ColumnHeader();
            HargaProdukColumn = new ColumnHeader();
            PanjangProdukColumn = new ColumnHeader();
            LebarProdukColumn = new ColumnHeader();
            StokProdukColumn = new ColumnHeader();
            DeskripsiProdukColumn = new ColumnHeader();
            listView1 = new ListView();
            label1 = new Label();
            ButtonBeli = new Button();
            SuspendLayout();
            // 
            // idProdukColumn
            // 
            idProdukColumn.Text = "ID";
            idProdukColumn.Width = 100;
            // 
            // NamaProdukColumn
            // 
            NamaProdukColumn.Text = "Nama ";
            NamaProdukColumn.Width = 170;
            // 
            // TipeProdukColumn
            // 
            TipeProdukColumn.Text = "Tipe ";
            TipeProdukColumn.Width = 150;
            // 
            // HargaProdukColumn
            // 
            HargaProdukColumn.Text = "Harga ";
            HargaProdukColumn.Width = 100;
            // 
            // PanjangProdukColumn
            // 
            PanjangProdukColumn.Text = "Panjang";
            // 
            // LebarProdukColumn
            // 
            LebarProdukColumn.Text = "Lebar";
            // 
            // StokProdukColumn
            // 
            StokProdukColumn.Text = "Stok";
            // 
            // DeskripsiProdukColumn
            // 
            DeskripsiProdukColumn.Text = "Deskripsi";
            DeskripsiProdukColumn.Width = 1500;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idProdukColumn, NamaProdukColumn, TipeProdukColumn, HargaProdukColumn, PanjangProdukColumn, LebarProdukColumn, StokProdukColumn, DeskripsiProdukColumn });
            listView1.Location = new Point(110, 138);
            listView1.Name = "listView1";
            listView1.Size = new Size(1057, 620);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 87);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 5;
            label1.Text = "DAFTAR PRODUK";
            // 
            // ButtonBeli
            // 
            ButtonBeli.BackColor = Color.FromArgb(0, 34, 49);
            ButtonBeli.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonBeli.ForeColor = Color.White;
            ButtonBeli.Location = new Point(960, 87);
            ButtonBeli.Name = "ButtonBeli";
            ButtonBeli.RightToLeft = RightToLeft.Yes;
            ButtonBeli.Size = new Size(207, 38);
            ButtonBeli.TabIndex = 7;
            ButtonBeli.Text = "Beli";
            ButtonBeli.UseVisualStyleBackColor = false;
            ButtonBeli.Click += ButtonBeli_Click;
            // 
            // BeliProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonBeli);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "BeliProduk";
            Size = new Size(1276, 845);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColumnHeader idProdukColumn;
        private ColumnHeader NamaProdukColumn;
        private ColumnHeader TipeProdukColumn;
        private ColumnHeader HargaProdukColumn;
        private ColumnHeader PanjangProdukColumn;
        private ColumnHeader LebarProdukColumn;
        private ColumnHeader StokProdukColumn;
        private ColumnHeader DeskripsiProdukColumn;
        private ListView listView1;
        private Label label1;
        private Button ButtonBeli;
    }
}
