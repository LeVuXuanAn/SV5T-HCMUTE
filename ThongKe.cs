using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV5T
{
    public partial class ThongKe : Form
    {
        SqlConnection ketNoi;
        string chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QLSV5T;Integrated Security=True";
        public ThongKe()
        {
            InitializeComponent();
            ketNoi = new SqlConnection(chuoiKetNoi);
            Load_cbbNamHoc();
            Load_cbbThang();
        }
        public void Load_cbbNamHoc()
        {
            cbbNamHoc.Items.Clear();
            ketNoi.Open();
            DateTime now = DateTime.Now;
            int i = now.Year + 1;
            while (i >= 1962)
            {
                cbbNamHoc.Items.Add(i);
                i--;
            }
            ketNoi.Close();
        }

        public void Load_cbbThang()
        {
            cbbThang.Items.Clear();
            ketNoi.Open();
            DateTime now = DateTime.Now;
            int i = 1;
            while (i <= 12)
            {
                cbbThang.Items.Add(i);
                i++;
            }
            ketNoi.Close();
        }
        public class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }
        }

        public void DemCT_DaHoanThanh()
        {
            ketNoi.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.func_DemCT_DaHoanThanh_TheoThang(@thang, @nam)", ketNoi);
            string k = cbbNamHoc.Text;
            int selectedValue, soLuong;
            string soLuongString;
            object result;
            try
            {
                if (k == "")
                {
                    throw new CustomException("Lỗi");
                }
                selectedValue = int.Parse(k);
                cmd.Parameters.Add("@nam", SqlDbType.Int).Value = selectedValue;
                k = cbbThang.Text;
                if (k == "")
                {
                    cmd = new SqlCommand("SELECT dbo.func_DemCT_DaHoanThanh_TheoNam(@nam)", ketNoi);
                    k = cbbNamHoc.Text;
                    selectedValue = int.Parse(k);
                    cmd.Parameters.Add("@nam", SqlDbType.Int).Value = selectedValue;
                    result = cmd.ExecuteScalar();
                    soLuong = (int)result;
                    soLuongString = soLuong.ToString();
                    lbl3.Text = soLuongString;
                }
                else
                {
                    selectedValue = int.Parse(k);
                    cmd.Parameters.Add("@thang", SqlDbType.Int).Value = selectedValue;
                    result = cmd.ExecuteScalar();
                    soLuong = (int)result;
                    soLuongString = soLuong.ToString();
                    lbl3.Text = soLuongString;
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine("Bạn chưa chọn năm học!!!" + e.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }
        public void DemCT_DangTienHanh()
        {
            ketNoi.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.func_DemCT_DienRa_TheoThang(@thang, @nam)", ketNoi);
            string k = cbbNamHoc.Text;
            int selectedValue, soLuong;
            string soLuongString;
            object result;
            try
            {
                if (k == "")
                {
                    throw new CustomException("Lỗi");
                }
                selectedValue = int.Parse(k);
                cmd.Parameters.Add("@nam", SqlDbType.Int).Value = selectedValue;
                k = cbbThang.Text;
                if (k == "")
                {
                    cmd = new SqlCommand("SELECT dbo.func_DemCT_DienRa_TheoNam(@nam)", ketNoi);
                    k = cbbNamHoc.Text;
                    selectedValue = int.Parse(k);
                    cmd.Parameters.Add("@nam", SqlDbType.Int).Value = selectedValue;
                    result = cmd.ExecuteScalar();
                    soLuong = (int)result;
                    soLuongString = soLuong.ToString();
                    lbl2.Text = soLuongString;
                }
                else
                {
                    selectedValue = int.Parse(k);
                    cmd.Parameters.Add("@thang", SqlDbType.Int).Value = selectedValue;
                    result = cmd.ExecuteScalar();
                    soLuong = (int)result;
                    soLuongString = soLuong.ToString();
                    lbl2.Text = soLuongString;
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine("Bạn chưa chọn năm học!!!" + e.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }

        public void DemCT_ChuanBiDienRa()
        {
            ketNoi.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.func_DemCT_ChuanBi_TheoThang(@thang, @nam)", ketNoi);
            string k = cbbNamHoc.Text;
            int selectedValue, soLuong;
            string soLuongString;
            object result;
            try
            {
                if (k == "")
                {
                    throw new CustomException("Lỗi");
                }
                selectedValue = int.Parse(k);
                cmd.Parameters.Add("@nam", SqlDbType.Int).Value = selectedValue;
                k = cbbThang.Text;
                if (k == "")
                {
                    cmd = new SqlCommand("SELECT dbo.func_DemCT_ChuanBi_TheoNam(@nam)", ketNoi);
                    k = cbbNamHoc.Text;
                    selectedValue = int.Parse(k);
                    cmd.Parameters.Add("@nam", SqlDbType.Int).Value = selectedValue;
                    result = cmd.ExecuteScalar();
                    soLuong = (int)result;
                    soLuongString = soLuong.ToString();
                    lbl1.Text = soLuongString;
                }
                else
                {
                    selectedValue = int.Parse(k);
                    cmd.Parameters.Add("@thang", SqlDbType.Int).Value = selectedValue;
                    result = cmd.ExecuteScalar();
                    soLuong = (int)result;
                    soLuongString = soLuong.ToString();
                    lbl1.Text = soLuongString;
                }
            }
            catch (CustomException e)
            {
                Console.WriteLine("Bạn chưa chọn năm học!!!" + e.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }
        public void DemSV()
        {
            ketNoi.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.func_DemSV_TheoThang(@thang, @nam)", ketNoi);
            string k = cbbNamHoc.Text;
            int selectedValue, soLuong;
            string soLuongString;
            object result;
            try
            {
                if (k == "")
                {
                    throw new CustomException("");
                }
                selectedValue = int.Parse(k);
                cmd.Parameters.Add("@nam", SqlDbType.Int).Value = selectedValue;
                k = cbbThang.Text;
                if (k == "")
                {
                    cmd = new SqlCommand("SELECT dbo.func_DemSV_TheoNam(@nam)", ketNoi);
                    k = cbbNamHoc.Text;
                    selectedValue = int.Parse(k);
                    cmd.Parameters.Add("@nam", SqlDbType.Int).Value = selectedValue;
                    result = cmd.ExecuteScalar();
                    soLuong = (int)result;
                    soLuongString = soLuong.ToString();
                    lbl4.Text = soLuongString;
                }
                else
                {
                    selectedValue = int.Parse(k);
                    cmd.Parameters.Add("@thang", SqlDbType.Int).Value = selectedValue;
                    result = cmd.ExecuteScalar();
                    soLuong = (int)result;
                    soLuongString = soLuong.ToString();
                    lbl4.Text = soLuongString;
                }
            }
            catch (CustomException e)
            {
                MessageBox.Show("Bạn chưa chọn năm học!!!" + e.Message);
            }
            finally
            {
                ketNoi.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DemCT_DaHoanThanh();
            DemCT_ChuanBiDienRa();
            DemCT_DangTienHanh();
            DemSV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbNamHoc.Text = "";
            cbbThang.Text = "";
            lbl1.Text = "0";
            lbl2.Text = "0";
            lbl3.Text = "0";
            lbl4.Text = "0";
        }
    }
}
