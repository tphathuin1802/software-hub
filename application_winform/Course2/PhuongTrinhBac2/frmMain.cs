using System.Security.Cryptography.Xml;

namespace PhuongTrinhBac2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn có chắc chắn muốn trốn khỏi phần mềm này không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHeSoA.Text = string.Empty;
            txtHeSoB.Text = string.Empty;
            txtHeSoC.Text = string.Empty;
            lblKetQua.Text = string.Empty;
            txtHeSoA.Focus();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            //txtHeSoA.Text-->"5"->double.Parse(txtHeSoA.Text)
            //->double.Parse("5")->5
            
            double a=double.Parse(txtHeSoA.Text);            
            double b=double.Parse(txtHeSoB.Text);
            double c=double.Parse(txtHeSoC.Text);


            if (a == 0)
            {   //bx+c=0
                if (b == 0 && c == 0)
                {
                    lblKetQua.Text = "Vô số nghiệm";
                }
                else if (b == 0 && c != 0)
                {
                    lblKetQua.Text = "Vô nghiệm";
                }
                else
                {
                    lblKetQua.Text = "x=" + (-c / b);
                }    
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lblKetQua.Text = "Vô nghiệm";
                }
                else if (delta == 0)
                {
                    lblKetQua.Text = "No kép x1=x2=" + (-b / (2 * a));
                }
                else
                {
                    double x1=(-b-Math.Sqrt(delta))/(2*a);
                    double x2=(-b+Math.Sqrt(delta))/(2*a);
                    lblKetQua.Text = "x1=" + x1 + ";x2=" + x2;
                }    
            }    
        }
    }
}
