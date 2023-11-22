
namespace QuanLySV5T
{
    partial class QuanLyChuongTrinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_taoCT = new System.Windows.Forms.Button();
            this.dg_QLCT = new System.Windows.Forms.DataGridView();
            this.MaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSSVTG = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LoaiCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nhap = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_QLCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý chương trình";
            // 
            // btn_taoCT
            // 
            this.btn_taoCT.Location = new System.Drawing.Point(501, 125);
            this.btn_taoCT.Name = "btn_taoCT";
            this.btn_taoCT.Size = new System.Drawing.Size(154, 48);
            this.btn_taoCT.TabIndex = 2;
            this.btn_taoCT.Text = "Chỉnh sửa";
            this.btn_taoCT.UseVisualStyleBackColor = true;
            this.btn_taoCT.Click += new System.EventHandler(this.btn_taoCT_Click);
            // 
            // dg_QLCT
            // 
            this.dg_QLCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_QLCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCT,
            this.TenCT,
            this.DSSVTG,
            this.LoaiCT,
            this.TrangThai});
            this.dg_QLCT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_QLCT.Location = new System.Drawing.Point(0, 179);
            this.dg_QLCT.Name = "dg_QLCT";
            this.dg_QLCT.RowHeadersWidth = 51;
            this.dg_QLCT.RowTemplate.Height = 24;
            this.dg_QLCT.Size = new System.Drawing.Size(666, 271);
            this.dg_QLCT.TabIndex = 48;
            this.dg_QLCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_QLCT_CellClick);
            // 
            // MaCT
            // 
            this.MaCT.DataPropertyName = "MaCT";
            this.MaCT.HeaderText = "Mã Chương Trình";
            this.MaCT.MinimumWidth = 6;
            this.MaCT.Name = "MaCT";
            this.MaCT.Width = 125;
            // 
            // TenCT
            // 
            this.TenCT.DataPropertyName = "TenCT";
            this.TenCT.HeaderText = "Tên Chương Trình";
            this.TenCT.MinimumWidth = 6;
            this.TenCT.Name = "TenCT";
            this.TenCT.Width = 125;
            // 
            // DSSVTG
            // 
            this.DSSVTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("High Tower Text", 8.25F);
            this.DSSVTG.DefaultCellStyle = dataGridViewCellStyle1;
            this.DSSVTG.HeaderText = "Danh sách SV TG";
            this.DSSVTG.MinimumWidth = 6;
            this.DSSVTG.Name = "DSSVTG";
            this.DSSVTG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DSSVTG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DSSVTG.Text = "Kick đây nè";
            this.DSSVTG.UseColumnTextForButtonValue = true;
            this.DSSVTG.Width = 120;
            // 
            // LoaiCT
            // 
            this.LoaiCT.DataPropertyName = "LoaiCT";
            this.LoaiCT.HeaderText = "LoaiCT";
            this.LoaiCT.MinimumWidth = 6;
            this.LoaiCT.Name = "LoaiCT";
            this.LoaiCT.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Location = new System.Drawing.Point(34, 125);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(106, 48);
            this.btn_HienThi.TabIndex = 49;
            this.btn_HienThi.Text = "Hiển thị tất cả";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nhập loại CT";
            // 
            // txt_Nhap
            // 
            this.txt_Nhap.Location = new System.Drawing.Point(244, 72);
            this.txt_Nhap.Name = "txt_Nhap";
            this.txt_Nhap.Size = new System.Drawing.Size(139, 22);
            this.txt_Nhap.TabIndex = 51;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(408, 72);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 52;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // QuanLyChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_Nhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.dg_QLCT);
            this.Controls.Add(this.btn_taoCT);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyChuongTrinh";
            this.Text = "Quản lý chương trình";
            this.Load += new System.EventHandler(this.QuanLyChuongTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_QLCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_taoCT;
        private System.Windows.Forms.DataGridView dg_QLCT;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nhap;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCT;
        private System.Windows.Forms.DataGridViewButtonColumn DSSVTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}

