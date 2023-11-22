namespace QuanLySV5T
{
    partial class QuanLyChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChung));
            this.panelBody = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpanel = new System.Windows.Forms.Panel();
            this.btn_GopY = new System.Windows.Forms.Button();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.btn_TichLuy = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBody.SuspendLayout();
            this.btnpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBody.BackgroundImage")));
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Location = new System.Drawing.Point(0, 84);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1578, 762);
            this.panelBody.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnpanel
            // 
            this.btnpanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnpanel.Controls.Add(this.label3);
            this.btnpanel.Controls.Add(this.label2);
            this.btnpanel.Controls.Add(this.btn_GopY);
            this.btnpanel.Controls.Add(this.btn_TrangChu);
            this.btnpanel.Controls.Add(this.btn_TichLuy);
            this.btnpanel.Controls.Add(this.btn_TraCuu);
            this.btnpanel.Controls.Add(this.btn_DangXuat);
            this.btnpanel.Controls.Add(this.pictureBox1);
            this.btnpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpanel.Location = new System.Drawing.Point(0, 0);
            this.btnpanel.Name = "btnpanel";
            this.btnpanel.Size = new System.Drawing.Size(1578, 86);
            this.btnpanel.TabIndex = 1;
            // 
            // btn_GopY
            // 
            this.btn_GopY.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_GopY.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_GopY.FlatAppearance.BorderSize = 0;
            this.btn_GopY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GopY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GopY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GopY.Image = ((System.Drawing.Image)(resources.GetObject("btn_GopY.Image")));
            this.btn_GopY.Location = new System.Drawing.Point(732, 0);
            this.btn_GopY.Name = "btn_GopY";
            this.btn_GopY.Size = new System.Drawing.Size(170, 84);
            this.btn_GopY.TabIndex = 3;
            this.btn_GopY.Text = "Góp ý";
            this.btn_GopY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_GopY.UseVisualStyleBackColor = true;
            this.btn_GopY.Click += new System.EventHandler(this.btn_GopY_Click);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_TrangChu.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_TrangChu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TrangChu.FlatAppearance.BorderSize = 0;
            this.btn_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu.Image")));
            this.btn_TrangChu.Location = new System.Drawing.Point(902, 0);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(170, 84);
            this.btn_TrangChu.TabIndex = 0;
            this.btn_TrangChu.Text = "Trang chủ";
            this.btn_TrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TrangChu.UseVisualStyleBackColor = true;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_TichLuy
            // 
            this.btn_TichLuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TichLuy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_TichLuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TichLuy.FlatAppearance.BorderSize = 0;
            this.btn_TichLuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TichLuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TichLuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TichLuy.Image = ((System.Drawing.Image)(resources.GetObject("btn_TichLuy.Image")));
            this.btn_TichLuy.Location = new System.Drawing.Point(1072, 0);
            this.btn_TichLuy.Name = "btn_TichLuy";
            this.btn_TichLuy.Size = new System.Drawing.Size(170, 84);
            this.btn_TichLuy.TabIndex = 2;
            this.btn_TichLuy.Text = "Tích lũy";
            this.btn_TichLuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TichLuy.UseVisualStyleBackColor = true;
            this.btn_TichLuy.Click += new System.EventHandler(this.btn_TichLuy_Click);
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_TraCuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TraCuu.FlatAppearance.BorderSize = 0;
            this.btn_TraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraCuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TraCuu.Image")));
            this.btn_TraCuu.Location = new System.Drawing.Point(1242, 0);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(164, 84);
            this.btn_TraCuu.TabIndex = 1;
            this.btn_TraCuu.Text = "Tra cứu";
            this.btn_TraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TraCuu.UseVisualStyleBackColor = true;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Image")));
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_DangXuat.Location = new System.Drawing.Point(1406, 0);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(170, 84);
            this.btn_DangXuat.TabIndex = 0;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gotham Ultra", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "HỆ THỐNG THEO DÕI QUÁ TRÌNH TÍCH LŨY TIÊU CHÍ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Gotham Bold", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(185, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "SINH VIÊN 5 TỐT HCMUTE";
            // 
            // QuanLyChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.btnpanel);
            this.Controls.Add(this.panelBody);
            this.Name = "QuanLyChung";
            this.Text = "QUẢN LÝ SINH VIÊN 5 TỐT ";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.btnpanel.ResumeLayout(false);
            this.btnpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel btnpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Button btn_TichLuy;
        private System.Windows.Forms.Button btn_TraCuu;
        private System.Windows.Forms.Button btn_GopY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

