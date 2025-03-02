using ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPhamCSDL
{
    public partial class frmMain : Form
    {
        //Tạo 1 thuộc tính LoginNhanVien
        //để lưu trữ thông tin từ màn hình Đăng nhập truyền qua
        //thuộc tính static --> chia sẻ cho toàn bộ hệ thống, sài chung ô nhớ
        public static NhanVien LoginNhanVien { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelNhanVien.Text = "Xin chào [" + LoginNhanVien.TenNhanVien + "]";
        }

        private void mnuHeThongDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void mnuQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm= new frmQuanLyNhanVien();
            frm.Show();
        }
    }
}
