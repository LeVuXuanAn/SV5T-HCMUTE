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
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            panel1 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            panel8 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel12 = new Panel();
            lbl4 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel11 = new Panel();
            panel10 = new Panel();
            lbl2 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            lbl3 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            lbl1 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            btnTimKiem = new Button();
            panel3 = new Panel();
            cbbNamHoc = new ComboBox();
            lable1 = new Label();
            panel5 = new Panel();
            cbbThang = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 450);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Controls.Add(label3);
            panel6.Controls.Add(panel8);
            panel6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            panel6.Location = new Point(1, 251);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(916, 46);
            panel6.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(315, 17);
            label3.Name = "label3";
            label3.Size = new Size(266, 29);
            label3.TabIndex = 2;
            label3.Text = "THỐNG KÊ SINH VIÊN";
            // 
            // panel8
            // 
            panel8.Controls.Add(panel13);
            panel8.Location = new Point(0, 27);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(916, 146);
            panel8.TabIndex = 3;
            // 
            // panel13
            // 
            panel13.Location = new Point(2, 22);
            panel13.Margin = new Padding(3, 2, 3, 2);
            panel13.Name = "panel13";
            panel13.Size = new Size(897, 140);
            panel13.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.BackColor = Color.DeepSkyBlue;
            panel14.Controls.Add(panel12);
            panel14.Location = new Point(-3, 296);
            panel14.Margin = new Padding(3, 2, 3, 2);
            panel14.Name = "panel14";
            panel14.Size = new Size(916, 158);
            panel14.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ButtonHighlight;
            panel12.Controls.Add(lbl4);
            panel12.Controls.Add(label4);
            panel12.Location = new Point(22, 19);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(864, 117);
            panel12.TabIndex = 3;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.Location = new Point(418, 22);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(43, 51);
            lbl4.TabIndex = 8;
            lbl4.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(262, 88);
            label4.Name = "label4";
            label4.Size = new Size(358, 20);
            label4.TabIndex = 1;
            label4.Text = "Số lượng sinh viên đăng ký tham gia sinh viên 5 tốt";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DeepSkyBlue;
            panel4.Controls.Add(label1);
            panel4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            panel4.Location = new Point(0, 58);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(916, 61);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 19);
            label1.Name = "label1";
            label1.Size = new Size(336, 29);
            label1.TabIndex = 2;
            label1.Text = "THỐNG KÊ CHƯƠNG TRÌNH";
            // 
            // panel11
            // 
            panel11.BackColor = Color.DeepSkyBlue;
            panel11.Controls.Add(panel10);
            panel11.Controls.Add(panel7);
            panel11.Controls.Add(panel9);
            panel11.Location = new Point(0, 110);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(919, 147);
            panel11.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ButtonHighlight;
            panel10.Controls.Add(lbl2);
            panel10.Controls.Add(label8);
            panel10.Location = new Point(314, 14);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(291, 117);
            panel10.TabIndex = 5;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(124, 13);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(43, 51);
            lbl2.TabIndex = 10;
            lbl2.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 80);
            label8.Name = "label8";
            label8.Size = new Size(227, 20);
            label8.TabIndex = 3;
            label8.Text = "Số chương trình đang tiến hành";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(lbl3);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(622, 14);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(279, 117);
            panel7.TabIndex = 2;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.Location = new Point(120, 13);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(43, 51);
            lbl3.TabIndex = 9;
            lbl3.Text = "0";
            lbl3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 80);
            label5.Name = "label5";
            label5.Size = new Size(223, 20);
            label5.TabIndex = 0;
            label5.Text = "Số chương trình đã hoàn thành";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonHighlight;
            panel9.Controls.Add(lbl1);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(13, 14);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(283, 117);
            panel9.TabIndex = 4;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(119, 13);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(43, 51);
            lbl1.TabIndex = 11;
            lbl1.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 80);
            label7.Name = "label7";
            label7.Size = new Size(234, 20);
            label7.TabIndex = 2;
            label7.Text = "Số chương trình chuẩn bị diễn ra";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(27, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 50);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(752, 11);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(77, 25);
            button1.TabIndex = 9;
            button1.Text = "Reload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top;
            btnTimKiem.BackColor = Color.DeepSkyBlue;
            btnTimKiem.BackgroundImage = (Image)resources.GetObject("btnTimKiem.BackgroundImage");
            btnTimKiem.BackgroundImageLayout = ImageLayout.Center;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(666, 10);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 27);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbbNamHoc);
            panel3.Controls.Add(lable1);
            panel3.Location = new Point(24, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 41);
            panel3.TabIndex = 2;
            // 
            // cbbNamHoc
            // 
            cbbNamHoc.ForeColor = SystemColors.ActiveCaptionText;
            cbbNamHoc.FormattingEnabled = true;
            cbbNamHoc.Location = new Point(92, 10);
            cbbNamHoc.Name = "cbbNamHoc";
            cbbNamHoc.Size = new Size(230, 23);
            cbbNamHoc.TabIndex = 1;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lable1.Location = new Point(3, 11);
            lable1.Name = "lable1";
            lable1.Size = new Size(83, 19);
            lable1.TabIndex = 0;
            lable1.Text = "Năm học:";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbbThang);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(353, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(307, 40);
            panel5.TabIndex = 4;
            // 
            // cbbThang
            // 
            cbbThang.ForeColor = SystemColors.Desktop;
            cbbThang.FormattingEnabled = true;
            cbbThang.Location = new Point(73, 10);
            cbbThang.Name = "cbbThang";
            cbbThang.Size = new Size(227, 23);
            cbbThang.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 0;
            label2.Text = "Tháng:";
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThongKe";
            Text = "TỔNG QUAN";
            TransparencyKey = Color.LightSteelBlue;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lable1;
        private Button btnLoc;
        private Panel panel4;
        private Label label1;
        private Panel panel6;
        private Label label3;
        private Label label4;
        private ComboBox cbbNamHoc;
        private Panel panel5;
        private ComboBox cbbThang;
        private Label label2;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel7;
        private Label label5;
        private Label label8;
        private Label label7;
        private TextBox txb1;
        private TextBox txb4;
        private TextBox txb2;
        private Panel panel12;
        private TextBox textBox1;
        private TextBox txb5;
        private Label lbl4;
        private Label lbl2;
        private Label lbl1;
        private Label lbl3;
        private Panel panel8;
        private Panel panel13;
        private Panel panel14;
        private Button btnTimKiem;
        private Button button1;
    }
}