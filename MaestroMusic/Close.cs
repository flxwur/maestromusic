using System;
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
    public partial class Close : Form
    {
        public Close()
        {
            InitializeComponent();
        }

        private void btn_doClose_Click(object sender, EventArgs e)
        {
            //login form with constructor login passen
            frm_Login LogedIn = new frm_Login();
            this.Hide();
            LogedIn.ShowDialog();
            this.Show();
        }

        private void btn_noClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
