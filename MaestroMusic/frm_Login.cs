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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_Close close = new frm_Close();
            close.ShowDialog();
        }

        private void lbl_registerLink_Click(object sender, EventArgs e)
        {
            //register
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            //login
        }
    }
}
