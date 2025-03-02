using DAL;
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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            //Bước 1: Phải thực hiện đăng nhập với mật khẩu cũ trước
            //Nếu đăng nhập thành công mới cho đổi mật khẩu.
            //Vì sao: Vì tránh HACK, hệ thống ta đang mở, có ai đó cố tình đổi mật khẩu
            //khi ta không ngồi trên máy.

            NhanVienConnector nvc = new NhanVienConnector();
            NhanVien loginNv = nvc.DangNhap(frmMain.LoginNhanVien.Email, textBoxPasswordCu.Text);
            if (loginNv != null)
            {
                //Bước 2: Tiến hành đổi mật khẩu mới:
                //bắt buộc mật khẩu mới và ô xác nhận lại mật khẩu nó phải giống nhau

                if (textBoxPasswordMoi.Text != textBoxPasswordMoiXacNhan.Text)
                {
                    MessageBox.Show("Bạn phải xác nhận chính xác mật khẩu mới");
                    return;//bắt quay lại nhập lại mật khẩu mới xác nhận cho giống nhau
                }
                //đổi mật khẩu mới cho nhân viên trong màn hình này:
                frmMain.LoginNhanVien.Password=textBoxPasswordMoi.Text;
                //tiến hành thay đổi mật khẩu thực sự trong CSDL:
                bool ret=nvc.DoiMatKhau(frmMain.LoginNhanVien);
                if (ret)
                {
                    MessageBox.Show("Chúc mừng, bạn đã đổi mật khẩu mới thành công");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu mới thất bại");
                }    
            }   
            else
            {
                MessageBox.Show("Bạn không thể đổi mật khẩu mới được, vì mật khẩu cũ bạn nhập sai. " +
                    "Hay là bạn muốn Hack tài khoản của ai vậy?");
            }    
        }
    }
}
