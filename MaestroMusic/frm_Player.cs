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
    public partial class frm_Player : Form
    {
        public frm_Player()
        {
            InitializeComponent();
        }

        private void pb_userIcon_Click(object sender, EventArgs e)
        {
            //login form with constructor login passen
            Close LogedIn = new Close();
            this.Hide();
            LogedIn.ShowDialog();
            this.Show();
        }
    }
}
