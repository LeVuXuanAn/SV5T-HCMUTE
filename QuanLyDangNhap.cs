﻿using System;
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
    public partial class QuanLyDangNhap : Form
    {
        public QuanLyDangNhap()
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
                c.BackColor = Color.DeepSkyBlue;
            }
            Control click = (Control)sender;
            click.BackColor = Color.Orange;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DangNhap());
            buttonChangeColor(btn_DangNhap, null);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            //--Đổi màu nút button
            foreach (Control c in btnpanel.Controls)
            {
                c.BackColor = Color.DeepSkyBlue;
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
    }
}
