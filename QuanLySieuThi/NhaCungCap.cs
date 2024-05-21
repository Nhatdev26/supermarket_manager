using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLySieuThi
{
    public partial class NhaCungCap : Form
    {
        
        public string chuoi = "Select * from NhaCungCap";
        
        public NhaCungCap()
        {
            InitializeComponent();
            
            KetNoiSQL.KhoiTaoBang(chuoi, dtgv_NhaCungCap);
            KetNoiSQL.Chuoiketnoi(chuoi, dtgv_NhaCungCap);

            if(KetNoiSQL.dt != null && KetNoiSQL.dt.Rows.Count > 0)
            {
                TenBang();
            }
            else
            {
                MessageBox.Show("Dtgv_NhaCungCap không có dữ liệu !", "Lỗi", MessageBoxButtons.OK);
            }

        }

        public void TenBang()
        {
                dtgv_NhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";               
                dtgv_NhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";               
                dtgv_NhaCungCap.Columns[2].HeaderText = "Địa chỉ";             
                dtgv_NhaCungCap.Columns[3].HeaderText = "Điện thoại";    
                dtgv_NhaCungCap.Columns[4].HeaderText = "Email";
                     
        }




        private void btn_Them_Click(object sender, EventArgs e)
        {
           

            String maNhaCC = dtgv_NhaCungCap.Rows[0].Cells[0].Value.ToString();
           


            if (txt_MaNhaCC.Text == "" || txt_TenNhaCC.Text == "" || txt_DiaChi.Text == "" || txt_DienThoai.Text == "" || txt_Email.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Lỗi", MessageBoxButtons.OK);
            }
            else if (txt_MaNhaCC.Text == maNhaCC)
            {
                MessageBox.Show("Thông tin của bạn bị trùng !", "Lỗi", MessageBoxButtons.OK);
            }
            else 
            { 
                    string sql1 = "Insert into NhaCungCap values('" + txt_MaNhaCC.Text+ "','" + txt_TenNhaCC.Text + "','" + txt_DiaChi.Text + "',N'" + txt_DienThoai.Text + "', '" + txt_Email.Text + "')";
                    KetNoiSQL.Them(sql1, dtgv_NhaCungCap);

                    KetNoiSQL.Chuoiketnoi(chuoi, dtgv_NhaCungCap);
                    TenBang();
                    Clear();
            
            }

               
                
            
        }
        public void Clear()
        {
            txt_MaNhaCC.Text = "";
            txt_TenNhaCC.Text = "";
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            txt_Email.Text = "";
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            KetNoiSQL.LamMoi("Select * from NhaCungCap", dtgv_NhaCungCap);
        }

        private void dtgv_NhaCungCap_Click(object sender, EventArgs e)
        {
            int chiMuc = dtgv_NhaCungCap.CurrentRow.Index;

            txt_MaNhaCC.Text = dtgv_NhaCungCap.Rows[chiMuc].Cells[0].Value.ToString();
            txt_TenNhaCC.Text = dtgv_NhaCungCap.Rows[chiMuc].Cells[1].Value.ToString();
            txt_DiaChi.Text = dtgv_NhaCungCap.Rows[chiMuc].Cells[2].Value.ToString();
            txt_DienThoai.Text = dtgv_NhaCungCap.Rows[chiMuc].Cells[3].Value.ToString();
            txt_Email.Text = dtgv_NhaCungCap.Rows[chiMuc].Cells[4].Value.ToString();

            TenBang();  
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update NhaCungCap set tenNhaCC = '" + txt_TenNhaCC.Text + "',diaCHi = N'" + txt_DiaChi.Text + "',dienThoai = N'" + txt_DienThoai.Text + "',email = '" + txt_Email.Text + "' where maNhaCC = '" + txt_MaNhaCC.Text + "'";
            KetNoiSQL.Sua(sql);
            KetNoiSQL.Chuoiketnoi(chuoi, dtgv_NhaCungCap);
            TenBang();
            Clear();
        }

        private void txt1_TenNhaCungCap_TextChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String sqlTimKiem = "Select * from NhaCungCap where maNhaCC = '" + txt1_TimKiem.Text + "' ";
            KetNoiSQL.TimKiem(sqlTimKiem,dtgv_NhaCungCap);
            TenBang();
           
        }
    }
}
