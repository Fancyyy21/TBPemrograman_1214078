﻿using System;
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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutMe newAboutMe = new FormAboutMe();
            newAboutMe.MdiParent = this;
            newAboutMe.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void transaksiPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksiPenjualan newTransaksiPenjualan = new FormTransaksiPenjualan();
            newTransaksiPenjualan.MdiParent = this;
            newTransaksiPenjualan.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataCustomer newCustomer = new FormDataCustomer();
            newCustomer.MdiParent = this;
            newCustomer.Show();
        }

        private void dataPegawaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataPegawai newPegawai = new FormDataPegawai();
            newPegawai.MdiParent = this;
            newPegawai.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
