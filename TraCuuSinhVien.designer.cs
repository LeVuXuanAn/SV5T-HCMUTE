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
namespace QuanLySV5T
{
    partial class TraCuuSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuSinhVien));
            btnTimKiem = new Button();
            panel1 = new Panel();
            dtgSinhVien = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            label4 = new Label();
            cbbLop = new ComboBox();
            panel4 = new Panel();
            label3 = new Label();
            cbbNganh = new ComboBox();
            panel3 = new Panel();
            label2 = new Label();
            cbbKhoa = new ComboBox();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            MaLop = new DataGridViewTextBoxColumn();
            TenTK = new DataGridViewTextBoxColumn();
            NgayDK = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSinhVien).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top;
            btnTimKiem.BackColor = Color.DodgerBlue;
            btnTimKiem.BackgroundImage = (Image)resources.GetObject("btnTimKiem.BackgroundImage");
            btnTimKiem.BackgroundImageLayout = ImageLayout.Center;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(1193, 49);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(91, 36);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dtgSinhVien);
            panel1.Location = new Point(13, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(1379, 593);
            panel1.TabIndex = 4;
            // 
            // dtgSinhVien
            // 
            dtgSinhVien.BackgroundColor = SystemColors.ControlLightLight;
            dtgSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSinhVien.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, Email, MaLop, TenTK, NgayDK });
            dtgSinhVien.Dock = DockStyle.Fill;
            dtgSinhVien.Location = new Point(0, 0);
            dtgSinhVien.Name = "dtgSinhVien";
            dtgSinhVien.RowHeadersWidth = 63;
            dtgSinhVien.RowTemplate.Height = 28;
            dtgSinhVien.Size = new Size(1379, 593);
            dtgSinhVien.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1403, 124);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(1291, 52);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 8;
            button1.Text = "Reload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(cbbLop);
            panel5.Location = new Point(822, 42);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 47);
            panel5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 11);
            label4.Name = "label4";
            label4.Size = new Size(71, 29);
            label4.TabIndex = 5;
            label4.Text = "LỚP:";
            // 
            // cbbLop
            // 
            cbbLop.FormattingEnabled = true;
            cbbLop.Location = new Point(85, 11);
            cbbLop.Name = "cbbLop";
            cbbLop.Size = new Size(269, 28);
            cbbLop.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(cbbNganh);
            panel4.Location = new Point(406, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 47);
            panel4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(111, 29);
            label3.TabIndex = 5;
            label3.Text = "NGÀNH:";
            // 
            // cbbNganh
            // 
            cbbNganh.FormattingEnabled = true;
            cbbNganh.Location = new Point(123, 11);
            cbbNganh.Name = "cbbNganh";
            cbbNganh.Size = new Size(269, 28);
            cbbNganh.TabIndex = 4;
            cbbNganh.SelectedIndexChanged += cbbNganh_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cbbKhoa);
            panel3.Location = new Point(-11, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 47);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(91, 29);
            label2.TabIndex = 5;
            label2.Text = "KHOA:";
            // 
            // cbbKhoa
            // 
            cbbKhoa.FormattingEnabled = true;
            cbbKhoa.Location = new Point(123, 11);
            cbbKhoa.Name = "cbbKhoa";
            cbbKhoa.Size = new Size(269, 28);
            cbbKhoa.TabIndex = 4;
            cbbKhoa.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // MaSV
            // 
            MaSV.DataPropertyName = "MaSV";
            MaSV.HeaderText = "MSSV";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.Width = 125;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "HỌ TÊN";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "NGÀY SINH";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "GIỚI TÍNH";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "ĐỊA CHỈ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 125;
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "SĐT";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "EMAIL";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // MaLop
            // 
            MaLop.DataPropertyName = "MaLop";
            MaLop.HeaderText = "MÃ LỚP";
            MaLop.MinimumWidth = 6;
            MaLop.Name = "MaLop";
            MaLop.Width = 125;
            // 
            // TenTK
            // 
            TenTK.DataPropertyName = "TenTK";
            TenTK.HeaderText = "TÊN TÀI KHOẢN";
            TenTK.MinimumWidth = 6;
            TenTK.Name = "TenTK";
            TenTK.Width = 125;
            // 
            // NgayDK
            // 
            NgayDK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayDK.DataPropertyName = "NgayDK";
            NgayDK.HeaderText = "NGÀY ĐĂNG KÝ";
            NgayDK.MinimumWidth = 6;
            NgayDK.Name = "NgayDK";
            // 
            // TraCuuSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1403, 763);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TraCuuSinhVien";
            Text = "TraCuu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgSinhVien).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTimKiem;
        private Panel panel1;
        private DataGridView dtgSinhVien;
        private Panel panel2;
        private Label label2;
        private ComboBox cbbKhoa;
        private Panel panel5;
        private Label label4;
        private ComboBox cbbLop;
        private Panel panel4;
        private Label label3;
        private ComboBox cbbNganh;
        private Panel panel3;
        private Button btnDatLai;
        private Button button1;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn TenTK;
        private DataGridViewTextBoxColumn NgayDK;
    }
}