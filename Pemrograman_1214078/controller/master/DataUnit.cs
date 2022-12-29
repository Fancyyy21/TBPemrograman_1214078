using Pemrograman_1214078.model;
using Pemrograman_1214078.model.master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.controller.master
{
    internal class DataUnit
    {
        //Memanggil class koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(M_DataUnit data_unit)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_unit(jenis, merk, jumlah_unit, harga, tahun_produksi, kondisi) VALUES('" + data_unit.Jenis + "', '" +
                data_unit.Merk + "', '" + data_unit.Jumlah_unit + "', '" + data_unit.Harga + "', '" + data_unit.Tahun_produksi + "', '" + data_unit.Kondisi + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(M_DataUnit data_unit, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_unit SET t_unit ='" + data_unit.Jenis + "'," +
                    "jabatan='" + data_unit.Merk + "'," + "alamat='" + data_unit.Jumlah_unit + "'," +
                    "jenis_kelamin='" + data_unit.Harga + "'," + "umur='" + data_unit.Tahun_produksi + "'," +
                    "nohp='" + data_unit.Kondisi + "' WHERE t_unit ='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }


        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_unit WHERE t_unit ='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
