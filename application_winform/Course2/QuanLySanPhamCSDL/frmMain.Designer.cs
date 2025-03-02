namespace QuanLySanPhamCSDL
{
    partial class frmMain
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuHeThongThongTinTaiKhoan = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuHeThongDoiMatKhau = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuHeThongThoatPhanMem = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuQuanLyNhanVien = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelNhanVien = new ToolStripStatusLabel();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(373, 44);
            label1.Name = "label1";
            label1.Size = new Size(392, 40);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý bán hàng";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1096, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuHeThongThongTinTaiKhoan, toolStripMenuItem1, mnuHeThongDoiMatKhau, toolStripMenuItem2, mnuHeThongThoatPhanMem });
            mnuHeThong.Image = Properties.Resources.ic_hethong;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(94, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuHeThongThongTinTaiKhoan
            // 
            mnuHeThongThongTinTaiKhoan.Image = Properties.Resources.ic_thongtin;
            mnuHeThongThongTinTaiKhoan.Name = "mnuHeThongThongTinTaiKhoan";
            mnuHeThongThongTinTaiKhoan.Size = new Size(190, 24);
            mnuHeThongThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(187, 6);
            // 
            // mnuHeThongDoiMatKhau
            // 
            mnuHeThongDoiMatKhau.Image = Properties.Resources.ic_doimatkhau;
            mnuHeThongDoiMatKhau.Name = "mnuHeThongDoiMatKhau";
            mnuHeThongDoiMatKhau.Size = new Size(190, 24);
            mnuHeThongDoiMatKhau.Text = "Đổi mật khẩu";
            mnuHeThongDoiMatKhau.Click += mnuHeThongDoiMatKhau_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(187, 6);
            // 
            // mnuHeThongThoatPhanMem
            // 
            mnuHeThongThoatPhanMem.Image = Properties.Resources.ic_thoat;
            mnuHeThongThoatPhanMem.Name = "mnuHeThongThoatPhanMem";
            mnuHeThongThoatPhanMem.Size = new Size(190, 24);
            mnuHeThongThoatPhanMem.Text = "Thoát phần mềm";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLyNhanVien, sảnPhẩmToolStripMenuItem });
            mnuQuanLy.Image = Properties.Resources.ic_quan;
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(84, 24);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuQuanLyNhanVien
            // 
            mnuQuanLyNhanVien.Image = Properties.Resources.ic_nhanvien;
            mnuQuanLyNhanVien.Name = "mnuQuanLyNhanVien";
            mnuQuanLyNhanVien.Size = new Size(191, 26);
            mnuQuanLyNhanVien.Text = "Nhân viên";
            mnuQuanLyNhanVien.Click += mnuQuanLyNhanVien_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelNhanVien });
            statusStrip1.Location = new Point(0, 675);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1096, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelNhanVien
            // 
            toolStripStatusLabelNhanVien.Name = "toolStripStatusLabelNhanVien";
            toolStripStatusLabelNhanVien.Size = new Size(131, 17);
            toolStripStatusLabelNhanVien.Text = "toolStripStatusLabel1";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(191, 26);
            sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 697);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Hệ thống quản trị Bán hàng Lớp 10K";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuHeThongThongTinTaiKhoan;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuHeThongDoiMatKhau;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuHeThongThoatPhanMem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelNhanVien;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuQuanLyNhanVien;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
    }
}