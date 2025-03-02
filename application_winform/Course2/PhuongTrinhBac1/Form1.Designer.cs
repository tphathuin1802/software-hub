namespace PhuongTrinhBac1
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
            label1 = new Label();
            label2 = new Label();
            txtHeSoA = new TextBox();
            label3 = new Label();
            txtHeSoB = new TextBox();
            label4 = new Label();
            txtKetQua = new TextBox();
            btnGiai = new Button();
            btnTiep = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("UVN Mau Tim 2", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(201, 21);
            label1.Name = "label1";
            label1.Size = new Size(246, 46);
            label1.TabIndex = 0;
            label1.Text = "Phương trình bậc 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(38, 100);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 1;
            label2.Text = "Hệ số a:";
            // 
            // txtHeSoA
            // 
            txtHeSoA.Font = new Font("Segoe UI", 14F);
            txtHeSoA.Location = new Point(154, 100);
            txtHeSoA.Name = "txtHeSoA";
            txtHeSoA.Size = new Size(432, 39);
            txtHeSoA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(38, 159);
            label3.Name = "label3";
            label3.Size = new Size(101, 32);
            label3.TabIndex = 3;
            label3.Text = "Hệ số b:";
            // 
            // txtHeSoB
            // 
            txtHeSoB.Font = new Font("Segoe UI", 14F);
            txtHeSoB.Location = new Point(154, 159);
            txtHeSoB.Name = "txtHeSoB";
            txtHeSoB.Size = new Size(432, 39);
            txtHeSoB.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(38, 221);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 5;
            label4.Text = "Kết qủa:";
            // 
            // txtKetQua
            // 
            txtKetQua.Font = new Font("Segoe UI", 14F);
            txtKetQua.Location = new Point(154, 221);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(432, 39);
            txtKetQua.TabIndex = 6;
            // 
            // btnGiai
            // 
            btnGiai.Font = new Font("Segoe UI", 14F);
            btnGiai.Image = Properties.Resources.ic_giai;
            btnGiai.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiai.Location = new Point(160, 279);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(101, 49);
            btnGiai.TabIndex = 7;
            btnGiai.Text = "Giải";
            btnGiai.TextAlign = ContentAlignment.MiddleRight;
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // btnTiep
            // 
            btnTiep.Font = new Font("Segoe UI", 14F);
            btnTiep.Image = Properties.Resources.ic_tiep;
            btnTiep.ImageAlign = ContentAlignment.MiddleLeft;
            btnTiep.Location = new Point(319, 279);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(103, 49);
            btnTiep.TabIndex = 8;
            btnTiep.Text = "Tiếp";
            btnTiep.TextAlign = ContentAlignment.MiddleRight;
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 14F);
            btnThoat.Image = Properties.Resources.ic_exit;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(472, 279);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 49);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AcceptButton = btnGiai;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(655, 353);
            Controls.Add(btnThoat);
            Controls.Add(btnTiep);
            Controls.Add(btnGiai);
            Controls.Add(txtKetQua);
            Controls.Add(label4);
            Controls.Add(txtHeSoB);
            Controls.Add(label3);
            Controls.Add(txtHeSoA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Phương Trình Bậc 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHeSoA;
        private Label label3;
        private TextBox txtHeSoB;
        private Label label4;
        private TextBox txtKetQua;
        private Button btnGiai;
        private Button btnTiep;
        private Button btnThoat;
    }
}
