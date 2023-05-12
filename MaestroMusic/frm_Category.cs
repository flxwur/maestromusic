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
        string[] path;
        string[] files;

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

            if (lb_playlist.SelectedItem != null) 
          
            {
                wmd_player.URL = lb_playlist.SelectedItem.ToString();   //Playes the song
                wmd_player.settings.autoStart = true;
            }else
            {
                MessageBox.Show("Please select a song");
            }
        }

        // changes the icon when clicking on the pause icon
        private void pb_pausePlay_Click(object sender, EventArgs e)
        {
            pb_pausePlay.Visible = false;
            pb_pausePlay.Enabled = false;

            pb_playPause.Visible = true;
            pb_playPause.Enabled = true;
            wmd_player.Ctlcontrols.pause();
            
        }

        private void pb_playBTN_Click(object sender, EventArgs e)
        {
            pb_playPause_Click( sender,  e);
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog musicLoader = new OpenFileDialog();
            if (musicLoader.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = musicLoader.SafeFileNames;
                path = musicLoader.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    lb_playlist.Items.Add(path[i]);
                }
            }
        }

        private void pb_next_Click(object sender, EventArgs e)
        {
            wmd_player.Ctlcontrols.pause();
            lb_playlist.SelectedIndex ++;
            wmd_player.URL = lb_playlist.SelectedItems.ToString();
            wmd_player.Ctlcontrols.play();
        }
    }
}
