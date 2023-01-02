using Pemrograman_1214078.controller;
using Pemrograman_1214078.model.datatransaksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view.datatransaksi
{
    public partial class FormTransaksiMasuk : Form
    {
        Koneksi koneksi = new Koneksi();
        M_TransaksiMasuk transmasuk = new M_TransaksiMasuk();
        string id;

        public void Tampil()
        {
            /*
            DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/


            //QueryDB
            DataTransaksiMasuk.DataSource = koneksi.ShowData("select * from transaksi_masuk");

            //Mengubah Nama Kolom Table
            DataTransaksiMasuk.Columns[0].HeaderText = "ID_Masuk";
            DataTransaksiMasuk.Columns[1].HeaderText = "Supplier";
            DataTransaksiMasuk.Columns[2].HeaderText = "Merk";
            DataTransaksiMasuk.Columns[3].HeaderText = "Tanggal";
            DataTransaksiMasuk.Columns[4].HeaderText = "Jumlah Unit";
            DataTransaksiMasuk.Columns[5].HeaderText = "Harga";
            DataTransaksiMasuk.Columns[6].HeaderText = "Total";
            
        }

        public FormTransaksiMasuk()
        {
            InitializeComponent();
        }

        private void FormTransaksiMasuk_Load(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}
