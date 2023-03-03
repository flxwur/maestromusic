namespace MaestroMusic
{
    partial class Close
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Close));
            this.lbl_close = new System.Windows.Forms.Label();
            this.btn_doClose = new System.Windows.Forms.Button();
            this.btn_noClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(157, 25);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(136, 22);
            this.lbl_close.TabIndex = 0;
            this.lbl_close.Text = "Are you sure?";
            // 
            // btn_doClose
            // 
            this.btn_doClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doClose.ForeColor = System.Drawing.Color.White;
            this.btn_doClose.Location = new System.Drawing.Point(125, 79);
            this.btn_doClose.Name = "btn_doClose";
            this.btn_doClose.Size = new System.Drawing.Size(80, 25);
            this.btn_doClose.TabIndex = 1;
            this.btn_doClose.Text = "YES";
            this.btn_doClose.UseVisualStyleBackColor = true;
            this.btn_doClose.Click += new System.EventHandler(this.btn_doClose_Click);
            // 
            // btn_noClose
            // 
            this.btn_noClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_noClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(48)))), ((int)(((byte)(253)))));
            this.btn_noClose.Location = new System.Drawing.Point(245, 79);
            this.btn_noClose.Name = "btn_noClose";
            this.btn_noClose.Size = new System.Drawing.Size(80, 25);
            this.btn_noClose.TabIndex = 2;
            this.btn_noClose.Text = "NO";
            this.btn_noClose.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.btn_noClose);
            this.Controls.Add(this.btn_doClose);
            this.Controls.Add(this.lbl_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Close";
            this.Text = "Close";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Button btn_doClose;
        private System.Windows.Forms.Button btn_noClose;
    }
}