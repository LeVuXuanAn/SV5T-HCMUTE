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
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            label3 = new Label();
            txbTenTK = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txbMatKhau = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            radioQTV = new RadioButton();
            radioSV = new RadioButton();
            panel2 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1383, 135);
            label3.TabIndex = 14;
            label3.Text = "     ĐĂNG NHẬP";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbTenTK
            // 
            txbTenTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbTenTK.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txbTenTK.Location = new Point(489, 69);
            txbTenTK.Name = "txbTenTK";
            txbTenTK.Size = new Size(431, 34);
            txbTenTK.TabIndex = 16;
            txbTenTK.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(441, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(441, 131);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbMatKhau.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txbMatKhau.Location = new Point(489, 133);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.PasswordChar = '*';
            txbMatKhau.Size = new Size(431, 34);
            txbMatKhau.TabIndex = 20;
            txbMatKhau.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.Orange;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(587, 219);
            button1.Name = "button1";
            button1.Size = new Size(206, 79);
            button1.TabIndex = 21;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(radioQTV);
            panel1.Controls.Add(radioSV);
            panel1.Controls.Add(txbMatKhau);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txbTenTK);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 357);
            panel1.TabIndex = 22;
            // 
            // radioQTV
            // 
            radioQTV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioQTV.AutoSize = true;
            radioQTV.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioQTV.ForeColor = Color.SteelBlue;
            radioQTV.Location = new Point(789, 25);
            radioQTV.Name = "radioQTV";
            radioQTV.Size = new Size(125, 24);
            radioQTV.TabIndex = 23;
            radioQTV.TabStop = true;
            radioQTV.Text = "Quản trị viên";
            radioQTV.UseVisualStyleBackColor = true;
            // 
            // radioSV
            // 
            radioSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            radioSV.AutoSize = true;
            radioSV.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioSV.ForeColor = Color.SteelBlue;
            radioSV.Location = new Point(489, 25);
            radioSV.Name = "radioSV";
            radioSV.Size = new Size(98, 24);
            radioSV.TabIndex = 22;
            radioSV.TabStop = true;
            radioSV.Text = "Sinh viên";
            radioSV.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 494);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 213);
            panel2.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(437, 177);
            label4.Name = "label4";
            label4.Size = new Size(495, 18);
            label4.TabIndex = 3;
            label4.Text = "©️ 2023 HCMUTE.FIT Thiết kế và Phát triển bởi Nhóm 14 - DBMS";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(561, 37);
            label2.Name = "label2";
            label2.Size = new Size(258, 18);
            label2.TabIndex = 2;
            label2.Text = "KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(445, 13);
            label1.Name = "label1";
            label1.Size = new Size(511, 20);
            label1.TabIndex = 1;
            label1.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT THUẬT THÀNH PHỐ HỒ CHÍ MINH";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(629, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1383, 707);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhap";
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private TextBox txbTenTK;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txbMatKhau;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private RadioButton radioQTV;
        private RadioButton radioSV;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}