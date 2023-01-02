using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model.datatransaksi
{
    internal class M_TransaksiPenjualan
    {
        string nama_customer, merk, tanggal, kondisi, pegawai_menangani, jumlah_unit, harga, total;

        public M_TransaksiPenjualan()
        {

        }

        public M_TransaksiPenjualan(string nama_customer, string merk, string tanggal, string kondisi, string pegawai_menangani, string jumlah_unit, string harga, string total)
        {
            this.Nama_customer = nama_customer;
            this.Merk = merk;
            this.Tanggal = tanggal;
            this.Kondisi = kondisi;
            this.Pegawai_menangani = pegawai_menangani;
            this.Jumlah_unit = jumlah_unit;
            this.Harga = harga;
            this.Total = total;
        }

        public string Nama_customer { get => nama_customer; set => nama_customer = value; }
        public string Merk { get => merk; set => merk = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public string Kondisi { get => kondisi; set => kondisi = value; }
        public string Pegawai_menangani { get => pegawai_menangani; set => pegawai_menangani = value; }
        public string Jumlah_unit { get => jumlah_unit; set => jumlah_unit = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Total { get => total; set => total = value; }
    }
}
