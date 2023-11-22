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
    public partial class QuanLyChuongTrinh : Form
    {
        public QuanLyChuongTrinh()
        {
            InitializeComponent();
        }
        private SqlCommand command;
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=DBMS_SV5T_K;User ID=sa;Password=ldtrong0");
        string sql = "Select MaCT,TenCT,LoaiCT,TrangThai From CHUONGTRINH";
        private void KetNoiCSDL(String sql)
        {
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dg_QLCT.DataSource = dt;
        }

        private void QuanLyChuongTrinh_Load(object sender, EventArgs e)
        {
            KetNoiCSDL("Select MaCT,TenCT,LoaiCT,TrangThai From CHUONGTRINH");
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            KetNoiCSDL("Select MaCT,TenCT,LoaiCT,TrangThai From CHUONGTRINH");
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String find= txt_Nhap.Text.Trim();

            if (string.IsNullOrEmpty(txt_Nhap.Text))
            {
                MessageBox.Show("Vui lòng điền Loại chương trình!! ");
                txt_Nhap.Focus();
            }
            else
            {
                String sql1 = "Select MaCT,TenCT,LoaiCT,TrangThai From CHUONGTRINH where CHUONGTRINH.LoaiCT LIKE '" + find + "'";
                KetNoiCSDL(sql1);
            }
        }

        private void dg_QLCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int row = e.RowIndex;
                string maChuongTrinh = dg_QLCT.Rows[row].Cells["MaCT"].Value.ToString();
                MessageBox.Show(maChuongTrinh.ToString());
                DSSVTG DS = new DSSVTG(maChuongTrinh);
                DS.Show();
            }
           
        }

        private void btn_taoCT_Click(object sender, EventArgs e)
        {
            ChinhsuaChuongtrinh CS = new ChinhsuaChuongtrinh();
            CS.Show();
        }
    }
}
