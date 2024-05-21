namespace QuanLySieuThi
{
    partial class NhapHang
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
            this.groupBox_NhapHang = new System.Windows.Forms.GroupBox();
            this.cbb_NhanVien = new System.Windows.Forms.ComboBox();
            this.cbb_MaNCC = new System.Windows.Forms.ComboBox();
            this.lb_MaNCC = new System.Windows.Forms.Label();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lb_NgayNhap = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.lb_Mota = new System.Windows.Forms.Label();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.txt_MaPN = new System.Windows.Forms.TextBox();
            this.lb_MaPN = new System.Windows.Forms.Label();
            this.groupBox_PhieuNhap = new System.Windows.Forms.GroupBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.lb_TT = new System.Windows.Forms.Label();
            this.groupBox_ChiTiet = new System.Windows.Forms.GroupBox();
            this.dtgv_ChiTietHangNhap = new System.Windows.Forms.DataGridView();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.cbb_SanPham = new System.Windows.Forms.ComboBox();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.lb_SanPham = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox_NhapHang.SuspendLayout();
            this.groupBox_PhieuNhap.SuspendLayout();
            this.groupBox_ChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_NhapHang
            // 
            this.groupBox_NhapHang.Controls.Add(this.cbb_NhanVien);
            this.groupBox_NhapHang.Controls.Add(this.cbb_MaNCC);
            this.groupBox_NhapHang.Controls.Add(this.lb_MaNCC);
            this.groupBox_NhapHang.Controls.Add(this.dtp_NgayNhap);
            this.groupBox_NhapHang.Controls.Add(this.lb_NgayNhap);
            this.groupBox_NhapHang.Controls.Add(this.txt_GhiChu);
            this.groupBox_NhapHang.Controls.Add(this.lb_Mota);
            this.groupBox_NhapHang.Controls.Add(this.btn_LamMoi);
            this.groupBox_NhapHang.Controls.Add(this.btn_Xoa);
            this.groupBox_NhapHang.Controls.Add(this.btn_Sua);
            this.groupBox_NhapHang.Controls.Add(this.btn_Them);
            this.groupBox_NhapHang.Controls.Add(this.lb_NhanVien);
            this.groupBox_NhapHang.Controls.Add(this.txt_MaPN);
            this.groupBox_NhapHang.Controls.Add(this.lb_MaPN);
            this.groupBox_NhapHang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NhapHang.Location = new System.Drawing.Point(16, 12);
            this.groupBox_NhapHang.Name = "groupBox_NhapHang";
            this.groupBox_NhapHang.Size = new System.Drawing.Size(1305, 266);
            this.groupBox_NhapHang.TabIndex = 2;
            this.groupBox_NhapHang.TabStop = false;
            this.groupBox_NhapHang.Text = "Thông tin phiếu nhập";
            this.groupBox_NhapHang.Enter += new System.EventHandler(this.groupBox_NhapHang_Enter);
            // 
            // cbb_NhanVien
            // 
            this.cbb_NhanVien.FormattingEnabled = true;
            this.cbb_NhanVien.Location = new System.Drawing.Point(633, 40);
            this.cbb_NhanVien.Name = "cbb_NhanVien";
            this.cbb_NhanVien.Size = new System.Drawing.Size(473, 27);
            this.cbb_NhanVien.TabIndex = 48;
            // 
            // cbb_MaNCC
            // 
            this.cbb_MaNCC.FormattingEnabled = true;
            this.cbb_MaNCC.Location = new System.Drawing.Point(153, 89);
            this.cbb_MaNCC.Name = "cbb_MaNCC";
            this.cbb_MaNCC.Size = new System.Drawing.Size(337, 27);
            this.cbb_MaNCC.TabIndex = 47;
            // 
            // lb_MaNCC
            // 
            this.lb_MaNCC.AutoSize = true;
            this.lb_MaNCC.Location = new System.Drawing.Point(32, 92);
            this.lb_MaNCC.Name = "lb_MaNCC";
            this.lb_MaNCC.Size = new System.Drawing.Size(71, 19);
            this.lb_MaNCC.TabIndex = 46;
            this.lb_MaNCC.Text = "Mã NCC";
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(633, 86);
            this.dtp_NgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(251, 30);
            this.dtp_NgayNhap.TabIndex = 43;
            // 
            // lb_NgayNhap
            // 
            this.lb_NgayNhap.AutoSize = true;
            this.lb_NgayNhap.Location = new System.Drawing.Point(543, 92);
            this.lb_NgayNhap.Name = "lb_NgayNhap";
            this.lb_NgayNhap.Size = new System.Drawing.Size(88, 19);
            this.lb_NgayNhap.TabIndex = 42;
            this.lb_NgayNhap.Text = "Ngày nhập";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(153, 146);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(953, 100);
            this.txt_GhiChu.TabIndex = 26;
            // 
            // lb_Mota
            // 
            this.lb_Mota.AutoSize = true;
            this.lb_Mota.Location = new System.Drawing.Point(31, 149);
            this.lb_Mota.Name = "lb_Mota";
            this.lb_Mota.Size = new System.Drawing.Size(66, 19);
            this.lb_Mota.TabIndex = 25;
            this.lb_Mota.Text = "Ghi chú";
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.Location = new System.Drawing.Point(543, 43);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(81, 19);
            this.lb_NhanVien.TabIndex = 2;
            this.lb_NhanVien.Text = "Nhân viên";
            // 
            // txt_MaPN
            // 
            this.txt_MaPN.Location = new System.Drawing.Point(153, 39);
            this.txt_MaPN.Name = "txt_MaPN";
            this.txt_MaPN.Size = new System.Drawing.Size(337, 27);
            this.txt_MaPN.TabIndex = 1;
            // 
            // lb_MaPN
            // 
            this.lb_MaPN.AutoSize = true;
            this.lb_MaPN.Location = new System.Drawing.Point(31, 42);
            this.lb_MaPN.Name = "lb_MaPN";
            this.lb_MaPN.Size = new System.Drawing.Size(58, 19);
            this.lb_MaPN.TabIndex = 0;
            this.lb_MaPN.Text = "Mã PN";
            // 
            // groupBox_PhieuNhap
            // 
            this.groupBox_PhieuNhap.Controls.Add(this.txt_ThanhTien);
            this.groupBox_PhieuNhap.Controls.Add(this.lb_TT);
            this.groupBox_PhieuNhap.Controls.Add(this.groupBox_ChiTiet);
            this.groupBox_PhieuNhap.Controls.Add(this.txt_Gia);
            this.groupBox_PhieuNhap.Controls.Add(this.cbb_SanPham);
            this.groupBox_PhieuNhap.Controls.Add(this.lb_SoLuong);
            this.groupBox_PhieuNhap.Controls.Add(this.button2);
            this.groupBox_PhieuNhap.Controls.Add(this.button4);
            this.groupBox_PhieuNhap.Controls.Add(this.label3);
            this.groupBox_PhieuNhap.Controls.Add(this.txt_SoLuong);
            this.groupBox_PhieuNhap.Controls.Add(this.lb_SanPham);
            this.groupBox_PhieuNhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PhieuNhap.Location = new System.Drawing.Point(16, 284);
            this.groupBox_PhieuNhap.Name = "groupBox_PhieuNhap";
            this.groupBox_PhieuNhap.Size = new System.Drawing.Size(1310, 483);
            this.groupBox_PhieuNhap.TabIndex = 47;
            this.groupBox_PhieuNhap.TabStop = false;
            this.groupBox_PhieuNhap.Text = "Chi tiết phiếu nhập";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(1026, 437);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(260, 27);
            this.txt_ThanhTien.TabIndex = 50;
            this.txt_ThanhTien.Text = "0";
            // 
            // lb_TT
            // 
            this.lb_TT.AutoSize = true;
            this.lb_TT.Location = new System.Drawing.Point(919, 440);
            this.lb_TT.Name = "lb_TT";
            this.lb_TT.Size = new System.Drawing.Size(85, 19);
            this.lb_TT.TabIndex = 49;
            this.lb_TT.Text = "Thành tiền";
            // 
            // groupBox_ChiTiet
            // 
            this.groupBox_ChiTiet.Controls.Add(this.dtgv_ChiTietHangNhap);
            this.groupBox_ChiTiet.Location = new System.Drawing.Point(35, 84);
            this.groupBox_ChiTiet.Name = "groupBox_ChiTiet";
            this.groupBox_ChiTiet.Size = new System.Drawing.Size(1251, 337);
            this.groupBox_ChiTiet.TabIndex = 46;
            this.groupBox_ChiTiet.TabStop = false;
            this.groupBox_ChiTiet.Text = "Chi tiết";
            // 
            // dtgv_ChiTietHangNhap
            // 
            this.dtgv_ChiTietHangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ChiTietHangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChiTietHangNhap.Location = new System.Drawing.Point(25, 27);
            this.dtgv_ChiTietHangNhap.Name = "dtgv_ChiTietHangNhap";
            this.dtgv_ChiTietHangNhap.RowHeadersWidth = 51;
            this.dtgv_ChiTietHangNhap.RowTemplate.Height = 24;
            this.dtgv_ChiTietHangNhap.Size = new System.Drawing.Size(1202, 283);
            this.dtgv_ChiTietHangNhap.TabIndex = 0;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(778, 34);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(252, 27);
            this.txt_Gia.TabIndex = 45;
            // 
            // cbb_SanPham
            // 
            this.cbb_SanPham.FormattingEnabled = true;
            this.cbb_SanPham.Location = new System.Drawing.Point(132, 39);
            this.cbb_SanPham.Name = "cbb_SanPham";
            this.cbb_SanPham.Size = new System.Drawing.Size(260, 27);
            this.cbb_SanPham.TabIndex = 44;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(428, 42);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(77, 19);
            this.lb_SoLuong.TabIndex = 27;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(520, 34);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(120, 27);
            this.txt_SoLuong.TabIndex = 1;
            // 
            // lb_SanPham
            // 
            this.lb_SanPham.AutoSize = true;
            this.lb_SanPham.Location = new System.Drawing.Point(31, 42);
            this.lb_SanPham.Name = "lb_SanPham";
            this.lb_SanPham.Size = new System.Drawing.Size(83, 19);
            this.lb_SanPham.TabIndex = 0;
            this.lb_SanPham.Text = "Sản phẩm";
            // 
            // button2
            // 
            this.button2.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1183, 30);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(121, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::QuanLySieuThi.Properties.Resources.icons8_add_16;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1056, 30);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(121, 42);
            this.button4.TabIndex = 22;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::QuanLySieuThi.Properties.Resources.icons8_load_161;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(1134, 31);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_LamMoi.Size = new System.Drawing.Size(121, 42);
            this.btn_LamMoi.TabIndex = 21;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(1134, 204);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(121, 42);
            this.btn_Xoa.TabIndex = 24;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::QuanLySieuThi.Properties.Resources.icons8_edit_16;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(1134, 146);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(121, 42);
            this.btn_Sua.TabIndex = 23;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::QuanLySieuThi.Properties.Resources.icons8_add_16;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(1134, 89);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(121, 42);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 790);
            this.Controls.Add(this.groupBox_PhieuNhap);
            this.Controls.Add(this.groupBox_NhapHang);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.groupBox_NhapHang.ResumeLayout(false);
            this.groupBox_NhapHang.PerformLayout();
            this.groupBox_PhieuNhap.ResumeLayout(false);
            this.groupBox_PhieuNhap.PerformLayout();
            this.groupBox_ChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHangNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_NhapHang;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.Label lb_NgayNhap;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label lb_Mota;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.TextBox txt_MaPN;
        private System.Windows.Forms.Label lb_MaPN;
        private System.Windows.Forms.ComboBox cbb_MaNCC;
        private System.Windows.Forms.Label lb_MaNCC;
        private System.Windows.Forms.ComboBox cbb_NhanVien;
        private System.Windows.Forms.GroupBox groupBox_PhieuNhap;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label lb_TT;
        private System.Windows.Forms.GroupBox groupBox_ChiTiet;
        private System.Windows.Forms.DataGridView dtgv_ChiTietHangNhap;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.ComboBox cbb_SanPham;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lb_SanPham;
    }
}