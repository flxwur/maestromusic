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
            this.pb_playBTN = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_logoRightTop = new System.Windows.Forms.PictureBox();
            this.pb_pausePlay = new System.Windows.Forms.PictureBox();
            this.lbl_songName = new System.Windows.Forms.Label();
            this.lbl_songLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoRightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pausePlay)).BeginInit();
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
            // pb_playBTN
            // 
            this.pb_playBTN.BackgroundImage = global::MaestroMusic.Properties.Resources.play_icon2;
            this.pb_playBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_playBTN.Location = new System.Drawing.Point(208, 125);
            this.pb_playBTN.Name = "pb_playBTN";
            this.pb_playBTN.Size = new System.Drawing.Size(22, 21);
            this.pb_playBTN.TabIndex = 17;
            this.pb_playBTN.TabStop = false;
            this.pb_playBTN.Click += new System.EventHandler(this.pb_playBTN_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::MaestroMusic.Properties.Resources.songbox;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(197, 245);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(548, 37);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MaestroMusic.Properties.Resources.songbox;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(197, 202);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(548, 37);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MaestroMusic.Properties.Resources.songbox;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(197, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(548, 37);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MaestroMusic.Properties.Resources.songbox;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(197, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 37);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            // lbl_songName
            // 
            this.lbl_songName.AutoSize = true;
            this.lbl_songName.ForeColor = System.Drawing.Color.White;
            this.lbl_songName.Location = new System.Drawing.Point(235, 129);
            this.lbl_songName.Name = "lbl_songName";
            this.lbl_songName.Size = new System.Drawing.Size(227, 13);
            this.lbl_songName.TabIndex = 23;
            this.lbl_songName.Text = "John Denver - Take Me Home, Country Roads";
            // 
            // lbl_songLength
            // 
            this.lbl_songLength.AutoSize = true;
            this.lbl_songLength.ForeColor = System.Drawing.Color.White;
            this.lbl_songLength.Location = new System.Drawing.Point(703, 129);
            this.lbl_songLength.Name = "lbl_songLength";
            this.lbl_songLength.Size = new System.Drawing.Size(28, 13);
            this.lbl_songLength.TabIndex = 24;
            this.lbl_songLength.Text = "4:22";
            // 
            // frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_songLength);
            this.Controls.Add(this.lbl_songName);
            this.Controls.Add(this.pb_pausePlay);
            this.Controls.Add(this.pb_playPause);
            this.Controls.Add(this.lbl_length1);
            this.Controls.Add(this.lbl_length0);
            this.Controls.Add(this.prgsbar_songlength);
            this.Controls.Add(this.pb_playBTN);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_h1);
            this.Controls.Add(this.lbl_h2);
            this.Controls.Add(this.pb_logoRightTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Category";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.pb_playPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_playBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoRightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pausePlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_h2;
        private System.Windows.Forms.PictureBox pb_logoRightTop;
        private System.Windows.Forms.Label lbl_h1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pb_playBTN;
        private System.Windows.Forms.ProgressBar prgsbar_songlength;
        private System.Windows.Forms.Label lbl_length0;
        private System.Windows.Forms.Label lbl_length1;
        private System.Windows.Forms.PictureBox pb_playPause;
        private System.Windows.Forms.PictureBox pb_pausePlay;
        private System.Windows.Forms.Label lbl_songName;
        private System.Windows.Forms.Label lbl_songLength;
    }
}