using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySV5T
{
    public partial class ChinhsuaChuongtrinh : Form
    {
        public ChinhsuaChuongtrinh()
        {
            InitializeComponent();
        }
        
        private SqlCommand command;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DBMS_SV5T_K;User ID=sa;Password=ldtrong0");
        private void KetNoiCSDL()
        {
            conn.Open();
            string sql = "Select * From CHUONGTRINH";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dg_TaoCT.DataSource = dt;
        }


        private void TaoCT_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }

        private void btn_Tao_Click(object sender, EventArgs e)
        {
            
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }    
            
                command = new SqlCommand("ThemCT", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaCT", SqlDbType.Int).Value = Convert.ToInt32(txt_MaCT.Text);
                command.Parameters.Add("@TenCT", SqlDbType.NVarChar).Value = txt_TenCT.Text.Trim();
                command.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = txt_MoTa.Text.Trim();
            
                command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = txt_TrangThai.Text.Trim();

                // Thời gian bắt đầu và kết thúc
                command.Parameters.Add("@ThoiGianBDCT", SqlDbType.DateTime).Value = dt_BD.Value;
                command.Parameters.Add("@ThoiGianKTCT", SqlDbType.DateTime).Value = dt_KT.Value;

                command.Parameters.Add("@DiaDiem", SqlDbType.NVarChar).Value = txt_DiaDiem.Text;
                command.Parameters.Add("@GioiHanDK", SqlDbType.Int).Value = Convert.ToInt32(txt_GHDK.Text);
                command.Parameters.Add("@DiemCong", SqlDbType.Int).Value = Convert.ToInt32(txt_DiemCong.Text);
                command.Parameters.Add("@LoaiCT", SqlDbType.NVarChar).Value = txt_LoaiCT.Text;
                command.ExecuteNonQuery();
            conn.Close();
            try
            {              
                MessageBox.Show("Thêm thành công");
                KetNoiCSDL();
            }
            catch (Exception err)
            {
                
                MessageBox.Show(err.Message.Substring(err.Message.IndexOf("\n")));
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand("SuaCT", conn); 
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaCT", SqlDbType.Int).Value = Convert.ToInt32(txt_MaCT.Text);
            command.Parameters.Add("@TenCT", SqlDbType.NVarChar).Value = txt_TenCT.Text.Trim();
            command.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = txt_MoTa.Text.Trim();
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = txt_TrangThai.Text.Trim();
            command.Parameters.Add("@ThoiGianBDCT", SqlDbType.DateTime).Value = dt_BD.Value;
            command.Parameters.Add("@ThoiGianKTCT", SqlDbType.DateTime).Value = dt_KT.Value;
            command.Parameters.Add("@DiaDiem", SqlDbType.NVarChar).Value = txt_DiaDiem.Text;
            command.Parameters.Add("@GioiHanDK", SqlDbType.Int).Value = Convert.ToInt32(txt_GHDK.Text);
            command.Parameters.Add("@DiemCong", SqlDbType.Int).Value = Convert.ToInt32(txt_DiemCong.Text);
            command.Parameters.Add("@LoaiCT", SqlDbType.NVarChar).Value = txt_LoaiCT.Text;
            command.ExecuteNonQuery();

            conn.Close();

            try
            {
                MessageBox.Show("Sửa thành công");
                KetNoiCSDL(); // Hàm này dùng để làm mới danh sách chương trình sau khi đã sửa thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể sửa thông tin chương trình");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            command = new SqlCommand("XoaCT", conn);
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
           
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@MaCT", Convert.ToInt32(txt_MaCT.Text));
                command.Parameters.Add(p);

            }
            command.ExecuteNonQuery();
            conn.Close();
            try
            {
                MessageBox.Show("xoá thành công");
                KetNoiCSDL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa");
            }
        }

        private void dg_TaoCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
