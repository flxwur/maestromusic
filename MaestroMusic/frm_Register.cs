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
            string username = txtBox_user.Text;
            string mail = txtBox_mail.Text;
            string pw = txtBox_PW.Text;
            string confirmPW = txtBox_confirmPW.Text;

            if (confirmPW.Equals(pw) && pw.Length >= 8)
            {
                
                //open connection

                //register in database

                //login

                //login form with constructor login passen
                frm_Player LogedIn = new frm_Player();
                this.Hide();
                LogedIn.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Passwords do not match aren't over 8 characters!");
            }

            
        }
    }
}
