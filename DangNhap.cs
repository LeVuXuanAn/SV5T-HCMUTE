using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV5T
{
    public partial class DangNhap : Form
    {
        SqlConnection ketNoi;
        String chuoiKetNoi = @"Data Source=localhost;Initial Catalog=QLSV5T;Integrated Security=True";
        SqlCommand thucHien;
        SqlDataReader docDuLieu;
        string lenh;
        public DangNhap()
        {
            InitializeComponent();
            ketNoi = new SqlConnection(chuoiKetNoi);
        }

        //Thêm vào ------------------------------------------------------------
        private void OpenFormQuanLyChung()
        {
            SharedData.GiaTri = txbTenTK.Text;
            QuanLyChung form1 = new QuanLyChung();
            form1.Show();
        }
        private void OpenFormQuanLyChung_QuanTriVien()
        {
            SharedData.GiaTri = txbTenTK.Text;
            QuanLyChung_QuanTriVien form2 = new QuanLyChung_QuanTriVien();
            form2.Show();
        }
        // -------------------------------------------------------------------


        public class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TichLuy formDN = new TichLuy(txbTenTK.Text);
            ketNoi.Open();
            bool count;
            try
            {
                if (string.IsNullOrEmpty(txbTenTK.Text) || string.IsNullOrEmpty(txbMatKhau.Text))
                {
                    throw new CustomException("Bạn chưa nhập tên tài khoản hoặc mật khẩu!");
                }
                else if (radioSV.Checked)
                {
                    using (thucHien = new SqlCommand("SELECT dbo.func_KiemTraLogin(@TenTK, @MatKhau, @LoaiTK)", ketNoi))
                    {
                        thucHien.Parameters.AddWithValue("@TenTK", txbTenTK.Text);
                        thucHien.Parameters.AddWithValue("@MatKhau", txbMatKhau.Text);
                        thucHien.Parameters.AddWithValue("@LoaiTK", "User");
                        count = (bool)thucHien.ExecuteScalar();
                        new CustomException("Đăng nhập thành công!");
                        if (count)
                        {
                            //Sửa chỗ này----------------------------------------
                            
                            OpenFormQuanLyChung();
                            this.Close();
                            //---------------------------------------------------
                        }
                    }
                }
                else if (radioQTV.Checked)
                {
                    using (thucHien = new SqlCommand("SELECT dbo.func_KiemTraLogin(@TenTK, @MatKhau, @LoaiTK)", ketNoi))
                    {
                        thucHien.Parameters.AddWithValue("@TenTK", txbTenTK.Text);
                        thucHien.Parameters.AddWithValue("@MatKhau", txbMatKhau.Text);
                        thucHien.Parameters.AddWithValue("@LoaiTK", "Admin");
                        count = (bool)thucHien.ExecuteScalar();
                        new CustomException("Đăng nhập thành công!");
                        if (count)
                        {
                            //Sửa chỗ này-------------------------------------------------------
                            
                            OpenFormQuanLyChung_QuanTriVien();
                            this.Close();
                            //-----------------------------------------------------------------
                        }
                    }
                }
                else
                {
                    throw new CustomException("Bạn chưa chọn bạn là sinh viên hay quản trị viên!");
                }
                //Sửa chỗ này bỏ cái đăng nhập thành công nha
                if (count == false)
                {
                    throw new CustomException("Sai tên mật khẩu hoặc tài khoản!");
                }
                //-------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ketNoi.Close();
        }
    }
}
