namespace QuanLySieuThi
{
    partial class TaiKhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.cb_Hien = new System.Windows.Forms.CheckBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_DanhSachTaiKhoan = new System.Windows.Forms.GroupBox();
            this.dtgv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox_DanhSachTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.cb_Hien);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1289, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài Khoản";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(490, 141);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(121, 42);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::QuanLySieuThi.Properties.Resources.icons8_edit_16;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(340, 141);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(121, 42);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::QuanLySieuThi.Properties.Resources.icons8_add_16;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(196, 141);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(121, 42);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::QuanLySieuThi.Properties.Resources.icons8_load_161;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(43, 141);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_LamMoi.Size = new System.Drawing.Size(121, 42);
            this.btn_LamMoi.TabIndex = 17;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // cb_Hien
            // 
            this.cb_Hien.AutoSize = true;
            this.cb_Hien.Location = new System.Drawing.Point(613, 90);
            this.cb_Hien.Name = "cb_Hien";
            this.cb_Hien.Size = new System.Drawing.Size(64, 23);
            this.cb_Hien.TabIndex = 4;
            this.cb_Hien.Text = "Hiện";
            this.cb_Hien.UseVisualStyleBackColor = true;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(196, 87);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(385, 27);
            this.txt_MatKhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(196, 42);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(385, 27);
            this.txt_TenDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // groupBox_DanhSachTaiKhoan
            // 
            this.groupBox_DanhSachTaiKhoan.Controls.Add(this.dtgv_TaiKhoan);
            this.groupBox_DanhSachTaiKhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanhSachTaiKhoan.Location = new System.Drawing.Point(12, 257);
            this.groupBox_DanhSachTaiKhoan.Name = "groupBox_DanhSachTaiKhoan";
            this.groupBox_DanhSachTaiKhoan.Size = new System.Drawing.Size(1291, 336);
            this.groupBox_DanhSachTaiKhoan.TabIndex = 25;
            this.groupBox_DanhSachTaiKhoan.TabStop = false;
            this.groupBox_DanhSachTaiKhoan.Text = "Danh sách tài khoản";
            // 
            // dtgv_TaiKhoan
            // 
            this.dtgv_TaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_TaiKhoan.Location = new System.Drawing.Point(25, 26);
            this.dtgv_TaiKhoan.Name = "dtgv_TaiKhoan";
            this.dtgv_TaiKhoan.RowHeadersWidth = 51;
            this.dtgv_TaiKhoan.RowTemplate.Height = 24;
            this.dtgv_TaiKhoan.Size = new System.Drawing.Size(1250, 304);
            this.dtgv_TaiKhoan.TabIndex = 0;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 600);
            this.Controls.Add(this.groupBox_DanhSachTaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_DanhSachTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_Hien;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.GroupBox groupBox_DanhSachTaiKhoan;
        private System.Windows.Forms.DataGridView dtgv_TaiKhoan;
    }
}