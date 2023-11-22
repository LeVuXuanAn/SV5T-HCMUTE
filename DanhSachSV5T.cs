using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLSV5T.ThongKe;

namespace QLSV5T
{
    public partial class DanhSachSV5T : Form
    {
        SqlConnection ketNoi;
        String chuoiKetNoi = @"Data Source=LAPTOP-D9J937E4;Initial Catalog=QLSV5T;Integrated Security=True";
        SqlCommand thucHien;
        SqlDataReader docDuLieu;
        string lenh;
        public DanhSachSV5T()
        {
            InitializeComponent();
            ketNoi = new SqlConnection(chuoiKetNoi);
            dtg1.ReadOnly = true;
            Load_cbbNamHoc();
            Load_cbbKhoa();
        }
        public void Load_cbbNamHoc()
        {
            DateTime now = DateTime.Now;
            int i = now.Year + 1;
            while (i >= 1962)
            {
                cbbNamHoc.Items.Add(i);
                i--;
            }
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

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            cbbNamHoc.Text = "";
            cbbKhoa.Text = "";
            cbbNganh.Text = "";
            cbbLop.Text = "";
            dtg1.DataSource = null;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string k;
            try
            {
                k = cbbNamHoc.Text;
                if (k == "")
                {
                    throw new CustomException("Bạn chưa chọn năm học!");
                }
                else
                {
                    using (thucHien = new SqlCommand("proc_TimKiemSV5T_TheoTenLop", ketNoi))
                    {
                        thucHien.CommandType = CommandType.StoredProcedure;
                        k = cbbNamHoc.Text;
                        thucHien.Parameters.AddWithValue("@nam", int.Parse(k));
                        k = cbbLop.Text;
                        if (k != "")
                        {
                            thucHien.Parameters.AddWithValue("@tenLop", k);
                            DataTable dataTable = new DataTable();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(thucHien))
                            {
                                adapter.Fill(dataTable);
                            }
                            dtg1.DataSource = dataTable;
                        }
                        else
                        {
                            using (thucHien = new SqlCommand("proc_TimKiemSV5T_TheoTenNganh", ketNoi))
                            {
                                thucHien.CommandType = CommandType.StoredProcedure;
                                k = cbbNamHoc.Text;
                                thucHien.Parameters.AddWithValue("@nam", int.Parse(k));
                                k = cbbNganh.Text;
                                if (k != "")
                                {
                                    thucHien.Parameters.AddWithValue("@tenNganh", k);
                                    DataTable dataTable = new DataTable();
                                    using (SqlDataAdapter adapter = new SqlDataAdapter(thucHien))
                                    {
                                        adapter.Fill(dataTable);
                                    }
                                    dtg1.DataSource = dataTable;
                                }
                                else
                                {
                                    using (thucHien = new SqlCommand("proc_TimKiemSV5T_TheoTenKhoa", ketNoi))
                                    {
                                        thucHien.CommandType = CommandType.StoredProcedure;
                                        k = cbbNamHoc.Text;
                                        thucHien.Parameters.AddWithValue("@nam", int.Parse(k));
                                        k = cbbKhoa.Text;
                                        if (k != "")
                                        {
                                            thucHien.Parameters.AddWithValue("@tenKhoa", k);
                                            DataTable dataTable = new DataTable();
                                            using (SqlDataAdapter adapter = new SqlDataAdapter(thucHien))
                                            {
                                                adapter.Fill(dataTable);
                                            }
                                            dtg1.DataSource = dataTable;
                                        }
                                        else
                                        {
                                            using (thucHien = new SqlCommand("proc_TimKiemSV5T_TheoTruong", ketNoi))
                                            {
                                                thucHien.CommandType = CommandType.StoredProcedure;
                                                k = cbbNamHoc.Text;
                                                thucHien.Parameters.AddWithValue("@nam", int.Parse(k));
                                                DataTable dataTable = new DataTable();
                                                using (SqlDataAdapter adapter = new SqlDataAdapter(thucHien))
                                                {
                                                    adapter.Fill(dataTable);
                                                }
                                                dtg1.DataSource = dataTable;
                                            }
                                        }
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

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

