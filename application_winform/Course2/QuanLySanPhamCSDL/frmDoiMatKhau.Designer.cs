namespace QuanLySanPhamCSDL
{
    partial class frmDoiMatKhau
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
            textBoxPasswordCu = new TextBox();
            label3 = new Label();
            textBoxPasswordMoi = new TextBox();
            label4 = new Label();
            textBoxPasswordMoiXacNhan = new TextBox();
            buttonHuy = new Button();
            buttonDoiMatKhau = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(146, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 46);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 69);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu cũ:";
            // 
            // textBoxPasswordCu
            // 
            textBoxPasswordCu.Font = new Font("Segoe UI", 15F);
            textBoxPasswordCu.Location = new Point(23, 111);
            textBoxPasswordCu.Name = "textBoxPasswordCu";
            textBoxPasswordCu.PasswordChar = '*';
            textBoxPasswordCu.Size = new Size(460, 41);
            textBoxPasswordCu.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(23, 162);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu mới:";
            // 
            // textBoxPasswordMoi
            // 
            textBoxPasswordMoi.Font = new Font("Segoe UI", 15F);
            textBoxPasswordMoi.Location = new Point(23, 204);
            textBoxPasswordMoi.Name = "textBoxPasswordMoi";
            textBoxPasswordMoi.PasswordChar = '*';
            textBoxPasswordMoi.Size = new Size(460, 41);
            textBoxPasswordMoi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 267);
            label4.Name = "label4";
            label4.Size = new Size(215, 28);
            label4.TabIndex = 5;
            label4.Text = "Nhập lại Mật khẩu mới:";
            // 
            // textBoxPasswordMoiXacNhan
            // 
            textBoxPasswordMoiXacNhan.Font = new Font("Segoe UI", 15F);
            textBoxPasswordMoiXacNhan.Location = new Point(23, 309);
            textBoxPasswordMoiXacNhan.Name = "textBoxPasswordMoiXacNhan";
            textBoxPasswordMoiXacNhan.PasswordChar = '*';
            textBoxPasswordMoiXacNhan.Size = new Size(460, 41);
            textBoxPasswordMoiXacNhan.TabIndex = 6;
            // 
            // buttonHuy
            // 
            buttonHuy.Font = new Font("Segoe UI", 15F);
            buttonHuy.Image = Properties.Resources.ic_thoat;
            buttonHuy.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHuy.Location = new Point(346, 373);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(121, 56);
            buttonHuy.TabIndex = 8;
            buttonHuy.Text = "Hủy";
            buttonHuy.TextAlign = ContentAlignment.MiddleRight;
            buttonHuy.UseVisualStyleBackColor = true;
            // 
            // buttonDoiMatKhau
            // 
            buttonDoiMatKhau.Font = new Font("Segoe UI", 15F);
            buttonDoiMatKhau.Image = Properties.Resources.ic_luu_doimatkhau;
            buttonDoiMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDoiMatKhau.Location = new Point(32, 373);
            buttonDoiMatKhau.Name = "buttonDoiMatKhau";
            buttonDoiMatKhau.Size = new Size(214, 56);
            buttonDoiMatKhau.TabIndex = 7;
            buttonDoiMatKhau.Text = "Đổi mật khẩu";
            buttonDoiMatKhau.TextAlign = ContentAlignment.MiddleRight;
            buttonDoiMatKhau.UseVisualStyleBackColor = true;
            buttonDoiMatKhau.Click += buttonDoiMatKhau_Click;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 452);
            Controls.Add(buttonHuy);
            Controls.Add(buttonDoiMatKhau);
            Controls.Add(textBoxPasswordMoiXacNhan);
            Controls.Add(textBoxPasswordMoi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPasswordCu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDoiMatKhau";
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxPasswordCu;
        private Label label3;
        private TextBox textBoxPasswordMoi;
        private Label label4;
        private TextBox textBoxPasswordMoiXacNhan;
        private Button buttonHuy;
        private Button buttonDoiMatKhau;
    }
}