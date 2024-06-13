using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Admin.ProdukSpek
{
    public class Produk
    {
        public string namaproduk { get; set; }
        public string jenis { get; set; }
        public string idProduk { get; set; }
        public string hargaProduk { get; set; }
        public string panjangProduk { get; set; }
        public string lebarProduk { get; set; }
        public int stokProduk { get; set; }
        public string deskripsiProduk { get; set; }

        public Produk(String id, String nama, String jenis, String harga, String panjang, String lebar, int stok, String deskripsi)
        {
            this.idProduk = id;
            this.namaproduk = nama;
            this.jenis = jenis;
            this.hargaProduk = harga;
            this.panjangProduk = panjang;
            this.lebarProduk = lebar;
            this.stokProduk = stok;
            this.deskripsiProduk = deskripsi;
        }
    }
}
