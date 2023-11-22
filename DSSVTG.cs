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
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DBMS_SV5T_K;User ID=sa;Password=ldtrong0");

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
            // Kiểm tra nếu ô đang được chỉnh sửa là ô điểm danh và trạng thái là 1
            if (e.ColumnIndex == dg_DS.Columns["DiemDanh"].Index && e.RowIndex >= 0)
            {
                

                // Kiểm tra giá trị trạng thái
                if (dg_DS.Rows[e.RowIndex].Cells["TrangThai"].Value != null && dg_DS.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString() == "1")
                {
                    e.Cancel = true; // Vô hiệu hóa chỉnh sửa ô điểm danh
                }
            }
        }
        private void dg_DS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           /* MessageBox.Show(e.RowIndex.ToString());
            MessageBox.Show(e.RowIndex.ToString());
            if (e.ColumnIndex == 4)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dg_DS.Rows[e.RowIndex].Cells[e.ColumnIndex];
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
                else
                {
                    // Ô checkbox không được tích
                    // Xử lý logic tương ứng
                    SqlCommand command = new SqlCommand("UpdateTrangThaiToZero", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                  
                }
                
            }*/
        }

        private void dg_DS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
