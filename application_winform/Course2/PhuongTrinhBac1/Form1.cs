namespace PhuongTrinhBac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHeSoA.Text = "";
            txtHeSoB.Text = "";
            txtKetQua.Text = string.Empty;
            txtHeSoA.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double hsa=double.Parse(txtHeSoA.Text);
            double hsb=double.Parse(txtHeSoB.Text);
            if (hsa == 0 && hsb == 0)
            {
                txtKetQua.Text = "Vô số nghiệm";
            }
            else if (hsa == 0 && hsb != 0)
            {
                txtKetQua.Text = "Vô nghiệm";
            }
            else
            {
                txtKetQua.Text = "x=" + (-hsb / hsa);
            }
        }
    }
}
