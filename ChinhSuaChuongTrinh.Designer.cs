
namespace CuoiKy
{
    partial class ChinhsuaChuongtrinh
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
            this.dg_TaoCT = new System.Windows.Forms.DataGridView();
            this.MaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBDCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKTCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiHanDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaCT = new System.Windows.Forms.TextBox();
            this.txt_TenCT = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.txt_LoaiCT = new System.Windows.Forms.TextBox();
            this.txt_DiemCong = new System.Windows.Forms.TextBox();
            this.txt_GHDK = new System.Windows.Forms.TextBox();
            this.txt_DiaDiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.dt_BD = new System.Windows.Forms.DateTimePicker();
            this.dt_KT = new System.Windows.Forms.DateTimePicker();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_TaoCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_TaoCT
            // 
            this.dg_TaoCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_TaoCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCT,
            this.TenCT,
            this.MoTa,
            this.TrangThai,
            this.ThoiGianBDCT,
            this.ThoiGianKTCT,
            this.DiaDiem,
            this.GioiHanDK,
            this.DiemCong,
            this.LoaiCT});
            this.dg_TaoCT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_TaoCT.Location = new System.Drawing.Point(0, 268);
            this.dg_TaoCT.Name = "dg_TaoCT";
            this.dg_TaoCT.RowHeadersWidth = 51;
            this.dg_TaoCT.RowTemplate.Height = 24;
            this.dg_TaoCT.Size = new System.Drawing.Size(800, 182);
            this.dg_TaoCT.TabIndex = 0;
            // 
            // MaCT
            // 
            this.MaCT.DataPropertyName = "MaCT";
            this.MaCT.HeaderText = "Mã CT";
            this.MaCT.MinimumWidth = 6;
            this.MaCT.Name = "MaCT";
            this.MaCT.Width = 125;
            // 
            // TenCT
            // 
            this.TenCT.DataPropertyName = "TenCT";
            this.TenCT.HeaderText = "Tên CT";
            this.TenCT.MinimumWidth = 6;
            this.TenCT.Name = "TenCT";
            this.TenCT.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // ThoiGianBDCT
            // 
            this.ThoiGianBDCT.DataPropertyName = "ThoiGianBDCT";
            this.ThoiGianBDCT.HeaderText = "TgianBDCT";
            this.ThoiGianBDCT.MinimumWidth = 6;
            this.ThoiGianBDCT.Name = "ThoiGianBDCT";
            this.ThoiGianBDCT.Width = 125;
            // 
            // ThoiGianKTCT
            // 
            this.ThoiGianKTCT.DataPropertyName = "ThoiGianKTCT";
            this.ThoiGianKTCT.HeaderText = "TgianKTCT";
            this.ThoiGianKTCT.MinimumWidth = 6;
            this.ThoiGianKTCT.Name = "ThoiGianKTCT";
            this.ThoiGianKTCT.Width = 125;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.Width = 125;
            // 
            // GioiHanDK
            // 
            this.GioiHanDK.DataPropertyName = "GioiHanDK";
            this.GioiHanDK.HeaderText = "Giới hạn DK";
            this.GioiHanDK.MinimumWidth = 6;
            this.GioiHanDK.Name = "GioiHanDK";
            this.GioiHanDK.Width = 125;
            // 
            // DiemCong
            // 
            this.DiemCong.DataPropertyName = "DiemCong";
            this.DiemCong.HeaderText = "Điểm cộng";
            this.DiemCong.MinimumWidth = 6;
            this.DiemCong.Name = "DiemCong";
            this.DiemCong.Width = 125;
            // 
            // LoaiCT
            // 
            this.LoaiCT.DataPropertyName = "LoaiCT";
            this.LoaiCT.HeaderText = "Loại CT";
            this.LoaiCT.MinimumWidth = 6;
            this.LoaiCT.Name = "LoaiCT";
            this.LoaiCT.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã CT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên CT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời gian BDCT";
            // 
            // txt_MaCT
            // 
            this.txt_MaCT.Location = new System.Drawing.Point(191, 21);
            this.txt_MaCT.Name = "txt_MaCT";
            this.txt_MaCT.Size = new System.Drawing.Size(100, 22);
            this.txt_MaCT.TabIndex = 6;
            // 
            // txt_TenCT
            // 
            this.txt_TenCT.Location = new System.Drawing.Point(191, 57);
            this.txt_TenCT.Name = "txt_TenCT";
            this.txt_TenCT.Size = new System.Drawing.Size(100, 22);
            this.txt_TenCT.TabIndex = 7;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(191, 96);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(100, 22);
            this.txt_MoTa.TabIndex = 8;
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(191, 126);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(100, 22);
            this.txt_TrangThai.TabIndex = 9;
            // 
            // txt_LoaiCT
            // 
            this.txt_LoaiCT.Location = new System.Drawing.Point(504, 154);
            this.txt_LoaiCT.Name = "txt_LoaiCT";
            this.txt_LoaiCT.Size = new System.Drawing.Size(100, 22);
            this.txt_LoaiCT.TabIndex = 20;
            // 
            // txt_DiemCong
            // 
            this.txt_DiemCong.Location = new System.Drawing.Point(504, 126);
            this.txt_DiemCong.Name = "txt_DiemCong";
            this.txt_DiemCong.Size = new System.Drawing.Size(100, 22);
            this.txt_DiemCong.TabIndex = 19;
            // 
            // txt_GHDK
            // 
            this.txt_GHDK.Location = new System.Drawing.Point(504, 96);
            this.txt_GHDK.Name = "txt_GHDK";
            this.txt_GHDK.Size = new System.Drawing.Size(100, 22);
            this.txt_GHDK.TabIndex = 18;
            // 
            // txt_DiaDiem
            // 
            this.txt_DiaDiem.Location = new System.Drawing.Point(504, 57);
            this.txt_DiaDiem.Name = "txt_DiaDiem";
            this.txt_DiaDiem.Size = new System.Drawing.Size(100, 22);
            this.txt_DiaDiem.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Loại CT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Điểm cộng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Giới hạn DK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Địa điểm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Thời gian KTCT";
            // 
            // btn_Tao
            // 
            this.btn_Tao.Location = new System.Drawing.Point(146, 212);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(75, 23);
            this.btn_Tao.TabIndex = 21;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = true;
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click);
            // 
            // dt_BD
            // 
            this.dt_BD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_BD.Location = new System.Drawing.Point(191, 159);
            this.dt_BD.Name = "dt_BD";
            this.dt_BD.Size = new System.Drawing.Size(100, 22);
            this.dt_BD.TabIndex = 22;
            // 
            // dt_KT
            // 
            this.dt_KT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_KT.Location = new System.Drawing.Point(504, 21);
            this.dt_KT.Name = "dt_KT";
            this.dt_KT.Size = new System.Drawing.Size(100, 22);
            this.dt_KT.TabIndex = 23;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(330, 211);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 24;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(504, 211);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 25;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_KT);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_BD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Tao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_LoaiCT);
            this.groupBox1.Controls.Add(this.txt_MaCT);
            this.groupBox1.Controls.Add(this.txt_DiemCong);
            this.groupBox1.Controls.Add(this.txt_TenCT);
            this.groupBox1.Controls.Add(this.txt_GHDK);
            this.groupBox1.Controls.Add(this.txt_MoTa);
            this.groupBox1.Controls.Add(this.txt_DiaDiem);
            this.groupBox1.Controls.Add(this.txt_TrangThai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 242);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // ChinhsuaChuongtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_TaoCT);
            this.Name = "ChinhsuaChuongtrinh";
            this.Text = "Chỉnh sửa chương trình";
            this.Load += new System.EventHandler(this.TaoCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_TaoCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_TaoCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaCT;
        private System.Windows.Forms.TextBox txt_TenCT;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.TextBox txt_LoaiCT;
        private System.Windows.Forms.TextBox txt_DiemCong;
        private System.Windows.Forms.TextBox txt_GHDK;
        private System.Windows.Forms.TextBox txt_DiaDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBDCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKTCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiHanDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCT;
        private System.Windows.Forms.DateTimePicker dt_BD;
        private System.Windows.Forms.DateTimePicker dt_KT;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}