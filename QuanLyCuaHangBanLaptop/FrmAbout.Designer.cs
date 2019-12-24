namespace QuanLyCuaHangBanLaptop
{
    partial class FrmAbout
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
            this.lblGioiThieu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGioiThieu
            // 
            this.lblGioiThieu.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiThieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiThieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGioiThieu.Location = new System.Drawing.Point(0, 0);
            this.lblGioiThieu.Name = "lblGioiThieu";
            this.lblGioiThieu.Size = new System.Drawing.Size(631, 384);
            this.lblGioiThieu.TabIndex = 6;
            this.lblGioiThieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGioiThieu.Click += new System.EventHandler(this.lblGioiThieu_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 393);
            this.Controls.Add(this.lblGioiThieu);
            this.Name = "FrmAbout";
            this.Text = "FrmAbout";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGioiThieu;
    }
}