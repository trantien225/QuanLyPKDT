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
    public partial class PhieuNhap : Form
    {
        SqlConnection connection;
        public PhieuNhap()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }
        private void Load_PN()
        {
            //string sqlS = "SELECT MASP,TENSP,SLTON,DONGIA,MANCC FROM SANPHAM";
            string sqlS = "SELECT * FROM PHIEUNHAP";
            SqlDataAdapter da_pn = new SqlDataAdapter(sqlS, connection);
            DataTable PN = new DataTable();
            da_pn.Fill(PN);
            d_grpn.DataSource = PN;
        }
        private void Load_CTPN()
        {
            //string sqlS = "SELECT MASP,TENSP,SLTON,DONGIA,MANCC FROM SANPHAM";
            string sqlS = "SELECT * FROM CTPHIEUNHAP WHERE SOPHIEUNHAP='"+txtsopn.Text+"'";
            SqlDataAdapter da_ctpn = new SqlDataAdapter(sqlS, connection);
            DataTable CTPN = new DataTable();
            da_ctpn.Fill(CTPN);
            d_grctpn.DataSource = CTPN;
        }
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            Load_PN();
        }

        private void d_grpn_Click(object sender, EventArgs e)
        {
            txtghichu.Focus();
            int row;
            row = d_grpn.CurrentCell.RowIndex;
            txtsopn.Text = d_grpn.Rows[row].Cells[0].Value.ToString();
            txtghichu.Text = d_grpn.Rows[row].Cells[4].Value.ToString();
            Load_CTPN();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                    string sqlD = "delete PHIEUNHAP where SOPHIEUNHAP ='" + txtsopn.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Xóa Thành Công");
                    Load_PN();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Xóa không được!!!");
                }
            }   
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlI = "UPDATE PHIEUNHAP SET GHICHU= N'"+txtghichu.Text+ "' where SOPHIEUNHAP ='" + txtsopn.Text + "'";
            SqlCommand sql = new SqlCommand(sqlI, connection);
            sql.ExecuteNonQuery();
            Load_PN();
            MessageBox.Show("Sửa Thành Công");
            connection.Close();
        }

        private void btDong_Click(object sender, EventArgs e)
        {

        }

        private void PhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.No == r)
            {
                e.Cancel = true;
            }
        }
        private void d_grctpn_Click(object sender, EventArgs e)
        {
            //int row;
            //row = d_grpn.CurrentCell.RowIndex;
            //d_grctpn.Rows.RemoveAt(row);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
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
                    int row;
                    row = d_grpn.CurrentCell.RowIndex;
                    d_grctpn.Rows.RemoveAt(row);
                    string sqlD = "delete CTPHIEUNHAP";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    Load_CTPN();
                    MessageBox.Show("Xóa Thành Công");
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Xóa không được!!!");
                }
            }
        }


    }
}
