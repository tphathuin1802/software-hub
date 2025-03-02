namespace QuanLySanPhamCSDL
{
    partial class frmQuanLyNhanVien
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            listViewNhanVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnuThongTinNhanVienChiTiet = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuDoiMatKhauNhanVien = new ToolStripMenuItem();
            ậtKToolStripMenuItem = new ToolStripSeparator();
            mnuThietLapTrangThai = new ToolStripMenuItem();
            mnuThietLapTrangThaiKichHoatLai = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuThietLapTrangThaiXoaVaoThungRac = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThietLapTrangThaiXoaVinhVien = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            mnuThietLapTrangThaiCamNhanVienDangNhap = new ToolStripMenuItem();
            splitter1 = new Splitter();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            panel5 = new Panel();
            buttonXoa = new Button();
            buttonLuu = new Button();
            buttonThemMoi = new Button();
            textBoxEmail = new TextBox();
            label5 = new Label();
            textBoxTen = new TextBox();
            label4 = new Label();
            textBoxCode = new TextBox();
            label3 = new Label();
            textBoxID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1463, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1463, 76);
            label1.TabIndex = 0;
            label1.Text = "Chức năng quản lý Nhân Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 255);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 801);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 801);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 192);
            panel3.Controls.Add(listViewNhanVien);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(711, 761);
            panel3.TabIndex = 0;
            // 
            // listViewNhanVien
            // 
            listViewNhanVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewNhanVien.ContextMenuStrip = contextMenuStrip1;
            listViewNhanVien.Dock = DockStyle.Fill;
            listViewNhanVien.FullRowSelect = true;
            listViewNhanVien.GridLines = true;
            listViewNhanVien.Location = new Point(0, 0);
            listViewNhanVien.Name = "listViewNhanVien";
            listViewNhanVien.Size = new Size(711, 761);
            listViewNhanVien.TabIndex = 0;
            listViewNhanVien.UseCompatibleStateImageBehavior = false;
            listViewNhanVien.View = View.Details;
            listViewNhanVien.SelectedIndexChanged += listViewNhanVien_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã Nhân Viên";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên Nhân Viên";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mnuThongTinNhanVienChiTiet, toolStripMenuItem1, mnuDoiMatKhauNhanVien, ậtKToolStripMenuItem, mnuThietLapTrangThai });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(274, 88);
            // 
            // mnuThongTinNhanVienChiTiet
            // 
            mnuThongTinNhanVienChiTiet.Name = "mnuThongTinNhanVienChiTiet";
            mnuThongTinNhanVienChiTiet.Size = new Size(273, 24);
            mnuThongTinNhanVienChiTiet.Text = "Thông tin nhân viên chi tiết";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(270, 6);
            // 
            // mnuDoiMatKhauNhanVien
            // 
            mnuDoiMatKhauNhanVien.Name = "mnuDoiMatKhauNhanVien";
            mnuDoiMatKhauNhanVien.Size = new Size(273, 24);
            mnuDoiMatKhauNhanVien.Text = "Đổi mật khẩu cho nhân viên";
            mnuDoiMatKhauNhanVien.Click += mnuDoiMatKhauNhanVien_Click;
            // 
            // ậtKToolStripMenuItem
            // 
            ậtKToolStripMenuItem.Name = "ậtKToolStripMenuItem";
            ậtKToolStripMenuItem.Size = new Size(270, 6);
            // 
            // mnuThietLapTrangThai
            // 
            mnuThietLapTrangThai.DropDownItems.AddRange(new ToolStripItem[] { mnuThietLapTrangThaiKichHoatLai, toolStripMenuItem2, mnuThietLapTrangThaiXoaVaoThungRac, toolStripSeparator1, mnuThietLapTrangThaiXoaVinhVien, toolStripMenuItem3, mnuThietLapTrangThaiCamNhanVienDangNhap });
            mnuThietLapTrangThai.Name = "mnuThietLapTrangThai";
            mnuThietLapTrangThai.Size = new Size(273, 24);
            mnuThietLapTrangThai.Text = "Thiết lập Trạng thái nhân viên";
            // 
            // mnuThietLapTrangThaiKichHoatLai
            // 
            mnuThietLapTrangThaiKichHoatLai.Name = "mnuThietLapTrangThaiKichHoatLai";
            mnuThietLapTrangThaiKichHoatLai.Size = new Size(279, 26);
            mnuThietLapTrangThaiKichHoatLai.Text = "Kích hoạt lại nhân viên";
            mnuThietLapTrangThaiKichHoatLai.Click += mnuThietLapTrangThaiKichHoatLai_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(276, 6);
            // 
            // mnuThietLapTrangThaiXoaVaoThungRac
            // 
            mnuThietLapTrangThaiXoaVaoThungRac.Name = "mnuThietLapTrangThaiXoaVaoThungRac";
            mnuThietLapTrangThaiXoaVaoThungRac.Size = new Size(279, 26);
            mnuThietLapTrangThaiXoaVaoThungRac.Text = "Xóa nhân viên vào thùng rác";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(276, 6);
            // 
            // mnuThietLapTrangThaiXoaVinhVien
            // 
            mnuThietLapTrangThaiXoaVinhVien.Name = "mnuThietLapTrangThaiXoaVinhVien";
            mnuThietLapTrangThaiXoaVinhVien.Size = new Size(279, 26);
            mnuThietLapTrangThaiXoaVinhVien.Text = "Xóa vĩnh viên nhân viên";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(276, 6);
            // 
            // mnuThietLapTrangThaiCamNhanVienDangNhap
            // 
            mnuThietLapTrangThaiCamNhanVienDangNhap.Name = "mnuThietLapTrangThaiCamNhanVienDangNhap";
            mnuThietLapTrangThaiCamNhanVienDangNhap.Size = new Size(279, 26);
            mnuThietLapTrangThaiCamNhanVienDangNhap.Text = "Cấm Nhân viên đăng nhập";
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.RosyBrown;
            splitter1.Location = new Point(717, 76);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 801);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 192);
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(727, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(736, 801);
            panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel5);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 15F);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(736, 441);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 224, 192);
            panel5.Controls.Add(buttonXoa);
            panel5.Controls.Add(buttonLuu);
            panel5.Controls.Add(buttonThemMoi);
            panel5.Controls.Add(textBoxEmail);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBoxTen);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBoxCode);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBoxID);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(730, 401);
            panel5.TabIndex = 0;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(527, 317);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(175, 62);
            buttonXoa.TabIndex = 2;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonLuu
            // 
            buttonLuu.Location = new Point(309, 314);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(175, 62);
            buttonLuu.TabIndex = 2;
            buttonLuu.Text = "Lưu dữ liệu";
            buttonLuu.UseVisualStyleBackColor = true;
            buttonLuu.Click += buttonLuu_Click;
            // 
            // buttonThemMoi
            // 
            buttonThemMoi.Location = new Point(135, 314);
            buttonThemMoi.Name = "buttonThemMoi";
            buttonThemMoi.Size = new Size(135, 62);
            buttonThemMoi.TabIndex = 2;
            buttonThemMoi.Text = "Thêm mới";
            buttonThemMoi.UseVisualStyleBackColor = true;
            buttonThemMoi.Click += buttonThemMoi_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(132, 257);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(547, 41);
            textBoxEmail.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 251);
            label5.Name = "label5";
            label5.Size = new Size(80, 35);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(132, 172);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(547, 41);
            textBoxTen.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 166);
            label4.Name = "label4";
            label4.Size = new Size(58, 35);
            label4.TabIndex = 0;
            label4.Text = "Tên:";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(132, 93);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(547, 41);
            textBoxCode.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 87);
            label3.Name = "label3";
            label3.Size = new Size(84, 35);
            label3.TabIndex = 0;
            label3.Text = "CODE:";
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(132, 27);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(547, 41);
            textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 21);
            label2.Name = "label2";
            label2.Size = new Size(45, 35);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // frmQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 877);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmQuanLyNhanVien";
            Text = "Quản lý Nhân Viên";
            Load += frmQuanLyNhanVien_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Panel panel3;
        private ListView listViewNhanVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuThongTinNhanVienChiTiet;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuDoiMatKhauNhanVien;
        private ToolStripSeparator ậtKToolStripMenuItem;
        private ToolStripMenuItem mnuThietLapTrangThai;
        private ToolStripMenuItem mnuThietLapTrangThaiKichHoatLai;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuThietLapTrangThaiXoaVaoThungRac;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThietLapTrangThaiXoaVinhVien;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuThietLapTrangThaiCamNhanVienDangNhap;
        private Splitter splitter1;
        private Panel panel4;
        private GroupBox groupBox2;
        private Panel panel5;
        private Label label2;
        private TextBox textBoxCode;
        private Label label3;
        private TextBox textBoxID;
        private TextBox textBoxTen;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label5;
        private Button buttonThemMoi;
        private Button buttonLuu;
        private Button buttonXoa;
    }
}