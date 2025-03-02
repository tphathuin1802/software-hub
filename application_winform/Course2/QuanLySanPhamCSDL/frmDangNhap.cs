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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            NhanVienConnector nvc=new NhanVienConnector();
            NhanVien loginNv=nvc.DangNhap(textBoxEmail.Text,textBoxPassword.Text);
            if (loginNv != null) 
            {
                if(loginNv.IsDeleted==3)
                {
                    MessageBox.Show("Tài khoản này đã bị cấm đăng nhập vào hệ thống. Vui lòng liên hệ Admin");
                    return;
                }
                if (loginNv.IsDeleted == 1 || loginNv.IsDeleted == 2)
                {
                    MessageBox.Show("Tài khoản này không tồn tại trong hệ thống");
                    return;
                }

                MessageBox.Show("Đăng nhập thành công");
                //lưu lại địa chỉ ô nhớ của loginNv 
                frmMain.LoginNhanVien=loginNv;

                //Dòng lệnh DialogResult = DialogResult.Ok==> có ý nghĩa:
                //Đóng cửa sổ hiện tại này (cửa sổ đăng nhập này)
                //và trả về giá trị là DialogResult.OK
                //giá trị DialogResult.OK được lưu vào thuộc tính tên là DialogResult 
                DialogResult = DialogResult.OK;
                //Như vậy chỗ nào gọi hàm đăng nhập mà nó trả về DialogResult.OK
                //==>thì là đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }    
        }
    }
}
