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

        private void pb_classical_MouseHover(object sender, EventArgs e)
        {
            pb_classical.Size = new Size(130, 130);
        }

        // Categories 
        #region categorieKlick

        private void pb_classical_Click(object sender, EventArgs e)
        {

        }

        private void pb_pop_Click(object sender, EventArgs e)
        {

        }

        private void pb_hiphop_Click(object sender, EventArgs e)
        {

        }

        private void pb_country_Click(object sender, EventArgs e)
        {

        }

        private void pb_electronic_Click(object sender, EventArgs e)
        {

        }

        private void pb_hardstyle_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
