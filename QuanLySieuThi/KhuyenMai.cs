using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class KhuyenMai : Form
    {
        public KhuyenMai()
        {
            InitializeComponent();
        }

        private void dtgv_KhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_KhuyenMai_Click(object sender, EventArgs e)
        {
            int soThuTu = dtgv_KhuyenMai.CurrentRow.Index;
            //txt_MaKM = dtgv_KhuyenMai.Rows[soThuTu].Cells[0].Value.ToString();
            //txt_TenKM = dtgv_KhuyenMai.Rows[soThuTu].Cells[1].Value.ToString();

        }
    }
}
