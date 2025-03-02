namespace PhuongTrinhBac2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtHeSoC = new TextBox();
            label4 = new Label();
            txtHeSoB = new TextBox();
            label3 = new Label();
            txtHeSoA = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnTiep = new Button();
            btnGiai = new Button();
            groupBox3 = new GroupBox();
            lblKetQua = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(195, 27);
            label1.Name = "label1";
            label1.Size = new Size(241, 35);
            label1.TabIndex = 0;
            label1.Text = "Phương trình bậc 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHeSoC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHeSoB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHeSoA);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(42, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 234);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập các hệ số của phương trình:";
            // 
            // txtHeSoC
            // 
            txtHeSoC.Location = new Point(134, 176);
            txtHeSoC.Name = "txtHeSoC";
            txtHeSoC.Size = new Size(386, 41);
            txtHeSoC.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 176);
            label4.Name = "label4";
            label4.Size = new Size(103, 35);
            label4.TabIndex = 4;
            label4.Text = "Hệ số c:";
            // 
            // txtHeSoB
            // 
            txtHeSoB.Location = new Point(134, 110);
            txtHeSoB.Name = "txtHeSoB";
            txtHeSoB.Size = new Size(386, 41);
            txtHeSoB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 110);
            label3.Name = "label3";
            label3.Size = new Size(106, 35);
            label3.TabIndex = 2;
            label3.Text = "Hệ số b:";
            // 
            // txtHeSoA
            // 
            txtHeSoA.Location = new Point(134, 51);
            txtHeSoA.Name = "txtHeSoA";
            txtHeSoA.Size = new Size(386, 41);
            txtHeSoA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 51);
            label2.Name = "label2";
            label2.Size = new Size(104, 35);
            label2.TabIndex = 0;
            label2.Text = "Hệ số a:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnTiep);
            groupBox2.Controls.Add(btnGiai);
            groupBox2.Font = new Font("Segoe UI", 15F);
            groupBox2.Location = new Point(42, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(585, 113);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn chức năng:";
            // 
            // btnThoat
            // 
            btnThoat.Image = Properties.Resources.ic_exit;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(395, 40);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(172, 64);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTiep
            // 
            btnTiep.Image = Properties.Resources.ic_tiep;
            btnTiep.ImageAlign = ContentAlignment.MiddleLeft;
            btnTiep.Location = new Point(213, 43);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(172, 64);
            btnTiep.TabIndex = 1;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnGiai
            // 
            btnGiai.Image = Properties.Resources.ic_giai;
            btnGiai.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiai.Location = new Point(22, 43);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(172, 64);
            btnGiai.TabIndex = 0;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblKetQua);
            groupBox3.Font = new Font("Segoe UI", 15F);
            groupBox3.Location = new Point(42, 464);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(585, 104);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả giải phương trình:";
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = Color.FromArgb(255, 255, 128);
            lblKetQua.Location = new Point(22, 37);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(555, 52);
            lblKetQua.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 608);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phương Trình Bậc 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtHeSoC;
        private Label label4;
        private TextBox txtHeSoB;
        private Label label3;
        private TextBox txtHeSoA;
        private GroupBox groupBox2;
        private Button btnGiai;
        private Button btnThoat;
        private Button btnTiep;
        private GroupBox groupBox3;
        private Label lblKetQua;
    }
}
