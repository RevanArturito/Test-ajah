using System.Collections.Generic;
using System.Windows.Forms;

namespace Admin.UserControls
{
    partial class UC_ListProduk
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.UrutanColoumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamaProdukColoumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipeProdukColoumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HargaProdukColoumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanjangProdukColoumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LebarProdukColoumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StokProdukColoumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeskripsiProdukColoumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrutanColoumn,
            this.NamaProdukColoumn,
            this.TipeProdukColoumn,
            this.HargaProdukColoumn,
            this.PanjangProdukColoumn,
            this.LebarProdukColoumn,
            this.StokProdukColoumn,
            this.DeskripsiProdukColoumn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(79, 140);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1055, 772);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // UrutanColoumn
            // 
            this.UrutanColoumn.Text = "No.";
            this.UrutanColoumn.Width = 34;
            // 
            // NamaProdukColoumn
            // 
            this.NamaProdukColoumn.Text = "Nama ";
            this.NamaProdukColoumn.Width = 92;
            // 
            // TipeProdukColoumn
            // 
            this.TipeProdukColoumn.Text = "Tipe";
            this.TipeProdukColoumn.Width = 95;
            // 
            // HargaProdukColoumn
            // 
            this.HargaProdukColoumn.Text = "Harga";
            this.HargaProdukColoumn.Width = 110;
            // 
            // PanjangProdukColoumn
            // 
            this.PanjangProdukColoumn.Text = "Panjang (/CM)";
            this.PanjangProdukColoumn.Width = 75;
            // 
            // LebarProdukColoumn
            // 
            this.LebarProdukColoumn.Text = "Lebar (/cm)";
            this.LebarProdukColoumn.Width = 112;
            // 
            // StokProdukColoumn
            // 
            this.StokProdukColoumn.Text = "Stok";
            this.StokProdukColoumn.Width = 118;
            // 
            // DeskripsiProdukColoumn
            // 
            this.DeskripsiProdukColoumn.Text = "Deskripsi";
            this.DeskripsiProdukColoumn.Width = 93;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1161, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 102);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1161, 565);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 111);
            this.button2.TabIndex = 2;
            this.button2.Text = "DeletItem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UC_ListProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_ListProduk";
            this.Size = new System.Drawing.Size(1472, 1031);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader NamaProdukColoumn;
        private System.Windows.Forms.ColumnHeader TipeProdukColoumn;
        private System.Windows.Forms.ColumnHeader HargaProdukColoumn;
        private System.Windows.Forms.ColumnHeader PanjangProdukColoumn;
        private System.Windows.Forms.ColumnHeader LebarProdukColoumn;
        private System.Windows.Forms.ColumnHeader StokProdukColoumn;
        private System.Windows.Forms.ColumnHeader DeskripsiProdukColoumn;
        private System.Windows.Forms.ColumnHeader UrutanColoumn;



        }
}
