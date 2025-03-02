using ObjectModel;
using FileProcessingLibrary;
namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SanPham x = new SanPham();

        List<SanPham> sanPhams = new List<SanPham>();

        List<SanPham> teo = new List<SanPham>();

        List<Customer> customer = new List<Customer>();

        #region các hàm xử lý trên Form

        //PYTHON: sanPhams =List<SanPham>();
        void GiaLapDuLieu()
        {
            sanPhams.Clear();
            sanPhams.Add(new SanPham()
            {
                Ma = "SP1",
                Ten = "Thuốc trị hội nách",
                SoLuong = 10,
                Gia = 100
            }
                        );
            sanPhams.Add(new SanPham() { Ma = "SP2", Ten = "Thuốc trị lang beeng", SoLuong = 5, Gia = 30 });
            sanPhams.Add(new SanPham() { Ma = "SP3", Ten = "Thuốc trị xàm", SoLuong = 70, Gia = 20 });
            sanPhams.Add(new SanPham() { Ma = "SP4", Ten = "Thuốc trị ghẻ", SoLuong = 7, Gia = 25 });
            sanPhams.Add(new SanPham() { Ma = "SP5", Ten = "Thuốc trị lazy", SoLuong = 20, Gia = 40 });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*GiaLapDuLieu();
            HienThiSanPhamLenListView();*/
        }
        void HienThiSanPhamLenListView()
        {
            //Bước 1: Xóa dữ liệu cũ trên giao diện Listview đi
            //(vì có thể nó được tải lại nhiều lần, ta phải lấy dữ liệu cuối cùng mới nhất)
            lvSanPham.Items.Clear();
            foreach (SanPham sp in sanPhams)
            {
                //tạo 1 dòng cho Listview, nó gọi là ListviewItem:
                ListViewItem lvi = new ListViewItem(sp.Ma);//ô đầu tiên của dòng
                lvi.Tag = sp;//lưu lại đối tượng đang quản lý ô nhớ trên thanh RAM vào thuộc tính Tag
                             //để ta truy lục lại cho dễ
                lvi.SubItems.Add(sp.Ten);
                lvi.SubItems.Add(sp.SoLuong.ToString());
                lvi.SubItems.Add(sp.Gia.ToString());
                //đưa listviewitem lên listview:
                lvSanPham.Items.Add(lvi);
            }
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bước 1: Lấy ra các dòng đang chọn trên giao diện:
            if (lvSanPham.SelectedItems.Count == 0)
                return;//ko làm gì vì chưa chọn gì
            //Bước 2: Vì thông thường ta chỉ quan tâm tới 1 dòng đang chọn:
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            //Bước 3: Lấy đối tượng được lưu trong thuộc tính Tag để xử lý:
            SanPham sp = (SanPham)lvi.Tag;
            //Bước 4: Hiển thị sản phẩm lên giao diện:
            txtMa.Text = sp.Ma;
            txtTen.Text = sp.Ten;
            txtSoluong.Text = sp.SoLuong.ToString();
            txtGia.Text = sp.Gia.ToString();

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            //xóa dữ liệu cũ trên giao diện đi:
            txtMa.Text = "";
            txtTen.Clear();
            txtSoluong.Text = string.Empty;
            txtGia.Text = string.Empty;
            //thiết lập con trỏ văn bản vào ô mã:
            txtMa.Focus();
        }
        bool KiemTraMaTrungNhau(string msp)
        {
            for (int i = 0; i < sanPhams.Count; i = i + 1)
            {
                //dùng index để lấy từng phần tử thứ i ra:
                SanPham p = sanPhams[i];
                if (p.Ma == msp)
                {
                    return true;
                }
            }
            return false;
        }
        bool KiemTraMaTrungNhau2(string msp)
        {
            foreach (SanPham p in sanPhams)
            {
                if (p.Ma == msp)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnLuuMoi_Click(object sender, EventArgs e)
        {
            //Tạo 1 sản phẩm mới trong ô nhớ (trên thanh RAM):
            SanPham p = new SanPham();
            //thay đổi các giá trị cho các thuộc tính của p:
            p.Ma = txtMa.Text;
            p.Ten = txtTen.Text;
            p.SoLuong = int.Parse(txtSoluong.Text);
            p.Gia = double.Parse(txtGia.Text);
            bool kt_trung = KiemTraMaTrungNhau(p.Ma);
            if (kt_trung)
            {
                MessageBox.Show("Mã bị trùng rồi Thím ơi!");
                return;//dừng hàm ko làm gì tiếp theo cả vì mã đã trùng
            }
            //nối đuôi ô nhớ mà p đang quản lý vào dãy ô nhớ mà sanPhams đang quản lý
            //nói ngắn gọn: thêm mới p vào sanPhams
            sanPhams.Add(p);
            //hiển thị lại dữ liệu lên giao diện ListView:
            HienThiSanPhamLenListView();
        }
        SanPham TimSanPhamTheoMa(string msp)
        {
            foreach (SanPham p in sanPhams)
            {
                if (p.Ma == msp)
                {
                    return p;//trả về sản phẩm p được tìm thấy
                }
            }
            return null;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //bắt buộc phải lấy được đối tượng đang chọn ra:
            //thường là chúng ta dùng chức năng tìm kiếm theo mã để truy suất
            //lại ô nhớ mà đối tượng đó đang quản lý trên thanh RAM

            SanPham p = TimSanPhamTheoMa(txtMa.Text);
            if (p == null)
            {
                MessageBox.Show(
                    "Không tìm thấy mã [" + txtMa.Text + "] để sửa",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;//ko làm gì cả nữa vì ko tìm thấy
            }
            //vì p đang trỏ tới ô nhớ mà ta muốn sửa
            //thì giờ chỉ cần đổi giá trị của p thì tự nhiên ô nhớ đó sẽ biết (bị ảnh hưởng)
            p.Ten = txtTen.Text;
            p.SoLuong = int.Parse(txtSoluong.Text);
            p.Gia = double.Parse(txtGia.Text);
            //hiển thị lại dữ liệu trên thanh RAM lên giao diện:
            HienThiSanPhamLenListView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPham p = TimSanPhamTheoMa(txtMa.Text);
            if (p == null)
            {
                MessageBox.Show(
                    "Không tìm thấy mã [" + txtMa.Text + "] để xóa",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;//ko làm gì cả nữa vì ko tìm thấy
            }
            //phải xác nhận có muốn xóa hay không:
            DialogResult ret = MessageBox.Show(
                "Bạn có muốn xóa sản phẩm [" + txtMa.Text + "] này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.No)
            {
                return;//chọn NO thì ko xóa, ngừng hàm
            }
            sanPhams.Remove(p);//xóa ô nhớ mà p đang quản lý khỏi dãy ô nhớ trong sanPhams
            //hiển thị lại:
            HienThiSanPhamLenListView();
            //sau đó ra lệnh cho nút Thêm mới thực hiện tự động:
            btnThemmoi.PerformClick();
        }
        #endregion
        private void mnuHeThongThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Ê muốn thoát hả?",
                "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void mnuHeThongLuuFileBinary_Click(object sender, EventArgs e)
        {
            string filename = "mydata.dat";
            BinaryFileFactory bff = new BinaryFileFactory();

            bool kq = bff.SaveData(sanPhams, filename);
            if (kq)
            {
                MessageBox.Show("Đã lưu dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Lưu file lỗi tùm lum tùm la");
            }
        }

        private void mnuHeThongDocFileBinary_Click(object sender, EventArgs e)
        {
            string filename = "mydata.dat";
            BinaryFileFactory bff = new BinaryFileFactory();
            object data = bff.ReadData(filename);
            if (data != null)
            {
                //ép dữ liệu trong bộ nhớ mới nạp lên từ Ổ cứng về List<SanPham>
                sanPhams = data as List<SanPham>;
            }
            else
            {
                //trỏ tới ô nhớ mới rỗng
                sanPhams = new List<SanPham>();
            }
            HienThiSanPhamLenListView();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string filename = "mydata.json";
            JSonFileFactory jff = new JSonFileFactory();
            bool kq = jff.SaveData(sanPhams, filename);
            if (kq)
            {
                MessageBox.Show("Đã lưu dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Lưu file lỗi tùm lum tùm la");
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string filename = "mydata.json";
            JSonFileFactory jff = new JSonFileFactory();
            object data=jff.ReadData<List<SanPham>>(filename);
            sanPhams=data as List<SanPham>;
            if (sanPhams==null)
                sanPhams=new List<SanPham>();
            HienThiSanPhamLenListView();
        }
    }
}
