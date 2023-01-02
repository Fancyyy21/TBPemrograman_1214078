using Pemrograman_1214078.controller;
using Pemrograman_1214078.controller.master;
using Pemrograman_1214078.model.datatransaksi;
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
        Koneksi koneksi = new Koneksi();
        M_TransaksiPenjualan transpenjualan = new M_TransaksiPenjualan();
        string id;

        public void Tampil()
        {
            /*
            DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/
            

                        //QueryDB
                        DataTransaksiPenjualan.DataSource = koneksi.ShowData("select * from transaksi_penjualan");

                        //Mengubah Nama Kolom Table
                        DataTransaksiPenjualan.Columns[0].HeaderText = "ID_Penjualan";
                        DataTransaksiPenjualan.Columns[1].HeaderText = "Nama Customer";
                        DataTransaksiPenjualan.Columns[2].HeaderText = "Merk";
                        DataTransaksiPenjualan.Columns[3].HeaderText = "Tanggal";
                        DataTransaksiPenjualan.Columns[4].HeaderText = "Kondisi";
                        DataTransaksiPenjualan.Columns[5].HeaderText = "Pegawai Yang Menangani";
                        DataTransaksiPenjualan.Columns[6].HeaderText = "Jumlah Unit";
                        DataTransaksiPenjualan.Columns[7].HeaderText = "Harga";
                        DataTransaksiPenjualan.Columns[8].HeaderText = "Total";

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
            /*if (tbNamaCustomer.Text == "" || tbMerkMotorYangDibeli.Text == "" || dtTanggalTransaksi.Text == "" || tbKondisiMotor.Text == "" || tbNamaPegawaiMenangani.Text == "" || tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataUnit dataunitt = new DataUnit();
                dataunit.Jenis = tbJenisMotor.Text;
                dataunit.Merk = tbMerkMotor.Text;
                dataunit.Jumlah_unit = tbJumlahUnit.Text;
                dataunit.Harga = tbHargaMotor.Text;
                dataunit.Tahun_produksi = tbTahunProduksi.Text;
                dataunit.Kondisi = tbKondisiMotor.Text;

                dataunitt.Insert(dataunit);

                tbJenisMotor.Text = "";
                tbMerkMotor.Text = "";
                tbJumlahUnit.Text = "";
                tbHargaMotor.Text = "";
                tbTahunProduksi.Text = "";
                tbKondisiMotor.Text = "";


                Tampil();
            }*/
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
