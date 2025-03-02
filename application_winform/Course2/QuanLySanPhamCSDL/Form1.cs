using DAL;
using ObjectModel;

namespace QuanLySanPhamCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTaiDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucConnector dmc = new DanhMucConnector();
            List<DanhMuc> dsdm = dmc.LayToanBoDanhMuc();
            listBoxDanhMuc.DataSource = dsdm;
            listBoxDanhMuc.ValueMember = "MaDanhMuc";
            listBoxDanhMuc.DisplayMember = "TenDanhMuc";
        }

        private void buttonTaiSanPham_Click(object sender, EventArgs e)
        {
            SanPhamConnector spc=new SanPhamConnector();
            List<SanPham> dssp=spc.LayToanBoSanPham();
            dataGridViewSanPham.DataSource = dssp;
        }
    }
}
