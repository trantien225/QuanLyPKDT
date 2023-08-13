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
using formMenu;

namespace DOANCNNET
{
    public partial class CuaHang : Form
    {
        SqlConnection connection;
        TrangChu tc=new TrangChu();
        public CuaHang()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }
        private void Load_SP()
        {
            //string sqlS = "SELECT MASP,TENSP,SLTON,DONGIA,MANCC FROM SANPHAM";
            string sqlS = "SELECT MASP,TENSP,SLTON,GIABAN FROM SANPHAM";
            SqlDataAdapter da_sp = new SqlDataAdapter(sqlS, connection);
            DataTable SP = new DataTable();
            da_sp.Fill(SP);
            dgr_sp.DataSource = SP;
        }
        private void CuaHang_Load(object sender, EventArgs e)
        {
            Load_SP();
        }

        private void dgr_sp_Click(object sender, EventArgs e)
        {
            int row;
            row = dgr_sp.CurrentCell.RowIndex;
            txtMASP.Text = dgr_sp.Rows[row].Cells[0].Value.ToString();
            txtTENSP.Text = dgr_sp.Rows[row].Cells[1].Value.ToString();
            txtGiaBan.Text = dgr_sp.Rows[row].Cells[3].Value.ToString();
        }
        public int CreateAutoID()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            //string sqlS = "SELECT MAX(MASP) FROM SANPHAM";
            string sqlS = "SELECT SOHD FROM GIOHANG";
            SqlDataAdapter da_gh = new SqlDataAdapter(sqlS, connection);
            DataTable GH = new DataTable();
            da_gh.Fill(GH);
            int lastID = GH.Rows.Count;
            int newID = lastID + 1;
            return newID;

        }
        private void btthemgiohang_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string sqlI = "INSERT GIOHANG (MANV,MASP,TENSP,SOLUONG,GIABAN) VALUES (N'NV001','" + txtMASP.Text + "',N'"+txtTENSP.Text+"', N'" + txtslmua.Text + "', N'" + txtGiaBan.Text + "')";
            SqlCommand sql = new SqlCommand(sqlI, connection);
            sql.ExecuteNonQuery();
            MessageBox.Show("Thêm Thành Công");
            Load_SP();
            connection.Close();
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            GioHang gh = new GioHang();
            gh.Show();
            this.Hide();
        }
    }
}
