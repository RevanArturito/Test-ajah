namespace GUI.UserControls
{
    partial class ListProduct
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
            listView1 = new ListView();
            idProdukColumn = new ColumnHeader();
            NamaProdukColumn = new ColumnHeader();
            TipeProdukColumn = new ColumnHeader();
            HargaProdukColumn = new ColumnHeader();
            PanjangProdukColumn = new ColumnHeader();
            LebarProdukColumn = new ColumnHeader();
            StokProdukColumn = new ColumnHeader();
            DeskripsiProdukColumn = new ColumnHeader();
            label1 = new Label();
            ButtonHapus = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idProdukColumn, NamaProdukColumn, TipeProdukColumn, HargaProdukColumn, PanjangProdukColumn, LebarProdukColumn, StokProdukColumn, DeskripsiProdukColumn });
            listView1.Location = new Point(114, 126);
            listView1.Name = "listView1";
            listView1.Size = new Size(1057, 620);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 75);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 1;
            label1.Text = "DAFTAR PRODUK";
            label1.Click += label1_Click_1;
            // 
            // ButtonHapus
            // 
            ButtonHapus.BackColor = Color.Red;
            ButtonHapus.ForeColor = SystemColors.ButtonHighlight;
            ButtonHapus.Location = new Point(728, 75);
            ButtonHapus.Name = "ButtonHapus";
            ButtonHapus.Size = new Size(207, 38);
            ButtonHapus.TabIndex = 2;
            ButtonHapus.Text = "HAPUS PRODUK";
            ButtonHapus.UseVisualStyleBackColor = false;
            ButtonHapus.Click += ButtonHapus_Click;
            // 
            // button2
            // 
            button2.Location = new Point(964, 75);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(207, 38);
            button2.TabIndex = 3;
            button2.Text = "EDIT PRODUK";
            button2.UseVisualStyleBackColor = true;
            // 
            // ListProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(ButtonHapus);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "ListProduct";
            Size = new Size(1276, 845);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader idProdukColumn;
        private ColumnHeader NamaProdukColumn;
        private ColumnHeader TipeProdukColumn;
        private ColumnHeader HargaProdukColumn;
        private ColumnHeader PanjangProdukColumn;
        private ColumnHeader LebarProdukColumn;
        private ColumnHeader StokProdukColumn;
        private ColumnHeader DeskripsiProdukColumn;
        private Label label1;
        private Button ButtonHapus;
        private Button button2;
    }
}
