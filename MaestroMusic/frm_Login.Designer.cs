namespace MaestroMusic
{
    partial class frm_Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.lbl_register1 = new System.Windows.Forms.Label();
            this.lbl_registerLink = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pb_pswdIcon = new System.Windows.Forms.PictureBox();
            this.pb_userIcon = new System.Windows.Forms.PictureBox();
            this.pb_userBorder = new System.Windows.Forms.PictureBox();
            this.pb_passwordBorder = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pswdIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_passwordBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Black;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tb_username.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_username.Location = new System.Drawing.Point(163, 181);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(91, 18);
            this.tb_username.TabIndex = 0;
            this.tb_username.Text = "username";
            // 
            // tb_pw
            // 
            this.tb_pw.BackColor = System.Drawing.Color.Black;
            this.tb_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pw.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tb_pw.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_pw.Location = new System.Drawing.Point(163, 224);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(91, 18);
            this.tb_pw.TabIndex = 1;
            this.tb_pw.Text = "password";
            // 
            // lbl_register1
            // 
            this.lbl_register1.AutoSize = true;
            this.lbl_register1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_register1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lbl_register1.ForeColor = System.Drawing.Color.White;
            this.lbl_register1.Location = new System.Drawing.Point(116, 402);
            this.lbl_register1.Name = "lbl_register1";
            this.lbl_register1.Size = new System.Drawing.Size(103, 14);
            this.lbl_register1.TabIndex = 8;
            this.lbl_register1.Text = "Du hast kein Konto?";
            // 
            // lbl_registerLink
            // 
            this.lbl_registerLink.AutoSize = true;
            this.lbl_registerLink.BackColor = System.Drawing.Color.Transparent;
            this.lbl_registerLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registerLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(61)))), ((int)(((byte)(242)))));
            this.lbl_registerLink.Location = new System.Drawing.Point(216, 402);
            this.lbl_registerLink.Name = "lbl_registerLink";
            this.lbl_registerLink.Size = new System.Drawing.Size(65, 14);
            this.lbl_registerLink.TabIndex = 9;
            this.lbl_registerLink.Text = "Registrieren";
            this.lbl_registerLink.Click += new System.EventHandler(this.lbl_registerLink_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_logo_png1;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logo.Location = new System.Drawing.Point(108, 43);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(176, 80);
            this.pb_logo.TabIndex = 7;
            this.pb_logo.TabStop = false;
            // 
            // pb_pswdIcon
            // 
            this.pb_pswdIcon.BackColor = System.Drawing.Color.Transparent;
            this.pb_pswdIcon.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_paswd_white;
            this.pb_pswdIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pswdIcon.Location = new System.Drawing.Point(135, 219);
            this.pb_pswdIcon.Name = "pb_pswdIcon";
            this.pb_pswdIcon.Size = new System.Drawing.Size(22, 23);
            this.pb_pswdIcon.TabIndex = 6;
            this.pb_pswdIcon.TabStop = false;
            // 
            // pb_userIcon
            // 
            this.pb_userIcon.BackColor = System.Drawing.Color.Transparent;
            this.pb_userIcon.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_user_white;
            this.pb_userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_userIcon.Location = new System.Drawing.Point(135, 179);
            this.pb_userIcon.Name = "pb_userIcon";
            this.pb_userIcon.Size = new System.Drawing.Size(22, 23);
            this.pb_userIcon.TabIndex = 5;
            this.pb_userIcon.TabStop = false;
            // 
            // pb_userBorder
            // 
            this.pb_userBorder.BackColor = System.Drawing.Color.Transparent;
            this.pb_userBorder.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_user_bg;
            this.pb_userBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_userBorder.Location = new System.Drawing.Point(131, 172);
            this.pb_userBorder.Name = "pb_userBorder";
            this.pb_userBorder.Size = new System.Drawing.Size(132, 37);
            this.pb_userBorder.TabIndex = 3;
            this.pb_userBorder.TabStop = false;
            // 
            // pb_passwordBorder
            // 
            this.pb_passwordBorder.BackColor = System.Drawing.Color.Transparent;
            this.pb_passwordBorder.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_user_bg;
            this.pb_passwordBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_passwordBorder.Location = new System.Drawing.Point(131, 214);
            this.pb_passwordBorder.Name = "pb_passwordBorder";
            this.pb_passwordBorder.Size = new System.Drawing.Size(132, 37);
            this.pb_passwordBorder.TabIndex = 10;
            this.pb_passwordBorder.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Underline);
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(170, 292);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(49, 19);
            this.lbl_login.TabIndex = 11;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            this.lbl_login.MouseEnter += new System.EventHandler(this.frm_Login_Hover);
            this.lbl_login.MouseLeave += new System.EventHandler(this.frm_Login_HoverOff);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MaestroMusic.Properties.Resources.rl_bglogin1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_registerLink);
            this.Controls.Add(this.lbl_register1);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.pb_pswdIcon);
            this.Controls.Add(this.pb_userIcon);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.pb_userBorder);
            this.Controls.Add(this.pb_passwordBorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pswdIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_passwordBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.PictureBox pb_userBorder;
        private System.Windows.Forms.PictureBox pb_userIcon;
        private System.Windows.Forms.PictureBox pb_pswdIcon;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lbl_register1;
        private System.Windows.Forms.Label lbl_registerLink;
        private System.Windows.Forms.PictureBox pb_passwordBorder;
        private System.Windows.Forms.Label lbl_login;
    }
}

