namespace QuanLySanPhamCSDL
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            checkBoxLuuThongTin = new CheckBox();
            buttonDangNhap = new Button();
            buttonThoat = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(198, 9);
            label1.Name = "label1";
            label1.Size = new Size(346, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập hệ thống";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(198, 75);
            label2.Name = "label2";
            label2.Size = new Size(80, 35);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 15F);
            textBoxEmail.Location = new Point(199, 124);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(404, 41);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.Text = "huy@gmail.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(199, 168);
            label3.Name = "label3";
            label3.Size = new Size(125, 35);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 15F);
            textBoxPassword.Location = new Point(199, 218);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(404, 41);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.Text = "123";
            // 
            // checkBoxLuuThongTin
            // 
            checkBoxLuuThongTin.AutoSize = true;
            checkBoxLuuThongTin.Font = new Font("Segoe UI", 15F);
            checkBoxLuuThongTin.Location = new Point(202, 288);
            checkBoxLuuThongTin.Name = "checkBoxLuuThongTin";
            checkBoxLuuThongTin.Size = new Size(313, 39);
            checkBoxLuuThongTin.TabIndex = 5;
            checkBoxLuuThongTin.Text = "Lưu thông tin đăng nhập";
            checkBoxLuuThongTin.UseVisualStyleBackColor = true;
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.Font = new Font("Segoe UI", 15F);
            buttonDangNhap.Image = Properties.Resources.ic_dangnhap;
            buttonDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDangNhap.Location = new Point(202, 350);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(182, 56);
            buttonDangNhap.TabIndex = 6;
            buttonDangNhap.Text = "Đăng nhập";
            buttonDangNhap.TextAlign = ContentAlignment.MiddleRight;
            buttonDangNhap.UseVisualStyleBackColor = true;
            buttonDangNhap.Click += buttonDangNhap_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Font = new Font("Segoe UI", 15F);
            buttonThoat.Image = Properties.Resources.ic_thoat;
            buttonThoat.ImageAlign = ContentAlignment.MiddleLeft;
            buttonThoat.Location = new Point(470, 350);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(133, 56);
            buttonThoat.TabIndex = 7;
            buttonThoat.Text = "Thoát";
            buttonThoat.TextAlign = ContentAlignment.MiddleRight;
            buttonThoat.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ic_logo;
            pictureBox1.Location = new Point(16, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(657, 435);
            Controls.Add(pictureBox1);
            Controls.Add(buttonThoat);
            Controls.Add(buttonDangNhap);
            Controls.Add(checkBoxLuuThongTin);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxPassword;
        private CheckBox checkBoxLuuThongTin;
        private Button buttonDangNhap;
        private Button buttonThoat;
        private PictureBox pictureBox1;
    }
}