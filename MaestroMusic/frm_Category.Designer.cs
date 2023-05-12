namespace MaestroMusic
{
    partial class frm_Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Category));
            this.lbl_h2 = new System.Windows.Forms.Label();
            this.lbl_h1 = new System.Windows.Forms.Label();
            this.prgsbar_songlength = new System.Windows.Forms.ProgressBar();
            this.lbl_length0 = new System.Windows.Forms.Label();
            this.lbl_length1 = new System.Windows.Forms.Label();
            this.pb_playPause = new System.Windows.Forms.PictureBox();
            this.pb_logoRightTop = new System.Windows.Forms.PictureBox();
            this.pb_pausePlay = new System.Windows.Forms.PictureBox();
            this.lb_playlist = new System.Windows.Forms.ListBox();
            this.wmd_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_upload = new System.Windows.Forms.Button();
            this.pb_next = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoRightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pausePlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmd_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_h2
            // 
            this.lbl_h2.AutoSize = true;
            this.lbl_h2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h2.ForeColor = System.Drawing.Color.White;
            this.lbl_h2.Location = new System.Drawing.Point(49, 9);
            this.lbl_h2.Name = "lbl_h2";
            this.lbl_h2.Size = new System.Drawing.Size(166, 25);
            this.lbl_h2.TabIndex = 11;
            this.lbl_h2.Text = "Maestro Music";
            this.lbl_h2.Click += new System.EventHandler(this.lbl_h2_Click);
            // 
            // lbl_h1
            // 
            this.lbl_h1.AutoSize = true;
            this.lbl_h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h1.ForeColor = System.Drawing.Color.White;
            this.lbl_h1.Location = new System.Drawing.Point(382, 66);
            this.lbl_h1.Name = "lbl_h1";
            this.lbl_h1.Size = new System.Drawing.Size(174, 25);
            this.lbl_h1.TabIndex = 12;
            this.lbl_h1.Text = "Category Name";
            // 
            // prgsbar_songlength
            // 
            this.prgsbar_songlength.Location = new System.Drawing.Point(22, 400);
            this.prgsbar_songlength.Name = "prgsbar_songlength";
            this.prgsbar_songlength.Size = new System.Drawing.Size(759, 11);
            this.prgsbar_songlength.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgsbar_songlength.TabIndex = 18;
            this.prgsbar_songlength.Value = 50;
            // 
            // lbl_length0
            // 
            this.lbl_length0.AutoSize = true;
            this.lbl_length0.ForeColor = System.Drawing.Color.White;
            this.lbl_length0.Location = new System.Drawing.Point(19, 384);
            this.lbl_length0.Name = "lbl_length0";
            this.lbl_length0.Size = new System.Drawing.Size(28, 13);
            this.lbl_length0.TabIndex = 19;
            this.lbl_length0.Text = "0:00";
            // 
            // lbl_length1
            // 
            this.lbl_length1.AutoSize = true;
            this.lbl_length1.ForeColor = System.Drawing.Color.White;
            this.lbl_length1.Location = new System.Drawing.Point(753, 384);
            this.lbl_length1.Name = "lbl_length1";
            this.lbl_length1.Size = new System.Drawing.Size(28, 13);
            this.lbl_length1.TabIndex = 20;
            this.lbl_length1.Text = "4:20";
            // 
            // pb_playPause
            // 
            this.pb_playPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_playPause.BackgroundImage")));
            this.pb_playPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_playPause.Location = new System.Drawing.Point(387, 365);
            this.pb_playPause.Name = "pb_playPause";
            this.pb_playPause.Size = new System.Drawing.Size(31, 29);
            this.pb_playPause.TabIndex = 21;
            this.pb_playPause.TabStop = false;
            this.pb_playPause.Click += new System.EventHandler(this.pb_playPause_Click);
            // 
            // pb_logoRightTop
            // 
            this.pb_logoRightTop.BackColor = System.Drawing.Color.Transparent;
            this.pb_logoRightTop.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_logo_png1;
            this.pb_logoRightTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logoRightTop.Location = new System.Drawing.Point(-8, -1);
            this.pb_logoRightTop.Name = "pb_logoRightTop";
            this.pb_logoRightTop.Size = new System.Drawing.Size(71, 40);
            this.pb_logoRightTop.TabIndex = 10;
            this.pb_logoRightTop.TabStop = false;
            this.pb_logoRightTop.Click += new System.EventHandler(this.pb_logoRightTop_Click);
            // 
            // pb_pausePlay
            // 
            this.pb_pausePlay.BackgroundImage = global::MaestroMusic.Properties.Resources.pause_button;
            this.pb_pausePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pausePlay.Enabled = false;
            this.pb_pausePlay.Location = new System.Drawing.Point(387, 365);
            this.pb_pausePlay.Name = "pb_pausePlay";
            this.pb_pausePlay.Size = new System.Drawing.Size(31, 29);
            this.pb_pausePlay.TabIndex = 22;
            this.pb_pausePlay.TabStop = false;
            this.pb_pausePlay.Visible = false;
            this.pb_pausePlay.Click += new System.EventHandler(this.pb_pausePlay_Click);
            // 
            // lb_playlist
            // 
            this.lb_playlist.FormattingEnabled = true;
            this.lb_playlist.Location = new System.Drawing.Point(427, 108);
            this.lb_playlist.Name = "lb_playlist";
            this.lb_playlist.Size = new System.Drawing.Size(340, 238);
            this.lb_playlist.TabIndex = 25;
            // 
            // wmd_player
            // 
            this.wmd_player.Enabled = true;
            this.wmd_player.Location = new System.Drawing.Point(40, 108);
            this.wmd_player.Name = "wmd_player";
            this.wmd_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmd_player.OcxState")));
            this.wmd_player.Size = new System.Drawing.Size(262, 168);
            this.wmd_player.TabIndex = 26;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(73, 346);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(102, 23);
            this.btn_upload.TabIndex = 27;
            this.btn_upload.Text = "Upload Song";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // pb_next
            // 
            this.pb_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_next.BackgroundImage")));
            this.pb_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_next.Location = new System.Drawing.Point(424, 365);
            this.pb_next.Name = "pb_next";
            this.pb_next.Size = new System.Drawing.Size(31, 29);
            this.pb_next.TabIndex = 28;
            this.pb_next.TabStop = false;
            this.pb_next.Click += new System.EventHandler(this.pb_next_Click);
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_next);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.wmd_player);
            this.Controls.Add(this.lb_playlist);
            this.Controls.Add(this.pb_pausePlay);
            this.Controls.Add(this.pb_playPause);
            this.Controls.Add(this.lbl_length1);
            this.Controls.Add(this.lbl_length0);
            this.Controls.Add(this.prgsbar_songlength);
            this.Controls.Add(this.lbl_h1);
            this.Controls.Add(this.lbl_h2);
            this.Controls.Add(this.pb_logoRightTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Category";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.pb_playPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoRightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pausePlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmd_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_h2;
        private System.Windows.Forms.PictureBox pb_logoRightTop;
        private System.Windows.Forms.Label lbl_h1;
        private System.Windows.Forms.ProgressBar prgsbar_songlength;
        private System.Windows.Forms.Label lbl_length0;
        private System.Windows.Forms.Label lbl_length1;
        private System.Windows.Forms.PictureBox pb_playPause;
        private System.Windows.Forms.PictureBox pb_pausePlay;
        private System.Windows.Forms.ListBox lb_playlist;
        private AxWMPLib.AxWindowsMediaPlayer wmd_player;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.PictureBox pb_next;
    }
}