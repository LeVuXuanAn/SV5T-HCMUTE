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
    public partial class DSSVTG : Form
    {
        private string maChuongTrinh;
        

        public DSSVTG(string maChuongTrinh)
        {
            InitializeComponent();

            this.maChuongTrinh = maChuongTrinh;
        }

        private SqlCommand command;
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=QLSV5T;Integrated Security=True");

        private void KetNoiCSDL(string maChuongTrinh)
        {
            conn.Open();
            string sql = "SELECT SINHVIEN.HoTen, SINHVIEN.MaSV, THAMGIA.TrangThai " +
                         "FROM SINHVIEN INNER JOIN THAMGIA ON SINHVIEN.MaSV = THAMGIA.MaSV " +
                         "WHERE THAMGIA.MaCT = '" + maChuongTrinh + "'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dg_DS.DataSource = dt;
        }

        private void DSSVTG_Load(object sender, EventArgs e)
        {
            KetNoiCSDL(maChuongTrinh);
            foreach (DataGridViewRow row in dg_DS.Rows)
            {
                if (row.Cells["TrangThai"].Value != null && Convert.ToInt32(row.Cells["TrangThai"].Value) == 1)
                {
                    row.Cells["DiemDanh"].ReadOnly = true; // Vô hiệu hóa ô (cell)
                }
            }
        }

        private void dg_DS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // 0 là chỉ mục cột STT
            {
                e.Value = e.RowIndex + 1; // Thêm 1 vào chỉ mục hàng để tạo STT bắt đầu từ 1
            }
        }
        private void dg_DS_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }
        private void dg_DS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewCheckBoxCell checkBoxCell = dg_DS.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                // Xử lý logic tương ứng với thay đổi trạng thái của ô kiểm
                if (isChecked)
                {
                    // Ô kiểm đã được chọn
                    SqlCommand command = new SqlCommand("UpdateTrangThaiToOne", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    string MaSV = dg_DS.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
                    SqlParameter p = new SqlParameter("@MaSV", Convert.ToInt32(MaSV));
                    command.Parameters.Add(p);
                    command.ExecuteNonQuery();
                    MessageBox.Show("chạy r đó");
                    KetNoiCSDL(maChuongTrinh);
                }
                
        }
             
        
        private void dg_DS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           /* MessageBox.Show(e.RowIndex.ToString());
            int rowIndex = e.RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = dg_DS.Rows[rowIndex].Cells["DiemDanh"] as DataGridViewCheckBoxCell;
                bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                if (isChecked)
                {
                    // Ô checkbox được tích
                    // Xử lý logic tương ứng
                    SqlCommand command = new SqlCommand("UpdateTrangThaiToOne", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            
            /*MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex == 4)
            {
                int row = e.RowIndex;
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dg_DS.Rows[row].Cells["DiemDanh"];
                bool isChecked = (bool)checkBoxCell.Value;
                MessageBox.Show(e.RowIndex.ToString());

                if (isChecked)
                {
                    // Ô checkbox được tích
                    // Xử lý logic tương ứng
                    SqlCommand command = new SqlCommand("UpdateTrangThaiToOne", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                  
                } 
            }*/
        }

        
    }
}
