﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaestroMusic
{
    public partial class frm_Close : Form
    {
        public frm_Close()
        {
            InitializeComponent();
        }

        private void btn_doClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_noClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
