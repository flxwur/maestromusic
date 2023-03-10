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
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void lbl_loginLink_Click(object sender, EventArgs e)
        {
            // back to Login
            this.Close();
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {

            //check if data is valid
            //register in database

            //login

            //login form with constructor login passen
            frm_Player LogedIn = new frm_Player();
            this.Hide();
            LogedIn.ShowDialog();
            this.Show();
        }
    }
}
