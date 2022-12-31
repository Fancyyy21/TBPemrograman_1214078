using Pemrograman_1214078.controller;
using Pemrograman_1214078.controller.master;
using Pemrograman_1214078.model.master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view
{
    public partial class FormTransaksiPenjualan : Form
    {
        //Koneksi koneksi = new Koneksi();
        //M_DataUnit dataunit = new M_DataUnit();
        //string id;

        public void Tampil()
        {
            /*
            DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/
            /*

                        //QueryDB
                        DataTransaksiPenjualan.DataSource = koneksi.ShowData("select * from transaksi_penjualan");

                        //Mengubah Nama Kolom Table
                        DataTransaksiPenjualan.Columns[0].HeaderText = "ID_Unit";
                        DataTransaksiPenjualan.Columns[1].HeaderText = "Jenis Motor";
                        DataTransaksiPenjualan.Columns[2].HeaderText = "Merk Motor";
                        DataTransaksiPenjualan.Columns[3].HeaderText = "Jumlah Unit";
                        DataTransaksiPenjualan.Columns[4].HeaderText = "Harga Motor";
                        DataTransaksiPenjualan.Columns[5].HeaderText = "Tahun Produksi";
                        DataTransaksiPenjualan.Columns[6].HeaderText = "Kondisi Motor";*/

        }
        public FormTransaksiPenjualan()
        {
            InitializeComponent();
        }
        private void FormTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataTransaksiPenjualan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
