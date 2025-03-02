namespace QuanLySanPham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtGia = new TextBox();
            label4 = new Label();
            txtSoluong = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtMa = new TextBox();
            label1 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuuMoi = new Button();
            btnThemmoi = new Button();
            groupBox3 = new GroupBox();
            lvSanPham = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuHeThongLuuFileBinary = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuHeThongDocFileBinary = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuHeThongThoat = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem4 = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoluong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 269);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết sản phẩm:";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(161, 211);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(446, 41);
            txtGia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 211);
            label4.Name = "label4";
            label4.Size = new Size(56, 35);
            label4.TabIndex = 6;
            label4.Text = "Giá:";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(161, 155);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(446, 41);
            txtSoluong.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 155);
            label3.Name = "label3";
            label3.Size = new Size(120, 35);
            label3.TabIndex = 4;
            label3.Text = "Số lượng:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(161, 106);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(446, 41);
            txtTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 106);
            label2.Name = "label2";
            label2.Size = new Size(58, 35);
            label2.TabIndex = 2;
            label2.Text = "Tên:";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(161, 59);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(446, 41);
            txtMa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 59);
            label1.Name = "label1";
            label1.Size = new Size(55, 35);
            label1.TabIndex = 0;
            label1.Text = "Mã:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(169, 9);
            label5.Name = "label5";
            label5.Size = new Size(305, 46);
            label5.TabIndex = 0;
            label5.Text = "Quản lý sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLuuMoi);
            groupBox2.Controls.Add(btnThemmoi);
            groupBox2.Location = new Point(27, 344);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(792, 106);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn chức năng:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(612, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(149, 55);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(423, 40);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(149, 55);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuuMoi
            // 
            btnLuuMoi.Location = new Point(237, 40);
            btnLuuMoi.Name = "btnLuuMoi";
            btnLuuMoi.Size = new Size(149, 55);
            btnLuuMoi.TabIndex = 1;
            btnLuuMoi.Text = "Lưu mới";
            btnLuuMoi.UseVisualStyleBackColor = true;
            btnLuuMoi.Click += btnLuuMoi_Click;
            // 
            // btnThemmoi
            // 
            btnThemmoi.Location = new Point(41, 40);
            btnThemmoi.Name = "btnThemmoi";
            btnThemmoi.Size = new Size(149, 55);
            btnThemmoi.TabIndex = 0;
            btnThemmoi.Text = "Thêm mới";
            btnThemmoi.UseVisualStyleBackColor = true;
            btnThemmoi.Click += btnThemmoi_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lvSanPham);
            groupBox3.Location = new Point(33, 472);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(797, 394);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm:";
            // 
            // lvSanPham
            // 
            lvSanPham.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvSanPham.Dock = DockStyle.Fill;
            lvSanPham.FullRowSelect = true;
            lvSanPham.GridLines = true;
            lvSanPham.Location = new Point(3, 37);
            lvSanPham.Name = "lvSanPham";
            lvSanPham.Size = new Size(791, 354);
            lvSanPham.TabIndex = 0;
            lvSanPham.UseCompatibleStateImageBehavior = false;
            lvSanPham.View = View.Details;
            lvSanPham.SelectedIndexChanged += lvSanPham_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã SP";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Sản Phẩm";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giá Sản phẩm";
            columnHeader4.Width = 200;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(876, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuHeThongLuuFileBinary, toolStripMenuItem1, mnuHeThongDocFileBinary, toolStripSeparator1, toolStripMenuItem3, toolStripSeparator2, toolStripMenuItem4, toolStripMenuItem2, mnuHeThongThoat });
            mnuHeThong.Image = Properties.Resources.ic_hethong;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(105, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuHeThongLuuFileBinary
            // 
            mnuHeThongLuuFileBinary.Image = Properties.Resources.ic_savefile;
            mnuHeThongLuuFileBinary.Name = "mnuHeThongLuuFileBinary";
            mnuHeThongLuuFileBinary.Size = new Size(224, 26);
            mnuHeThongLuuFileBinary.Text = "Lưu File Binary";
            mnuHeThongLuuFileBinary.Click += mnuHeThongLuuFileBinary_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // mnuHeThongDocFileBinary
            // 
            mnuHeThongDocFileBinary.Image = Properties.Resources.ic_readfile;
            mnuHeThongDocFileBinary.Name = "mnuHeThongDocFileBinary";
            mnuHeThongDocFileBinary.Size = new Size(224, 26);
            mnuHeThongDocFileBinary.Text = "Đọc File Binary";
            mnuHeThongDocFileBinary.Click += mnuHeThongDocFileBinary_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(224, 26);
            toolStripMenuItem3.Text = "Lưu Json File";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 6);
            // 
            // mnuHeThongThoat
            // 
            mnuHeThongThoat.Image = Properties.Resources.ic_thoat;
            mnuHeThongThoat.Name = "mnuHeThongThoat";
            mnuHeThongThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuHeThongThoat.Size = new Size(224, 26);
            mnuHeThongThoat.Text = "Thoát";
            mnuHeThongThoat.Click += mnuHeThongThoat_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(224, 26);
            toolStripMenuItem4.Text = "Đọc Json File";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 891);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 15F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtGia;
        private Label label4;
        private TextBox txtSoluong;
        private Label label3;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtMa;
        private Label label1;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnThemmoi;
        private Button btnLuuMoi;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox groupBox3;
        private ListView lvSanPham;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuHeThongLuuFileBinary;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuHeThongDocFileBinary;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuHeThongThoat;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}
