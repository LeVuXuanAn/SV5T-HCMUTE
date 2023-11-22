using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLSV5T
{
    partial class DanhSachSV5T
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSV5T));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbNganh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHOATableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOATableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtg1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 590);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1279, 221);
            this.panel8.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 89);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1279, 126);
            this.panel9.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnTimKiem);
            this.panel6.Controls.Add(this.btnDatLai);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1279, 126);
            this.panel6.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(848, 85);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 34);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnDatLai
            // 
            this.btnDatLai.Location = new System.Drawing.Point(983, 89);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(99, 30);
            this.btnDatLai.TabIndex = 7;
            this.btnDatLai.Text = "Reload";
            this.btnDatLai.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbNganh);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(644, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 34);
            this.panel4.TabIndex = 5;
            // 
            // cbbNganh
            // 
            this.cbbNganh.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbbNganh.FormattingEnabled = true;
            this.cbbNganh.Location = new System.Drawing.Point(126, 6);
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(312, 24);
            this.cbbNganh.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngành:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbLop);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(644, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(457, 34);
            this.panel5.TabIndex = 4;
            // 
            // cbbLop
            // 
            this.cbbLop.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(126, 6);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(312, 24);
            this.cbbLop.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(56, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lớp:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbKhoa);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(179, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 34);
            this.panel3.TabIndex = 4;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(126, 6);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(310, 24);
            this.cbbKhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khoa:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbNamHoc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(179, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 34);
            this.panel2.TabIndex = 3;
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbbNamHoc.FormattingEnabled = true;
            this.cbbNamHoc.Location = new System.Drawing.Point(126, 7);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.Size = new System.Drawing.Size(310, 24);
            this.cbbNamHoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm học:";
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1279, 89);
            this.panel7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(379, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "SINH VIÊN 5 TỐT";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "DANH SÁCH SINH VIÊN 5 TỐT";
            // 
            // dtg1
            // 
            this.dtg1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.Hoten,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.Email,
            this.TenTK,
            this.NgayDK});
            this.dtg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg1.Location = new System.Drawing.Point(0, 244);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 25;
            this.dtg1.Size = new System.Drawing.Size(1279, 346);
            this.dtg1.TabIndex = 8;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "MSSV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 70;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "HoTen";
            this.Hoten.HeaderText = "HỌ TÊN";
            this.Hoten.MinimumWidth = 6;
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 160;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NGÀY SINH";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 120;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GIỚI TÍNH";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 110;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "ĐỊA CHỈ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "EMAIL";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 160;
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TenTK";
            this.TenTK.HeaderText = "TÊN TÀI KHOẢN";
            this.TenTK.MinimumWidth = 6;
            this.TenTK.Name = "TenTK";
            this.TenTK.Width = 160;
            // 
            // NgayDK
            // 
            this.NgayDK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayDK.DataPropertyName = "NgayDK";
            this.NgayDK.HeaderText = "NGÀY ĐĂNG KÝ";
            this.NgayDK.MinimumWidth = 6;
            this.NgayDK.Name = "NgayDK";
            // 
            // DanhSachSV5T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1274, 586);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachSV5T";
            this.Text = "Danh sách sinh viên 5 tốt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOATableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private ComboBox cbbKhoa;
        private Label label3;
        private Panel panel2;
        private ComboBox cbbNamHoc;
        private Label label2;
        private Panel panel6;
        private Panel panel5;
        private ComboBox cbbLop;
        private Label label5;
        private Panel panel4;
        private ComboBox cbbNganh;
        private Label label4;
        private DataGridView dtg1;
        private BindingSource kHOATableAdapterBindingSource;
        private BindingSource dataSet2BindingSource;
        private BindingSource dataSet2BindingSource1;
        private Label label6;
        private Panel panel7;
        private Button btnDatLai;
        private Button btnTimKiem;
        private Panel panel8;
        private Panel panel9;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn Hoten;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TenTK;
        private DataGridViewTextBoxColumn NgayDK;
    }
}