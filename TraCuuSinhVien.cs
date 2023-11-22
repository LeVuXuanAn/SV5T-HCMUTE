using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLySV5T
{
    public partial class TraCuuSinhVien : Form
    {
        SqlConnection ketNoi;
        String chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QLSV5T;Integrated Security=True";
        SqlCommand thucHien;
        SqlDataReader docDuLieu;
        string lenh;
        public TraCuuSinhVien()
        {
            InitializeComponent();
            ketNoi = new SqlConnection(chuoiKetNoi);
            dtgSinhVien.ReadOnly = true;
            Load_cbbKhoa();
            HienThi();
        }

        public void HienThi()
        {
            dtgSinhVien.DataSource = null;
            ketNoi.Open();
            using (thucHien = new SqlCommand("proc_HienThiSVToanTruong", ketNoi))
            {
                thucHien.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(thucHien))
                {
                    adapter.Fill(dataTable);
                }
                dtgSinhVien.DataSource = dataTable;
            }
            ketNoi.Close();
        }

        public void Load_cbbKhoa()
        {
            cbbKhoa.Items.Clear();
            lenh = @"select TenKhoa from KHOA";
            ketNoi.Open();
            thucHien = new SqlCommand(lenh, ketNoi);
            docDuLieu = thucHien.ExecuteReader();
            while (docDuLieu.Read())
            {
                cbbKhoa.Items.Add(docDuLieu[0].ToString());
            }
            ketNoi.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNganh.Items.Clear();
            lenh = @"select NGANH.TenNganh 
                    from NGANH inner join 
                         KHOA on NGANH.MaKhoa = KHOA.MaKhoa
                    WHERE (KHOA.TenKhoa = N'" + cbbKhoa.Text + "')";
            ketNoi.Open();
            thucHien = new SqlCommand(lenh, ketNoi);
            docDuLieu = thucHien.ExecuteReader();
            while (docDuLieu.Read())
            {
                cbbNganh.Items.Add(docDuLieu[0].ToString());
            }
            ketNoi.Close();
        }

        private void cbbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbLop.Items.Clear();
            lenh = @"select LOP.TenLop 
                    from NGANH inner join 
                         LOP on NGANH.MaNganh = LOP.MaNganh
                    WHERE (NGANH.TenNganh = N'" + cbbNganh.Text + "')";
            ketNoi.Open();
            thucHien = new SqlCommand(lenh, ketNoi);
            docDuLieu = thucHien.ExecuteReader();
            while (docDuLieu.Read())
            {
                cbbLop.Items.Add(docDuLieu[0].ToString());
            }
            ketNoi.Close();
        }

        public class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string k;
            try
            {
                k = cbbKhoa.Text;
                if (k == "")
                {
                    throw new CustomException("Bạn chưa chọn khoa!");
                }
                else
                {
                    using (thucHien = new SqlCommand("proc_TimKiemSV_TheoTenLop", ketNoi))
                    {
                        thucHien.CommandType = CommandType.StoredProcedure;
                        k = cbbLop.Text;
                        if (k != "")
                        {
                            thucHien.Parameters.AddWithValue("@tenLop", k);
                            DataTable dataTable = new DataTable();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(thucHien))
                            {
                                adapter.Fill(dataTable);
                            }
                            dtgSinhVien.DataSource = dataTable;
                        }
                        else
                        {
                            using (thucHien = new SqlCommand("proc_TimKiemSV_TheoTenNganh", ketNoi))
                            {
                                thucHien.CommandType = CommandType.StoredProcedure;
                                k = cbbNganh.Text;
                                if (k != "")
                                {
                                    thucHien.Parameters.AddWithValue("@tenNganh", k);
                                    DataTable dataTable = new DataTable();
                                    using (SqlDataAdapter adapter = new SqlDataAdapter(thucHien))
                                    {
                                        adapter.Fill(dataTable);
                                    }
                                    dtgSinhVien.DataSource = dataTable;
                                }
                                else
                                {
                                    using (thucHien = new SqlCommand("proc_TimKiemSV_TheoTenKhoa", ketNoi))
                                    {
                                        thucHien.CommandType = CommandType.StoredProcedure;
                                        k = cbbKhoa.Text;
                                        thucHien.Parameters.AddWithValue("@tenKhoa", k);
                                        DataTable dataTable = new DataTable();
                                        using (SqlDataAdapter adapter = new SqlDataAdapter(thucHien))
                                        {
                                            adapter.Fill(dataTable);
                                        }
                                        dtgSinhVien.DataSource = dataTable;
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ketNoi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HienThi();
            cbbKhoa.Text = "";
            cbbNganh.Text = "";
            cbbLop.Text = "";
        }
    }
}
