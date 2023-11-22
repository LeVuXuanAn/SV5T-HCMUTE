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
    public partial class QuanLyChung_QuanTriVien : Form
    {
        public QuanLyChung_QuanTriVien()
        {
            InitializeComponent();
        }
        private Form currentForm;
        private void OpenChildForm(Form childForm)
        {
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void buttonChangeColor(object sender, EventArgs e)
        {
            foreach (Control c in btnpanel.Controls)
            {
                c.BackColor = Color.DarkOrange;
            }
            Control click = (Control)sender;
            click.BackColor = Color.DeepSkyBlue;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            //--Đổi màu nút button
            foreach (Control c in btnpanel.Controls)
            {
                c.BackColor = Color.DarkOrange;
            }
            Control click = (Control)sender;
            click.BackColor = Color.Red;
            //--Hiện bảng thông báo
            DialogResult msg = MessageBox.Show(this, "Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                click.BackColor = Color.DeepSkyBlue;
            }
        }

        private void btn_TongQuan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            buttonChangeColor(btn_TongQuan, null);
        }

        private void btn_ChuongTrinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyChuongTrinh());
            buttonChangeColor(btn_ChuongTrinh, null);
        }

        private void btn_SinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien());
            buttonChangeColor(btn_SinhVien, null);
        }

        private void btn_Diem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Diem());
            buttonChangeColor(btn_Diem, null);
        }
    }
}
