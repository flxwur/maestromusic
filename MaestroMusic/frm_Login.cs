using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaestroMusic.Classes;


namespace MaestroMusic
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void lbl_registerLink_Click(object sender, EventArgs e)
        {
            //register
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            //login
            string name = tb_username.Text;
            string pswd = tb_pw.Text;

            Bcrypt bc = new Bcrypt;

        
        }
    }
}
