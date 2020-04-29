namespace QuanLyBanHang
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dmHàng = new System.Windows.Forms.ToolStripMenuItem();
            this.dMHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMLoaiHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dmHàng,
            this.hóaĐơnBánToolStripMenuItem,
            this.hóaĐơnNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dmHàng
            // 
            this.dmHàng.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dMHangToolStripMenuItem,
            this.dMLoaiHangToolStripMenuItem});
            this.dmHàng.Name = "dmHàng";
            this.dmHàng.Size = new System.Drawing.Size(112, 24);
            this.dmHàng.Text = "QL Danh Mục";
          
            // 
            // dMHangToolStripMenuItem
            // 
            this.dMHangToolStripMenuItem.Name = "dMHangToolStripMenuItem";
            this.dMHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dMHangToolStripMenuItem.Text = "DMHang";
            this.dMHangToolStripMenuItem.Click += new System.EventHandler(this.dMHangToolStripMenuItem_Click);
            // 
            // dMLoaiHangToolStripMenuItem
            // 
            this.dMLoaiHangToolStripMenuItem.Name = "dMLoaiHangToolStripMenuItem";
            this.dMLoaiHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dMLoaiHangToolStripMenuItem.Text = "DMLoaiHang";
            this.dMLoaiHangToolStripMenuItem.Click += new System.EventHandler(this.dMLoaiHangToolStripMenuItem_Click);
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa đơn bán";
            // 
            // hóaĐơnNhậpToolStripMenuItem
            // 
            this.hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
            this.hóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.hóaĐơnNhậpToolStripMenuItem.Text = "Hóa đơn nhập";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dmHàng;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMLoaiHangToolStripMenuItem;
    }
}