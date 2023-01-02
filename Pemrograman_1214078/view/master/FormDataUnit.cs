using Pemrograman_1214078.controller;
using Pemrograman_1214078.controller.master;
using Pemrograman_1214078.model;
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

namespace Pemrograman_1214078.view.master
{
    public partial class FormDataUnit : Form
    {
        Koneksi koneksi = new Koneksi();
        M_DataUnit dataunit = new M_DataUnit();
        string id;

        public void Tampil()
        {
            /* DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/



            //QueryDB
            DataUnitt.DataSource = koneksi.ShowData("select * from t_unit");

            //Mengubah Nama Kolom Table
            DataUnitt.Columns[0].HeaderText = "ID_Unit";
            DataUnitt.Columns[1].HeaderText = "Jenis Motor";
            DataUnitt.Columns[2].HeaderText = "Merk Motor";
            DataUnitt.Columns[3].HeaderText = "Jumlah Unit";
            DataUnitt.Columns[4].HeaderText = "Harga Motor";
            DataUnitt.Columns[5].HeaderText = "Tahun Produksi";
            DataUnitt.Columns[6].HeaderText = "Kondisi Motor";

        }

        public FormDataUnit()
        {         
            InitializeComponent();
        }

        private void FormDataUnit_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbJenisMotor.Text = "";
            tbMerkMotor.Text = "";
            tbJumlahUnit.Text = "";
            tbHargaMotor.Text = "";
            tbTahunProduksi.Text = "";
            tbKondisiMotor.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbJenisMotor.Text == "" || tbMerkMotor.Text == "" || tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTahunProduksi.Text == "" || tbKondisiMotor.Text == "")
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
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbJenisMotor.Text == "" || tbMerkMotor.Text == "" || tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTahunProduksi.Text == "" || tbKondisiMotor.Text == "")
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

                dataunitt.Update(dataunit, id);

                tbJenisMotor.Text = "";
                tbMerkMotor.Text = "";
                tbJumlahUnit.Text = "";
                tbHargaMotor.Text = "";
                tbTahunProduksi.Text = "";
                tbKondisiMotor.Text = "";


                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                DataUnit dataunit = new DataUnit();
                dataunit.Delete(id);
                Tampil();
            }
        }

        private void DataUnitt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataUnitt.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbJenisMotor.Text = DataUnitt.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbMerkMotor.Text = DataUnitt.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbJumlahUnit.Text = DataUnitt.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbHargaMotor.Text = DataUnitt.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTahunProduksi.Text = DataUnitt.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbKondisiMotor.Text = DataUnitt.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            DataUnitt.DataSource = koneksi.ShowData("SELECT * FROM t_unit WHERE id_unit LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jenis LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR merk LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jumlah_unit LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR harga LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR tahun_produksi LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR kondisi LIKE '%' '" + tbCariData.Text + "' '%' ");
        }
    }
}
