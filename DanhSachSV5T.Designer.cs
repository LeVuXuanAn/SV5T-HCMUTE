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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSV5T));
            panel1 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            btnTimKiem = new Button();
            btnDatLai = new Button();
            panel4 = new Panel();
            cbbNganh = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            cbbLop = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            cbbKhoa = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            cbbNamHoc = new ComboBox();
            label2 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            label6 = new Label();
            dtg1 = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            Hoten = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TenTK = new DataGridViewTextBoxColumn();
            NgayDK = new DataGridViewTextBoxColumn();
            kHOATableAdapterBindingSource = new BindingSource(components);
            dataSet2BindingSource = new BindingSource(components);
            dataSet2BindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kHOATableAdapterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet2BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSet2BindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtg1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 738);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel7);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1279, 276);
            panel8.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel6);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 76);
            panel9.Name = "panel9";
            panel9.Size = new Size(1279, 158);
            panel9.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnTimKiem);
            panel6.Controls.Add(btnDatLai);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel2);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1279, 158);
            panel6.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top;
            btnTimKiem.BackColor = Color.DeepSkyBlue;
            btnTimKiem.BackgroundImage = (Image)resources.GetObject("btnTimKiem.BackgroundImage");
            btnTimKiem.BackgroundImageLayout = ImageLayout.Center;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(848, 106);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(102, 42);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnDatLai
            // 
            btnDatLai.Location = new Point(983, 111);
            btnDatLai.Margin = new Padding(3, 4, 3, 4);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(99, 37);
            btnDatLai.TabIndex = 7;
            btnDatLai.Text = "Reload";
            btnDatLai.UseVisualStyleBackColor = true;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbbNganh);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(644, 7);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(457, 43);
            panel4.TabIndex = 5;
            // 
            // cbbNganh
            // 
            cbbNganh.ForeColor = SystemColors.WindowFrame;
            cbbNganh.FormattingEnabled = true;
            cbbNganh.Location = new Point(126, 7);
            cbbNganh.Margin = new Padding(3, 4, 3, 4);
            cbbNganh.Name = "cbbNganh";
            cbbNganh.Size = new Size(312, 28);
            cbbNganh.TabIndex = 2;
            cbbNganh.SelectedIndexChanged += cbbNganh_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 8);
            label4.Name = "label4";
            label4.Size = new Size(95, 29);
            label4.TabIndex = 1;
            label4.Text = "Ngành:";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbbLop);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(644, 60);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(457, 43);
            panel5.TabIndex = 4;
            // 
            // cbbLop
            // 
            cbbLop.ForeColor = SystemColors.WindowFrame;
            cbbLop.FormattingEnabled = true;
            cbbLop.Location = new Point(126, 7);
            cbbLop.Margin = new Padding(3, 4, 3, 4);
            cbbLop.Name = "cbbLop";
            cbbLop.Size = new Size(312, 28);
            cbbLop.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 7);
            label5.Name = "label5";
            label5.Size = new Size(67, 29);
            label5.TabIndex = 1;
            label5.Text = "Lớp:";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbbKhoa);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(179, 60);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(457, 43);
            panel3.TabIndex = 4;
            // 
            // cbbKhoa
            // 
            cbbKhoa.ForeColor = SystemColors.WindowFrame;
            cbbKhoa.FormattingEnabled = true;
            cbbKhoa.Location = new Point(126, 8);
            cbbKhoa.Margin = new Padding(3, 4, 3, 4);
            cbbKhoa.Name = "cbbKhoa";
            cbbKhoa.Size = new Size(310, 28);
            cbbKhoa.TabIndex = 2;
            cbbKhoa.SelectedIndexChanged += cbbKhoa_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 8);
            label3.Name = "label3";
            label3.Size = new Size(80, 29);
            label3.TabIndex = 1;
            label3.Text = "Khoa:";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbNamHoc);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(179, 7);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 43);
            panel2.TabIndex = 3;
            // 
            // cbbNamHoc
            // 
            cbbNamHoc.ForeColor = SystemColors.WindowFrame;
            cbbNamHoc.FormattingEnabled = true;
            cbbNamHoc.Location = new Point(126, 9);
            cbbNamHoc.Margin = new Padding(3, 4, 3, 4);
            cbbNamHoc.Name = "cbbNamHoc";
            cbbNamHoc.Size = new Size(310, 28);
            cbbNamHoc.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 11);
            label2.Name = "label2";
            label2.Size = new Size(121, 29);
            label2.TabIndex = 1;
            label2.Text = "Năm học:";
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.BackColor = Color.DeepSkyBlue;
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1279, 76);
            panel7.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(379, 6);
            label1.Name = "label1";
            label1.Size = new Size(518, 70);
            label1.TabIndex = 0;
            label1.Text = "SINH VIÊN 5 TỐT";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 283);
            label6.Name = "label6";
            label6.Size = new Size(246, 19);
            label6.TabIndex = 9;
            label6.Text = "DANH SÁCH SINH VIÊN 5 TỐT";
            // 
            // dtg1
            // 
            dtg1.BackgroundColor = SystemColors.ButtonHighlight;
            dtg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg1.Columns.AddRange(new DataGridViewColumn[] { MaSV, Hoten, NgaySinh, GioiTinh, DiaChi, SDT, Email, TenTK, NgayDK });
            dtg1.Dock = DockStyle.Bottom;
            dtg1.Location = new Point(0, 306);
            dtg1.Margin = new Padding(3, 4, 3, 4);
            dtg1.Name = "dtg1";
            dtg1.RowHeadersWidth = 51;
            dtg1.RowTemplate.Height = 25;
            dtg1.Size = new Size(1279, 432);
            dtg1.TabIndex = 8;
            dtg1.CellContentClick += dtg1_CellContentClick;
            // 
            // MaSV
            // 
            MaSV.DataPropertyName = "MaSV";
            MaSV.HeaderText = "MSSV";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.Width = 70;
            // 
            // Hoten
            // 
            Hoten.DataPropertyName = "HoTen";
            Hoten.HeaderText = "HỌ TÊN";
            Hoten.MinimumWidth = 6;
            Hoten.Name = "Hoten";
            Hoten.Width = 160;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "NGÀY SINH";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 120;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "GIỚI TÍNH";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 110;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "ĐỊA CHỈ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 150;
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
            Email.Width = 160;
            // 
            // TenTK
            // 
            TenTK.DataPropertyName = "TenTK";
            TenTK.HeaderText = "TÊN TÀI KHOẢN";
            TenTK.MinimumWidth = 6;
            TenTK.Name = "TenTK";
            TenTK.Width = 160;
            // 
            // NgayDK
            // 
            NgayDK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayDK.DataPropertyName = "NgayDK";
            NgayDK.HeaderText = "NGÀY ĐĂNG KÝ";
            NgayDK.MinimumWidth = 6;
            NgayDK.Name = "NgayDK";
            // 
            // DanhSachSV5T
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1274, 732);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DanhSachSV5T";
            Text = "Danh sách sinh viên 5 tốt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kHOATableAdapterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet2BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSet2BindingSource1).EndInit();
            ResumeLayout(false);
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