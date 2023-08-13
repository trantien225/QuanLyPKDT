
namespace DOANCNNET
{
    partial class CuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuaHang));
            this.dgr_sp = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btthemgiohang = new System.Windows.Forms.Button();
            this.txtslmua = new System.Windows.Forms.TextBox();
            this.lbgiaban = new System.Windows.Forms.Label();
            this.txtMASP = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTENSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btGH = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_sp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.giaban});
            this.dgr_sp.Location = new System.Drawing.Point(11, 282);
            this.dgr_sp.Name = "dgr_sp";
            this.dgr_sp.ReadOnly = true;
            this.dgr_sp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_sp.Size = new System.Drawing.Size(855, 296);
            this.dgr_sp.TabIndex = 32;
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
            // giaban
            // 
            this.giaban.DataPropertyName = "GIABAN";
            this.giaban.HeaderText = "Giá";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btthemgiohang);
            this.groupBox1.Controls.Add(this.txtslmua);
            this.groupBox1.Controls.Add(this.lbgiaban);
            this.groupBox1.Controls.Add(this.txtMASP);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTENSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 239);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Giá";
            // 
            // btthemgiohang
            // 
            this.btthemgiohang.BackColor = System.Drawing.Color.Tan;
            this.btthemgiohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemgiohang.Location = new System.Drawing.Point(120, 201);
            this.btthemgiohang.Name = "btthemgiohang";
            this.btthemgiohang.Size = new System.Drawing.Size(238, 32);
            this.btthemgiohang.TabIndex = 34;
            this.btthemgiohang.Text = "Thêm vào giỏ hàng";
            this.btthemgiohang.UseVisualStyleBackColor = false;
            this.btthemgiohang.Click += new System.EventHandler(this.btthemgiohang_Click);
            // 
            // txtslmua
            // 
            this.txtslmua.Location = new System.Drawing.Point(120, 111);
            this.txtslmua.Name = "txtslmua";
            this.txtslmua.Size = new System.Drawing.Size(238, 20);
            this.txtslmua.TabIndex = 40;
            // 
            // lbgiaban
            // 
            this.lbgiaban.AutoSize = true;
            this.lbgiaban.Location = new System.Drawing.Point(26, 114);
            this.lbgiaban.Name = "lbgiaban";
            this.lbgiaban.Size = new System.Drawing.Size(49, 13);
            this.lbgiaban.TabIndex = 39;
            this.lbgiaban.Text = "Số lượng";
            // 
            // txtMASP
            // 
            this.txtMASP.Enabled = false;
            this.txtMASP.Location = new System.Drawing.Point(120, 33);
            this.txtMASP.Name = "txtMASP";
            this.txtMASP.Size = new System.Drawing.Size(238, 20);
            this.txtMASP.TabIndex = 36;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(120, 156);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(238, 20);
            this.txtGiaBan.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã SP";
            // 
            // txtTENSP
            // 
            this.txtTENSP.Enabled = false;
            this.txtTENSP.Location = new System.Drawing.Point(120, 76);
            this.txtTENSP.Name = "txtTENSP";
            this.txtTENSP.Size = new System.Drawing.Size(238, 20);
            this.txtTENSP.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(483, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 33);
            this.label4.TabIndex = 35;
            this.label4.Text = "Đi đến giỏ hàng để thanh toán";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btGH});
            this.toolStrip2.Location = new System.Drawing.Point(552, 76);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(20, 30, 10, 10);
            this.toolStrip2.Size = new System.Drawing.Size(167, 97);
            this.toolStrip2.TabIndex = 40;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btGH
            // 
            this.btGH.ForeColor = System.Drawing.Color.Red;
            this.btGH.Image = ((System.Drawing.Image)(resources.GetObject("btGH.Image")));
            this.btGH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGH.Name = "btGH";
            this.btGH.Size = new System.Drawing.Size(135, 54);
            this.btGH.Text = "Giỏ Hàng";
            this.btGH.Click += new System.EventHandler(this.btThem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(474, 76);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(20, 30, 10, 10);
            this.toolStrip1.Size = new System.Drawing.Size(86, 97);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
            // 
            // CuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 590);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgr_sp);
            this.Name = "CuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa hàng phụ kiện";
            this.Load += new System.EventHandler(this.CuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_sp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtslmua;
        private System.Windows.Forms.Label lbgiaban;
        private System.Windows.Forms.TextBox txtMASP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTENSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btthemgiohang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btGH;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}