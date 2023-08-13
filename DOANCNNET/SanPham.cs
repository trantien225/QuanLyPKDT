using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCNNET
{
    public partial class SanPham : Form
    {
        SqlConnection connection;
        TrangChu TC=new TrangChu();
        public SanPham()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
            btLuu.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            txtGiaBan.Enabled = false;
            txtMASP.Enabled = false;
            txtTENSP.Enabled = false;
            cbLoaiSP.Enabled = false;
        }
        private void Load_SP()
        {
            //string sqlS = "SELECT MASP,TENSP,SLTON,DONGIA,MANCC FROM SANPHAM";
            string sqlS = "SELECT MASP,TENSP,SLTON,GIANHAP,GIABAN,TENLOAISP AS N'Loại Sản Phẩm',TENNCC AS N'Nhà Cung Cấp' FROM SANPHAM,NHACUNGCAP,LOAISANPHAM WHERE SANPHAM.MANCC=NHACUNGCAP.MANCC AND SANPHAM.MALOAISP=LOAISANPHAM.MALOAISP";
            SqlDataAdapter da_sp = new SqlDataAdapter(sqlS, connection);
            DataTable SP = new DataTable();
            cbNCCSP.DisplayMember = "TENNCC";
            cbNCCSP.ValueMember = "MANCC";
            da_sp.Fill(SP);
            dgr_sp.DataSource = SP;
        }
        public void Load_CB()
        {
            string sqlS = "Select * from NHACUNGCAP";
            SqlDataAdapter da_ncc = new SqlDataAdapter(sqlS, connection);
            DataTable NCC = new DataTable();
            da_ncc.Fill(NCC);
            cbNCCSP.DataSource = NCC;
            cbNCCSP.DisplayMember = "TENNCC";
            cbNCCSP.ValueMember = "MANCC";
        }
        public void Load_CB_LoaiSP()
        {
            string sqlS = "Select * from LOAISANPHAM";
            SqlDataAdapter da_lsp = new SqlDataAdapter(sqlS, connection);
            DataTable LSP = new DataTable();
            da_lsp.Fill(LSP);
            cbLoaiSP.DataSource = LSP;
            cbLoaiSP.DisplayMember = "TENLOAISP";
            cbLoaiSP.ValueMember = "MALOAISP";
        }

        private void Load_MSPNH()
        {
            string sqlS = "Select * from SANPHAM";
            SqlDataAdapter da_nsp = new SqlDataAdapter(sqlS, connection);
            DataTable NSP = new DataTable();
            da_nsp.Fill(NSP);
            cbmanh.DataSource = NSP;
            cbmanh.ValueMember = "MASP";

        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            Load_SP();
            Load_CB();
            Load_MSPNH();
            Load_CB_LoaiSP();
        }

        public int CreateAutoID()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            //string sqlS = "SELECT MAX(MASP) FROM SANPHAM";
            string sqlS = "SELECT MASP FROM SANPHAM";
            SqlDataAdapter da_nsp = new SqlDataAdapter(sqlS, connection);
            DataTable SP = new DataTable();
            da_nsp.Fill(SP);
            int lastID = SP.Rows.Count;
            int newID = lastID + 1;
            return newID;

        }
        private void btThem_Click(object sender, EventArgs e)
        {
            txtslnh.Clear();
            txtGiaNhap.Clear();
            txtGiaBanNH.Clear();
            btLuu.Enabled = true;
            txtTENSP.Enabled = true;
            cbLoaiSP.Enabled = true;
            txtGiaNhap.Enabled = true;
            txtGiaBanNH.Enabled = true;
            cbDVT.Enabled = true;
            txtslnh.Enabled = true;
            cbNCCSP.Enabled = true;
            cbmanh.Enabled = true;
            btSua.Enabled = false;
            //txtMASP.Clear();
            txtMASP.Focus();
            txtTENSP.Clear();
            txtGiaBan.Clear();


            if (CreateAutoID() <= 9)
            {
                txtMASP.Text = "SP00" + CreateAutoID();
            }
            else if (CreateAutoID() > 9)
            {
                txtMASP.Text = "SP0" + CreateAutoID();
            }
            else if (CreateAutoID() > 99)
            {
                txtMASP.Text = "SP" + CreateAutoID();
            }
        }

        private void dgr_sp_Click(object sender, EventArgs e)
        {
            int row;
            row = dgr_sp.CurrentCell.RowIndex;
            txtMASP.Text = dgr_sp.Rows[row].Cells[0].Value.ToString();
            cbmanh.Text = dgr_sp.Rows[row].Cells[0].Value.ToString();
            txtTENSP.Text = dgr_sp.Rows[row].Cells[1].Value.ToString();
            txtGiaNhap.Text = dgr_sp.Rows[row].Cells[3].Value.ToString();
            txtGiaBan.Text = dgr_sp.Rows[row].Cells[4].Value.ToString();
            txtGiaBanNH.Text = dgr_sp.Rows[row].Cells[4].Value.ToString();
            cbLoaiSP.Text = dgr_sp.Rows[row].Cells[5].Value.ToString();
            cbNCCSP.Text = dgr_sp.Rows[row].Cells[6].Value.ToString();
            txtslnh.Focus();
            btSua.Enabled = true;
            btXoa.Enabled = true;
            txtslnh.Enabled = true;
            btLuu.Enabled = false;
            txtGiaBan.Enabled = false;
            txtMASP.Enabled = false;
            txtTENSP.Enabled = false;
            cbLoaiSP.Enabled = false;
            txtGiaNhap.Enabled = false;
            txtGiaBanNH.Enabled = false;
            cbDVT.Enabled = false;
            cbNCCSP.Enabled = false;

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.Yes == r)
            {
                this.Hide();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.Yes == r)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string sqlD = "delete SANPHAM where MASP ='" + txtMASP.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    Load_SP();
                    Load_MSPNH();
                    txtslnh.Enabled = false;
                    btLuu.Enabled = false;
                    txtGiaBan.Enabled = false;
                    txtMASP.Enabled = false;
                    txtTENSP.Enabled = false;
                    cbLoaiSP.Enabled = false;
                    txtGiaNhap.Enabled = false;
                    txtGiaBanNH.Enabled = false;
                    cbDVT.Enabled = false;
                    cbNCCSP.Enabled = false;
                    btNhaphang.Enabled = false;
                    txtTongTienNH.Enabled = false;
                    btSua.Enabled = false;
                    MessageBox.Show("Xóa Thành Công");
                    connection.Close();
                    btXoa.Enabled = false;


                }
                catch
                {
                    MessageBox.Show("Xóa không được!!!");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            txtGiaBan.Enabled = true;
            txtTENSP.Enabled = true;
            txtslnh.Enabled = false;
            cbmanh.Enabled = false;
            btNhaphang.Enabled = false;
            txtTongTienNH.Enabled = false;
            btLuu.Enabled = true;
            txtTENSP.Focus();

        }
        public bool KT_KhoaSP(string masp)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlS = "select * from SANPHAM where MASP='" + masp + "'";
            SqlCommand cmd = new SqlCommand(sqlS, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                connection.Close();
                return false;
            }
            else
            {
                rd.Close();
                connection.Close();
                return true;
            }
        }
        private void btLuu_Click(object sender, EventArgs e)
        {

            if (btSua.Enabled == true)
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sqlI = "UPDATE SANPHAM SET TENSP=N'" + txtTENSP.Text + "',GIABAN='" + txtGiaBan.Text + "' where MASP= N'" + txtMASP.Text + "'";
                SqlCommand sql = new SqlCommand(sqlI, connection);
                sql.ExecuteNonQuery();
                Load_SP();
                MessageBox.Show("Sửa Thành Công");
                txtTENSP.Enabled = false;
                txtGiaBan.Enabled = false;
                cbmanh.Enabled = true;
                connection.Close();
            }
            else
            {
                try
                {
                    if (txtMASP.Text.Trim().Length != 0 && txtTENSP.Text.Trim().Length != 0)
                    {
                        if (KT_KhoaSP(txtMASP.Text) == true)
                        {
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }

                            string sqlI = "INSERT SANPHAM (MASP,TENSP,SLTON,GIANHAP,GIABAN,MALOAISP) VALUES ('" + txtMASP.Text + "', N'" + txtTENSP.Text + "','0','0','0', N'" + cbLoaiSP.SelectedValue.ToString() + "')";
                            SqlCommand sql = new SqlCommand(sqlI, connection);
                            sql.ExecuteNonQuery();
                            Load_MSPNH();
                            MessageBox.Show("Thêm Thành Công");
                            Load_SP();
                            connection.Close();
                        }
                        else
                        {
                            Random random = new Random();
                            int randomNumber = random.Next(100, 999);
                            MessageBox.Show("Trùng khóa chính");
                            txtMASP.Text = "SP" + randomNumber;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm và tên không được để trống!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại!!!");
                }

            }

        }
        public bool KT_PN(string mapn)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlS = "select * from PHIEUNHAP where SOPHIEUNHAP='" + mapn + "'";
            SqlCommand cmd = new SqlCommand(sqlS, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                connection.Close();
                return false;
            }
            else
            {
                rd.Close();
                connection.Close();
                return true;
            }
        }
        private void btNhaphang_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sqlD = "UPDATE SANPHAM SET DVT='" + cbDVT.SelectedItem.ToString() + "',SLTON = SLTON + '" + txtslnh.Text + "',GIANHAP=GIANHAP + '" + txtGiaNhap.Text + "'- GIANHAP,GIABAN=GIABAN+ '" + txtGiaBanNH.Text + "'- GIABAN,MANCC='" + cbNCCSP.SelectedValue.ToString() + "' WHERE MASP='" + cbmanh.SelectedValue.ToString() + "'";
                SqlCommand sql = new SqlCommand(sqlD, connection);
                sql.ExecuteNonQuery();
                Load_SP();
                connection.Close();

                    if (KT_PN(txtmapn.Text) == true)
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        string sqlI = "INSERT INTO PHIEUNHAP VALUES('" + txtmapn.Text + "', '" + date + "', N'NV001', N'"+cbNCCSP.SelectedValue.ToString()+"', NULL)";
                        SqlCommand sql1 = new SqlCommand(sqlI, connection);
                        sql1.ExecuteNonQuery();
                        MessageBox.Show("Đã nhập hàng");
                        connection.Close();

                    }

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sqlI2 = "INSERT INTO CTPHIEUNHAP VALUES('" + txtmapn.Text + "', '" + cbmanh.SelectedValue.ToString() + "','" + txtslnh.Text + "', '" + txtGiaNhap.Text + "', '" + CK().ToString() + "')";
                SqlCommand sql3 = new SqlCommand(sqlI2, connection);
                sql3.ExecuteNonQuery();
                connection.Close();
                txtslnh.Clear();
                txtGiaNhap.Clear();
                txtGiaBanNH.Clear();
                txtTongTienNH.Clear();

            }
            catch
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sqlI1 = "INSERT INTO CTPHIEUNHAP VALUES('" + txtmapn.Text + "', '" + cbmanh.SelectedValue.ToString() + "','" + txtslnh.Text + "', '" + txtGiaNhap.Text + "', '" + CK().ToString() + "')";
                SqlCommand sql2 = new SqlCommand(sqlI1, connection);
                sql2.ExecuteNonQuery();
                connection.Close();
                txtslnh.Clear();
                txtGiaNhap.Clear();
                txtGiaBanNH.Clear();
                txtTongTienNH.Clear();
            }
        }
        public double CK()
        {
            double tck;
            double ck = double.Parse(txtTongTienNH.Text);
            if (double.Parse(txtslnh.Text) >10)
            {
                tck = ck * 0.1; 
                return tck;
            }
            return 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgr_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbmanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaNhap.Enabled = true;
            txtGiaBanNH.Enabled = true;
            cbDVT.Enabled = true;
            txtslnh.Enabled = true;
            cbNCCSP.Enabled = true;
            cbmanh.Enabled = true;
            btSua.Enabled = false;
            txtslnh.Clear();
            txtGiaNhap.Clear();
            txtGiaBanNH.Clear();
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtslnh.Text);
            int gn = int.Parse(txtGiaNhap.Text);
            int Tong;
            Tong = sl * gn;
            txtTongTienNH.Text = Tong.ToString();

        }

        private void lbtaomapn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100, 999);
            txtmapn.Text = "PN"+randomNumber.ToString();
        }
    }
}
