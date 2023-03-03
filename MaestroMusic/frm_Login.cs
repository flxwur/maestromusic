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

        private void lbl_registerLink_Click(object sender, EventArgs e)
        {
            //register
            frm_Register Register = new frm_Register();
            this.Hide();
            Register.ShowDialog();
            this.Show();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            //login
            
            //check with database

            //login form with constructor login passen
            frm_Player LogedIn = new frm_Player();
            this.Hide();
            LogedIn.ShowDialog();
            this.Show();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
        }

        private void frm_Login_Hover(object sender, EventArgs e)
        {
            lbl_login.Font = new Font(lbl_login.Font.Name, lbl_login.Font.SizeInPoints, FontStyle.Underline);
        }
        private void frm_Login_HoverOff(object sender, EventArgs e)
        {
            lbl_login.Font = new Font(lbl_login.Font.Name, lbl_login.Font.SizeInPoints, FontStyle.Regular);
        }
    }
    }
    
