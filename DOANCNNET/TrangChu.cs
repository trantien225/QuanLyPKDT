using System;
using DOANCNNET;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formMenu;
using System.Data.SqlClient;

namespace DOANCNNET
{
    public partial class TrangChu : Form
    {
        SqlConnection connection;
        public TrangChu()
        {

            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");


        }

        private void GetMessage(string Message)
        {
            lbnvDN.Text = Message;
        }
        public delegate void SendMessage(string Message);
        public SendMessage Sender;

        public void TrangChu_Load(object sender, EventArgs e)
        {
            Sender = new SendMessage(GetMessage);
            CuaHang ch = new CuaHang();
            ch.MdiParent = this;
            ch.Show();
        }
        public int PQ()
        {
            quanly.Enabled = false;
            return 0;
        }
        private void nhanvien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == r)
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCC ncc = new NhaCC();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SanPham frm = new SanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cuahang_Click(object sender, EventArgs e)
        {
            CuaHang ch=new CuaHang();
            ch.MdiParent = this;
            ch.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HoaDon hd= new HoaDon();
            hd.MdiParent = this;
            hd.Show();
        }

        public void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GioHang gh= new GioHang();
            gh.MdiParent = this;
            gh.Show();
        }

        public void quanly_Click(object sender, EventArgs e)
        {

        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhap pn=new PhieuNhap();
            pn.MdiParent=this;
            pn.Show();
        }

        private void loạiSảnPhầmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiSP lsp=new LoaiSP();
            lsp.MdiParent = this;
            lsp.Show();
        }

        private void txtnhanviendangnhap_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == r)
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
        }
    }
}
