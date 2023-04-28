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
    public partial class frm_Category : Form
    {
        public frm_Category()
        {
            InitializeComponent();
        }

        // passes the category title to the category form
        public frm_Category(string h1)
        {
            InitializeComponent();
            lbl_h1.Text = h1;
        }

        private void pb_logoRightTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_h2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // changes the icon when clicking on the play icon
        private void pb_playPause_Click(object sender, EventArgs e)
        {
            pb_pausePlay.Visible = true;
            pb_pausePlay.Enabled = true;

            pb_playPause.Visible = false;
            pb_playPause.Enabled = false;
        }

        // changes the icon when clicking on the pause icon
        private void pb_pausePlay_Click(object sender, EventArgs e)
        {
            pb_pausePlay.Visible = false;
            pb_pausePlay.Enabled = false;

            pb_playPause.Visible = true;
            pb_playPause.Enabled = true;

        }

        private void pb_playBTN_Click(object sender, EventArgs e)
        {
            pb_playPause_Click( sender,  e);
        }
    }
}
