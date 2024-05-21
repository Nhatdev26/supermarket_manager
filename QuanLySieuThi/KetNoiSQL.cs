using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace QuanLySieuThi
{
    internal class KetNoiSQL
    {
        public static string sqlCon = @"Data Source=LAPTOP-8N0VFK20\SQLEXPRESS;Initial Catalog=QuanLyST;Integrated Security=True";
        public static SqlConnection myCon = new SqlConnection(sqlCon);

        
        public static SqlCommand sqlCom;
        public static SqlDataAdapter sqlADT;
        public static DataTable dt;

        public static SqlCommandBuilder sqlCB;
        public static SqlDataReader showtext(string sql)
        {
            SqlDataReader read = null;
            try
            {
                myCon = new SqlConnection(sqlCon);
                myCon.Open();
                sqlCom = new SqlCommand(sql, myCon);
                read = sqlCom.ExecuteReader();

            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi kết nối!\n" + ex.Message); }
            return read;
        }
        // ham ket noi
        public static void Chuoiketnoi(string chuoi, DataGridView dtgv)
        {
            try
            {
                sqlADT = new SqlDataAdapter(chuoi, sqlCon);
                dt = new DataTable();
                sqlCB = new SqlCommandBuilder(sqlADT);
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");
            }
        }

        public static void LamMoi(string sql, DataGridView dtgv)
        {
            try
            {
                myCon.Open();
                sqlCom = new SqlCommand(sql,myCon);
                sqlADT = new SqlDataAdapter(sqlCom);
                DataTable dt = new DataTable();
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;
                MessageBox.Show("Lam moi Thanh công !", "Thông báo ");
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }

        public static void Them(string sql, DataGridView dtgv)
        {
            try
            {
                myCon = new SqlConnection(sqlCon);
                myCon.Open();
                sqlCom = new SqlCommand(sql, myCon);
                sqlADT = new SqlDataAdapter(sqlCom);
                DataTable dt = new DataTable();
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;
                MessageBox.Show("Them Thanh công !", "Thông báo ");
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }
        public static void Xoa(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {             
                    myCon.Open();
                    sqlCom = new SqlCommand(sql, myCon);
                    sqlCom.ExecuteNonQuery();
                    myCon.Close();
                    MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        public static void Sua(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    myCon.Open();
                    sqlCom = new SqlCommand(sql, myCon);
                    sqlCom.ExecuteNonQuery();
                    myCon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        public static void KhoiTaoBang(string sql,DataGridView dtgv)
        {
            try
            {
                sqlADT = new SqlDataAdapter(sql, myCon);
                sqlCB = new SqlCommandBuilder(sqlADT);
                DataTable dt = new DataTable();
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }

        public static void TimKiem(string sql, DataGridView dtgv)
        {
            try
            {
               
                sqlADT = new SqlDataAdapter(sql, myCon);
                DataTable dt = new DataTable();
                sqlCB = new SqlCommandBuilder(sqlADT);
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

 
        }


        public static void xulycbx(string chuoi, ComboBox cbx)
        {
            sqlADT = new SqlDataAdapter(chuoi, sqlCon);

            sqlADT.Fill(dt);
            cbx.DataSource = dt;


        }

    }
}
