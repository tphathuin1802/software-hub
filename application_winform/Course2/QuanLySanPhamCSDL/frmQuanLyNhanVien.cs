using DAL;
using ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPhamCSDL
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        //khởi tạo 1 danh sách nhân viên rỗng:
        List<NhanVien> dsnv = new List<NhanVien>();
        //cần khởi tạo 1 Nhân viên Connector để tương tác bảng Nhân viên:
        NhanVienConnector nvc = new NhanVienConnector();
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dsnv = nvc.LayToanBoNhanVien();
            //HienThiNhanVienLenListView();
            HienThiNhanVienLenListView_PhanNhom();
        }
        void HienThiNhanVienLenListView()
        {
            //ta nên xóa toàn bộ dữ liệu trên giao diện ListView trước khi tải:
            listViewNhanVien.Items.Clear();
            for (int i = 0; i < dsnv.Count; i++)
            {
                //lấy từng nhân viên thứ i ra để nạp lên giao diện:
                NhanVien nv = dsnv[i];
                //Tạo 1 dòng giao diện cho ListView:
                //mặc định tạo ô đầu tiên cho 1 dòng
                ListViewItem lvi = new ListViewItem(nv.Id.ToString());
                //bắt đầu từ ô thứ 2 ta dùng lệnh:
                lvi.SubItems.Add(nv.MaNhanVien);
                lvi.SubItems.Add(nv.TenNhanVien);
                lvi.SubItems.Add(nv.Email);
                //lưu lại bộ nhớ trên thanh RAM tham chiếu vào lvi để xử lý sau:
                lvi.Tag = nv;

                if (nv.IsDeleted == 0)
                {
                    lvi.ForeColor = Color.Blue;
                }
                else if (nv.IsDeleted == 1)
                {
                    lvi.ForeColor = Color.Pink;
                }
                else if (nv.IsDeleted == 2)
                {
                    lvi.ForeColor = Color.DeepPink;
                }
                else if (nv.IsDeleted == 3)
                {
                    lvi.ForeColor = Color.Red;
                    lvi.Font = new Font("tahoma", 15, FontStyle.Strikeout);
                }
                //Sau đó đưa lvi lên ListView:
                listViewNhanVien.Items.Add(lvi);
            }
        }
        void HienThiNhanVienLenListView_PhanNhom()
        {
            //ta nên xóa toàn bộ dữ liệu trên giao diện ListView trước khi tải:
            listViewNhanVien.Items.Clear();
            listViewNhanVien.Groups.Clear();
            ListViewGroup lvg_danghoatdong = new ListViewGroup("Tài Khoản Đang Hoạt Động");
            ListViewGroup lvg_bixoavaothungrac = new ListViewGroup("Tài Khoản Đang Trong Thùng Rác");
            ListViewGroup lvg_bixoavinhvienroi = new ListViewGroup("Tài Khoản Bị Xóa Vĩnh Viễn Rồi");
            ListViewGroup lvg_bicamdangnhap = new ListViewGroup("Tài Khoản Bị Cấm Đăng Nhập");
            listViewNhanVien.Groups.Add(lvg_danghoatdong);
            listViewNhanVien.Groups.Add(lvg_bixoavaothungrac);
            listViewNhanVien.Groups.Add(lvg_bixoavinhvienroi);
            listViewNhanVien.Groups.Add(lvg_bicamdangnhap);

            for (int i = 0; i < dsnv.Count; i++)
            {
                //lấy từng nhân viên thứ i ra để nạp lên giao diện:
                NhanVien nv = dsnv[i];
                //Tạo 1 dòng giao diện cho ListView:
                //mặc định tạo ô đầu tiên cho 1 dòng
                ListViewItem lvi = new ListViewItem(nv.Id.ToString());
                //bắt đầu từ ô thứ 2 ta dùng lệnh:
                lvi.SubItems.Add(nv.MaNhanVien);
                lvi.SubItems.Add(nv.TenNhanVien);
                lvi.SubItems.Add(nv.Email);
                //lưu lại bộ nhớ trên thanh RAM tham chiếu vào lvi để xử lý sau:
                lvi.Tag = nv;
                if (nv.IsDeleted == 0)
                    lvi.Group = lvg_danghoatdong;
                else if (nv.IsDeleted == 1)
                    lvi.Group = lvg_bixoavaothungrac;
                else if (nv.IsDeleted == 2)
                    lvi.Group = lvg_bixoavinhvienroi;
                else if (nv.IsDeleted == 3)
                    lvi.Group = lvg_bicamdangnhap;

                if (nv.IsDeleted == 0)
                {
                    lvi.ForeColor = Color.Blue;
                }
                else if (nv.IsDeleted == 1)
                {
                    lvi.ForeColor = Color.Pink;
                }
                else if (nv.IsDeleted == 2)
                {
                    lvi.ForeColor = Color.DeepPink;
                }
                else if (nv.IsDeleted == 3)
                {
                    lvi.ForeColor = Color.Red;
                    lvi.Font = new Font("tahoma", 15, FontStyle.Strikeout);
                }
                //Sau đó đưa lvi lên ListView:
                listViewNhanVien.Items.Add(lvi);
            }
        }

        private void mnuThietLapTrangThaiKichHoatLai_Click(object sender, EventArgs e)
        {
            //Bước 1: Lấy được dòng ListViewItem đang chọn trên giao diện:
            if (listViewNhanVien.SelectedItems.Count == 0)
                return;//người dùng chưa chọn dòng Nhân viên nào thì dừng ko làm gì
            //lấy nhân viên đang chọn:
            ListViewItem lvi = listViewNhanVien.SelectedItems[0];
            NhanVien nv = lvi.Tag as NhanVien;
            bool ret = nvc.KichHoatLaiNhanVien(nv);
            if (ret)
            {
                //tải lại dữ liệu mới:
                dsnv = nvc.LayToanBoNhanVien();
                //hiển thị lại giao diện
                //HienThiNhanVienLenListView();
                HienThiNhanVienLenListView_PhanNhom();
            }
        }

        private void mnuDoiMatKhauNhanVien_Click(object sender, EventArgs e)
        {
            if (listViewNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn cần chọn nhân viên trước rồi mới đổi mật khẩu được");
                return;
            }
            ListViewItem selected_lvi = listViewNhanVien.SelectedItems[0];
            NhanVien nv = selected_lvi.Tag as NhanVien;
            frmDoiMatKhauTuQuanTri frm = new frmDoiMatKhauTuQuanTri();
            frm.idnhanvien = nv.Id;
            frm.Text = "Đổi mật khẩu cho [" + nv.TenNhanVien + "]";
            frm.ShowDialog();

        }

        private void listViewNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNhanVien.SelectedItems.Count == 0)
                return;
            ListViewItem lvi_selected = listViewNhanVien.SelectedItems[0];
            NhanVien nv = lvi_selected.Tag as NhanVien;
            textBoxID.Text = nv.Id.ToString();
            textBoxCode.Text = nv.MaNhanVien;
            textBoxTen.Text = nv.TenNhanVien;
            textBoxEmail.Text = nv.Email;
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxCode.Text = "";
            textBoxTen.Text = "";
            textBoxEmail.Text = "";
            textBoxCode.Focus();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien=textBoxCode.Text;
            nv.TenNhanVien=textBoxTen.Text;
            nv.Email=textBoxEmail.Text;
            nv.Password = "123";
            nv.IsDeleted = 3;
            bool kq=nvc.ThemMoiNhanVien(nv);
            if (kq == true)
            {
                dsnv = nvc.LayToanBoNhanVien();
                HienThiNhanVienLenListView_PhanNhom();
            }
        }
    }
}
