namespace QuanLySanPhamCSDL
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
            listBoxDanhMuc = new ListBox();
            buttonTaiDanhMuc = new Button();
            dataGridViewSanPham = new DataGridView();
            buttonTaiSanPham = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanPham).BeginInit();
            SuspendLayout();
            // 
            // listBoxDanhMuc
            // 
            listBoxDanhMuc.FormattingEnabled = true;
            listBoxDanhMuc.Location = new Point(58, 86);
            listBoxDanhMuc.Name = "listBoxDanhMuc";
            listBoxDanhMuc.Size = new Size(219, 284);
            listBoxDanhMuc.TabIndex = 0;
            // 
            // buttonTaiDanhMuc
            // 
            buttonTaiDanhMuc.Location = new Point(65, 28);
            buttonTaiDanhMuc.Name = "buttonTaiDanhMuc";
            buttonTaiDanhMuc.Size = new Size(196, 29);
            buttonTaiDanhMuc.TabIndex = 1;
            buttonTaiDanhMuc.Text = "Tải danh mục";
            buttonTaiDanhMuc.UseVisualStyleBackColor = true;
            buttonTaiDanhMuc.Click += buttonTaiDanhMuc_Click;
            // 
            // dataGridViewSanPham
            // 
            dataGridViewSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSanPham.Location = new Point(363, 94);
            dataGridViewSanPham.Name = "dataGridViewSanPham";
            dataGridViewSanPham.RowHeadersWidth = 51;
            dataGridViewSanPham.Size = new Size(650, 276);
            dataGridViewSanPham.TabIndex = 2;
            // 
            // buttonTaiSanPham
            // 
            buttonTaiSanPham.Location = new Point(537, 32);
            buttonTaiSanPham.Name = "buttonTaiSanPham";
            buttonTaiSanPham.Size = new Size(228, 42);
            buttonTaiSanPham.TabIndex = 3;
            buttonTaiSanPham.Text = "Tải Sản Phẩm";
            buttonTaiSanPham.UseVisualStyleBackColor = true;
            buttonTaiSanPham.Click += buttonTaiSanPham_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 480);
            Controls.Add(buttonTaiSanPham);
            Controls.Add(dataGridViewSanPham);
            Controls.Add(buttonTaiDanhMuc);
            Controls.Add(listBoxDanhMuc);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxDanhMuc;
        private Button buttonTaiDanhMuc;
        private DataGridView dataGridViewSanPham;
        private Button buttonTaiSanPham;
    }
}
