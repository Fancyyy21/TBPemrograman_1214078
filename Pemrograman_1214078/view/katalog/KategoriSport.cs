﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view.katalog
{
    public partial class KategoriSport : Form
    {
        public KategoriSport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tombolback
            this.Hide();
            FormKatalog newKatalog = new FormKatalog();
            newKatalog.Show();
        }


        private void KategoriSport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
