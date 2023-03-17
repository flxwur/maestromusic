namespace MaestroMusic
{
    partial class frm_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Player));
            this.lbl_h2 = new System.Windows.Forms.Label();
            this.lbl_h1 = new System.Windows.Forms.Label();
            this.pb_hardstyle = new System.Windows.Forms.PictureBox();
            this.pb_electronic = new System.Windows.Forms.PictureBox();
            this.pb_country = new System.Windows.Forms.PictureBox();
            this.pb_hiphop = new System.Windows.Forms.PictureBox();
            this.pb_pop = new System.Windows.Forms.PictureBox();
            this.pb_classical = new System.Windows.Forms.PictureBox();
            this.pb_logoRightTop = new System.Windows.Forms.PictureBox();
            this.pb_userIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hardstyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_electronic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_country)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hiphop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_classical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoRightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_h2
            // 
            this.lbl_h2.AutoSize = true;
            this.lbl_h2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h2.ForeColor = System.Drawing.Color.White;
            this.lbl_h2.Location = new System.Drawing.Point(47, 14);
            this.lbl_h2.Name = "lbl_h2";
            this.lbl_h2.Size = new System.Drawing.Size(166, 25);
            this.lbl_h2.TabIndex = 9;
            this.lbl_h2.Text = "Maestro Music";
            // 
            // lbl_h1
            // 
            this.lbl_h1.AutoSize = true;
            this.lbl_h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h1.ForeColor = System.Drawing.Color.White;
            this.lbl_h1.Location = new System.Drawing.Point(261, 50);
            this.lbl_h1.Name = "lbl_h1";
            this.lbl_h1.Size = new System.Drawing.Size(268, 25);
            this.lbl_h1.TabIndex = 10;
            this.lbl_h1.Text = "Your Taste. Your Music.";
            // 
            // pb_hardstyle
            // 
            this.pb_hardstyle.BackgroundImage = global::MaestroMusic.Properties.Resources.hardstyle;
            this.pb_hardstyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_hardstyle.Location = new System.Drawing.Point(496, 267);
            this.pb_hardstyle.Name = "pb_hardstyle";
            this.pb_hardstyle.Size = new System.Drawing.Size(125, 125);
            this.pb_hardstyle.TabIndex = 16;
            this.pb_hardstyle.TabStop = false;
            this.pb_hardstyle.Click += new System.EventHandler(this.pb_hardstyle_Click);
            // 
            // pb_electronic
            // 
            this.pb_electronic.BackgroundImage = global::MaestroMusic.Properties.Resources.electronic;
            this.pb_electronic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_electronic.Location = new System.Drawing.Point(333, 267);
            this.pb_electronic.Name = "pb_electronic";
            this.pb_electronic.Size = new System.Drawing.Size(125, 125);
            this.pb_electronic.TabIndex = 15;
            this.pb_electronic.TabStop = false;
            this.pb_electronic.Click += new System.EventHandler(this.pb_electronic_Click);
            // 
            // pb_country
            // 
            this.pb_country.BackgroundImage = global::MaestroMusic.Properties.Resources.country;
            this.pb_country.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_country.Location = new System.Drawing.Point(165, 267);
            this.pb_country.Name = "pb_country";
            this.pb_country.Size = new System.Drawing.Size(125, 125);
            this.pb_country.TabIndex = 14;
            this.pb_country.TabStop = false;
            this.pb_country.Click += new System.EventHandler(this.pb_country_Click);
            // 
            // pb_hiphop
            // 
            this.pb_hiphop.BackgroundImage = global::MaestroMusic.Properties.Resources.hiphop1;
            this.pb_hiphop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_hiphop.Location = new System.Drawing.Point(496, 110);
            this.pb_hiphop.Name = "pb_hiphop";
            this.pb_hiphop.Size = new System.Drawing.Size(125, 125);
            this.pb_hiphop.TabIndex = 13;
            this.pb_hiphop.TabStop = false;
            this.pb_hiphop.Click += new System.EventHandler(this.pb_hiphop_Click);
            // 
            // pb_pop
            // 
            this.pb_pop.BackgroundImage = global::MaestroMusic.Properties.Resources.pop;
            this.pb_pop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pop.Location = new System.Drawing.Point(333, 110);
            this.pb_pop.Name = "pb_pop";
            this.pb_pop.Size = new System.Drawing.Size(125, 125);
            this.pb_pop.TabIndex = 12;
            this.pb_pop.TabStop = false;
            this.pb_pop.Click += new System.EventHandler(this.pb_pop_Click);
            // 
            // pb_classical
            // 
            this.pb_classical.BackgroundImage = global::MaestroMusic.Properties.Resources.classical;
            this.pb_classical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_classical.Location = new System.Drawing.Point(165, 110);
            this.pb_classical.Name = "pb_classical";
            this.pb_classical.Size = new System.Drawing.Size(125, 125);
            this.pb_classical.TabIndex = 11;
            this.pb_classical.TabStop = false;
            this.pb_classical.Click += new System.EventHandler(this.pb_classical_Click);
            this.pb_classical.MouseHover += new System.EventHandler(this.pb_classical_MouseHover);
            // 
            // pb_logoRightTop
            // 
            this.pb_logoRightTop.BackColor = System.Drawing.Color.Transparent;
            this.pb_logoRightTop.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_logo_png1;
            this.pb_logoRightTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logoRightTop.Location = new System.Drawing.Point(-10, 4);
            this.pb_logoRightTop.Name = "pb_logoRightTop";
            this.pb_logoRightTop.Size = new System.Drawing.Size(71, 40);
            this.pb_logoRightTop.TabIndex = 8;
            this.pb_logoRightTop.TabStop = false;
            // 
            // pb_userIcon
            // 
            this.pb_userIcon.BackColor = System.Drawing.Color.Transparent;
            this.pb_userIcon.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_user_white;
            this.pb_userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_userIcon.Location = new System.Drawing.Point(766, 12);
            this.pb_userIcon.Name = "pb_userIcon";
            this.pb_userIcon.Size = new System.Drawing.Size(22, 23);
            this.pb_userIcon.TabIndex = 17;
            this.pb_userIcon.TabStop = false;
            this.pb_userIcon.Click += new System.EventHandler(this.pb_userIcon_Click);
            // 
            // frm_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_userIcon);
            this.Controls.Add(this.pb_hardstyle);
            this.Controls.Add(this.pb_electronic);
            this.Controls.Add(this.pb_country);
            this.Controls.Add(this.pb_hiphop);
            this.Controls.Add(this.pb_pop);
            this.Controls.Add(this.pb_classical);
            this.Controls.Add(this.lbl_h1);
            this.Controls.Add(this.lbl_h2);
            this.Controls.Add(this.pb_logoRightTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Player";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.pb_hardstyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_electronic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_country)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hiphop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_classical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoRightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logoRightTop;
        private System.Windows.Forms.Label lbl_h2;
        private System.Windows.Forms.Label lbl_h1;
        private System.Windows.Forms.PictureBox pb_classical;
        private System.Windows.Forms.PictureBox pb_pop;
        private System.Windows.Forms.PictureBox pb_hiphop;
        private System.Windows.Forms.PictureBox pb_hardstyle;
        private System.Windows.Forms.PictureBox pb_electronic;
        private System.Windows.Forms.PictureBox pb_country;
        private System.Windows.Forms.PictureBox pb_userIcon;
    }
}