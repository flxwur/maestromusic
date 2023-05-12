using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using MaestroMusic.Classes;


namespace MaestroMusic
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        // register process
        private void lbl_registerLink_Click(object sender, EventArgs e)
        {
         
            frm_Register Register = new frm_Register();
            this.Hide();
            Register.ShowDialog();
            this.Show();
        }

        // login process
        private void lbl_login_Click(object sender, EventArgs e)
        {
            // takes the values from user and puts it into string
            
            string user = tb_username.Text;
            string pw = tb_pw.Text;

            if(SQLCommunication.checkLogin(user, pw))
            {
                //login form with constructor login passen (user, pw)

                frm_Player LogedIn = new frm_Player(user);
                this.Hide();
                LogedIn.ShowDialog();
                this.Show();
            }


        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
        }

        // *hover effect* for login lbl
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
    
