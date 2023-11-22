
namespace QuanLySV5T
{
    partial class DSSVTG
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
            this.dg_DS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DS)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_DS
            // 
            this.dg_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.HoTen,
            this.MaSV,
            this.TrangThai,
            this.DiemDanh});
            this.dg_DS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_DS.Location = new System.Drawing.Point(0, 124);
            this.dg_DS.Name = "dg_DS";
            this.dg_DS.RowHeadersWidth = 51;
            this.dg_DS.RowTemplate.Height = 24;
            this.dg_DS.Size = new System.Drawing.Size(689, 326);
            this.dg_DS.TabIndex = 0;
            this.dg_DS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_DS_CellFormatting);
            this.dg_DS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DS_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách Sinh viên Tham gia Chương trình";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên Sinh Viên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // DiemDanh
            // 
            this.DiemDanh.HeaderText = "Điểm Danh";
            this.DiemDanh.MinimumWidth = 6;
            this.DiemDanh.Name = "DiemDanh";
            this.DiemDanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DiemDanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DiemDanh.Width = 125;
            // 
            // DSSVTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_DS);
            this.Name = "DSSVTG";
            this.Text = "DSSVTG";
            this.Load += new System.EventHandler(this.DSSVTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_DS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DiemDanh;
    }
}