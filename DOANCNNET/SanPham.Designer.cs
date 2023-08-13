
namespace DOANCNNET
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.dgr_sp = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.btSua = new System.Windows.Forms.ToolStripButton();
            this.btLuu = new System.Windows.Forms.ToolStripButton();
            this.btDong = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbgiaban = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTENSP = new System.Windows.Forms.TextBox();
            this.txtMASP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNCCSP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.lbtaomapn = new System.Windows.Forms.Label();
            this.txtTongTienNH = new System.Windows.Forms.TextBox();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaBanNH = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbmanh = new System.Windows.Forms.ComboBox();
            this.btNhaphang = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtslnh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_sp)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgr_sp
            // 
            this.dgr_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_sp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgr_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.sl,
            this.gianhap,
            this.giaban});
            this.dgr_sp.Location = new System.Drawing.Point(11, 345);
            this.dgr_sp.Name = "dgr_sp";
            this.dgr_sp.ReadOnly = true;
            this.dgr_sp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_sp.Size = new System.Drawing.Size(855, 233);
            this.dgr_sp.TabIndex = 31;
            this.dgr_sp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_sp_CellContentClick);
            this.dgr_sp.Click += new System.EventHandler(this.dgr_sp_Click);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MASP";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "TENSP";
            this.tensp.HeaderText = "Tên Sản Phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "SLTON";
            this.sl.HeaderText = "Số Lượng";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "GIANHAP";
            this.gianhap.HeaderText = "Giá Nhập";
            this.gianhap.Name = "gianhap";
            this.gianhap.ReadOnly = true;
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "GIABAN";
            this.giaban.HeaderText = "Giá Bán";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 336);
            this.panel1.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaiSP);
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbgiaban);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtTENSP);
            this.groupBox1.Controls.Add(this.txtMASP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(125, 146);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(238, 21);
            this.cbLoaiSP.TabIndex = 39;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btThem,
            this.btXoa,
            this.btSua,
            this.btLuu,
            this.btDong});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip2.Location = new System.Drawing.Point(402, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(20, 30, 10, 10);
            this.toolStrip2.Size = new System.Drawing.Size(141, 317);
            this.toolStrip2.TabIndex = 38;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(73, 25);
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(59, 25);
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(59, 25);
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(59, 25);
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btDong
            // 
            this.btDong.Image = ((System.Drawing.Image)(resources.GetObject("btDong.Image")));
            this.btDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(72, 25);
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại Sản Phẩm";
            // 
            // lbgiaban
            // 
            this.lbgiaban.AutoSize = true;
            this.lbgiaban.Location = new System.Drawing.Point(31, 109);
            this.lbgiaban.Name = "lbgiaban";
            this.lbgiaban.Size = new System.Drawing.Size(45, 13);
            this.lbgiaban.TabIndex = 6;
            this.lbgiaban.Text = "Giá Bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(125, 109);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(238, 20);
            this.txtGiaBan.TabIndex = 4;
            // 
            // txtTENSP
            // 
            this.txtTENSP.Location = new System.Drawing.Point(125, 71);
            this.txtTENSP.Name = "txtTENSP";
            this.txtTENSP.Size = new System.Drawing.Size(238, 20);
            this.txtTENSP.TabIndex = 3;
            // 
            // txtMASP
            // 
            this.txtMASP.Location = new System.Drawing.Point(125, 28);
            this.txtMASP.Name = "txtMASP";
            this.txtMASP.Size = new System.Drawing.Size(238, 20);
            this.txtMASP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // cbNCCSP
            // 
            this.cbNCCSP.FormattingEnabled = true;
            this.cbNCCSP.Location = new System.Drawing.Point(114, 203);
            this.cbNCCSP.Name = "cbNCCSP";
            this.cbNCCSP.Size = new System.Drawing.Size(176, 21);
            this.cbNCCSP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhà CC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmapn);
            this.groupBox2.Controls.Add(this.lbtaomapn);
            this.groupBox2.Controls.Add(this.txtTongTienNH);
            this.groupBox2.Controls.Add(this.lbTongtien);
            this.groupBox2.Controls.Add(this.cbDVT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtGiaBanNH);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbmanh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbNCCSP);
            this.groupBox2.Controls.Add(this.btNhaphang);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtslnh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(558, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 336);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Hàng";
            // 
            // txtmapn
            // 
            this.txtmapn.Enabled = false;
            this.txtmapn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapn.ForeColor = System.Drawing.Color.Red;
            this.txtmapn.Location = new System.Drawing.Point(155, 257);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(135, 22);
            this.txtmapn.TabIndex = 28;
            this.txtmapn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbtaomapn
            // 
            this.lbtaomapn.AutoSize = true;
            this.lbtaomapn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbtaomapn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaomapn.ForeColor = System.Drawing.Color.Red;
            this.lbtaomapn.Location = new System.Drawing.Point(165, 231);
            this.lbtaomapn.Name = "lbtaomapn";
            this.lbtaomapn.Size = new System.Drawing.Size(96, 13);
            this.lbtaomapn.TabIndex = 27;
            this.lbtaomapn.Text = "Tạo phiếu nhập";
            this.lbtaomapn.Click += new System.EventHandler(this.lbtaomapn_Click);
            // 
            // txtTongTienNH
            // 
            this.txtTongTienNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienNH.ForeColor = System.Drawing.Color.Red;
            this.txtTongTienNH.Location = new System.Drawing.Point(6, 257);
            this.txtTongTienNH.Name = "txtTongTienNH";
            this.txtTongTienNH.Size = new System.Drawing.Size(125, 22);
            this.txtTongTienNH.TabIndex = 26;
            this.txtTongTienNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTongTienNH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.Color.Red;
            this.lbTongtien.Location = new System.Drawing.Point(6, 231);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(125, 13);
            this.lbTongtien.TabIndex = 25;
            this.lbTongtien.Text = "Tổng tiền nhập hàng";
            this.lbTongtien.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbDVT
            // 
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Items.AddRange(new object[] {
            "Cái",
            "Chiếc"});
            this.cbDVT.Location = new System.Drawing.Point(114, 47);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(176, 21);
            this.cbDVT.TabIndex = 24;
            this.cbDVT.Text = "Cái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Đơn VT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Giá Bán";
            // 
            // txtGiaBanNH
            // 
            this.txtGiaBanNH.Location = new System.Drawing.Point(114, 166);
            this.txtGiaBanNH.Name = "txtGiaBanNH";
            this.txtGiaBanNH.Size = new System.Drawing.Size(176, 20);
            this.txtGiaBanNH.TabIndex = 21;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(114, 126);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(176, 20);
            this.txtGiaNhap.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Giá Nhập";
            // 
            // cbmanh
            // 
            this.cbmanh.FormattingEnabled = true;
            this.cbmanh.Location = new System.Drawing.Point(114, 11);
            this.cbmanh.Name = "cbmanh";
            this.cbmanh.Size = new System.Drawing.Size(176, 21);
            this.cbmanh.TabIndex = 18;
            this.cbmanh.SelectedIndexChanged += new System.EventHandler(this.cbmanh_SelectedIndexChanged);
            // 
            // btNhaphang
            // 
            this.btNhaphang.BackColor = System.Drawing.SystemColors.Control;
            this.btNhaphang.Location = new System.Drawing.Point(6, 294);
            this.btNhaphang.Name = "btNhaphang";
            this.btNhaphang.Size = new System.Drawing.Size(284, 26);
            this.btNhaphang.TabIndex = 16;
            this.btNhaphang.Text = "Nhập Hàng";
            this.btNhaphang.UseVisualStyleBackColor = false;
            this.btNhaphang.Click += new System.EventHandler(this.btNhaphang_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số Lượng";
            // 
            // txtslnh
            // 
            this.txtslnh.Location = new System.Drawing.Point(114, 85);
            this.txtslnh.Name = "txtslnh";
            this.txtslnh.Size = new System.Drawing.Size(176, 20);
            this.txtslnh.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sản Phẩm";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgr_sp);
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_sp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_sp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtslnh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btNhaphang;
        private System.Windows.Forms.ComboBox cbmanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btThem;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripButton btSua;
        private System.Windows.Forms.ToolStripButton btLuu;
        private System.Windows.Forms.ToolStripButton btDong;
        private System.Windows.Forms.TextBox txtTENSP;
        private System.Windows.Forms.TextBox txtMASP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNCCSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbgiaban;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.ComboBox cbDVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaBanNH;
        private System.Windows.Forms.TextBox txtTongTienNH;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.Label lbtaomapn;
    }
}