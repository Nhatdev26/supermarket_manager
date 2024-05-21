namespace QuanLySieuThi
{
    partial class DangNhap
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.lb_MK = new System.Windows.Forms.Label();
            this.lb_TK = new System.Windows.Forms.Label();
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Thoat.Location = new System.Drawing.Point(181, 340);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(211, 53);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MatKhau.Location = new System.Drawing.Point(181, 263);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(438, 53);
            this.txt_MatKhau.TabIndex = 12;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TaiKhoan.Location = new System.Drawing.Point(181, 163);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(438, 53);
            this.txt_TaiKhoan.TabIndex = 11;
            // 
            // lb_MK
            // 
            this.lb_MK.AutoSize = true;
            this.lb_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lb_MK.Location = new System.Drawing.Point(186, 227);
            this.lb_MK.Name = "lb_MK";
            this.lb_MK.Size = new System.Drawing.Size(111, 26);
            this.lb_MK.TabIndex = 10;
            this.lb_MK.Text = "Mật Khẩu:";
            // 
            // lb_TK
            // 
            this.lb_TK.AutoSize = true;
            this.lb_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lb_TK.Location = new System.Drawing.Point(186, 127);
            this.lb_TK.Name = "lb_TK";
            this.lb_TK.Size = new System.Drawing.Size(116, 26);
            this.lb_TK.TabIndex = 9;
            this.lb_TK.Text = "Tài Khoản:";
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.AutoSize = true;
            this.lb_DangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.lb_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lb_DangNhap.Location = new System.Drawing.Point(302, 58);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.Size = new System.Drawing.Size(161, 33);
            this.lb_DangNhap.TabIndex = 8;
            this.lb_DangNhap.Text = "Đăng Nhập";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_DangNhap.Location = new System.Drawing.Point(398, 340);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(221, 53);
            this.btn_DangNhap.TabIndex = 15;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.lb_MK);
            this.Controls.Add(this.lb_TK);
            this.Controls.Add(this.lb_DangNhap);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label lb_MK;
        private System.Windows.Forms.Label lb_TK;
        private System.Windows.Forms.Label lb_DangNhap;
        private System.Windows.Forms.Button btn_DangNhap;
    }
}