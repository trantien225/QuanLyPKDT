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
    public partial class LoaiSP : Form
    {
        SanPham sp= new SanPham();
        SqlConnection connection;
        public LoaiSP()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }
        private void Load_LSP()
        {
            string sqlS = "SELECT * FROM LOAISANPHAM";
            SqlDataAdapter da_lsp = new SqlDataAdapter(sqlS, connection);
            DataTable LSP = new DataTable();
            da_lsp.Fill(LSP);
            dgr_lsp.DataSource = LSP;
        }
        private void LoaiSP_Load(object sender, EventArgs e)
        {
            Load_LSP();
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

        private void dgr_sp_Click(object sender, EventArgs e)
        {
            int row;
            row = dgr_lsp.CurrentCell.RowIndex;
            txtMALSP.Text = dgr_lsp.Rows[row].Cells[0].Value.ToString();
            txtTENLSP.Text = dgr_lsp.Rows[row].Cells[1].Value.ToString();
            btSua.Enabled = true;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtTENLSP.Clear();
            txtTENLSP.Focus();
            Random random = new Random();
            int randomNumber = random.Next(100, 999);
            txtMALSP.Text = "L" + randomNumber.ToString();
            btSua.Enabled = false;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            txtTENLSP.Focus();
        }

        public bool KT_KhoaLSP(string malsp)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlS = "select * from LOAISANPHAM where MALOAISP='" + malsp + "'";
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
                string sqlI = "UPDATE LOAISANPHAM SET TENLOAISP=N'" + txtTENLSP.Text + "' where MALOAISP= N'" + txtMALSP.Text + "'";
                SqlCommand sql = new SqlCommand(sqlI, connection);
                sql.ExecuteNonQuery();
                Load_LSP();
                MessageBox.Show("Sửa Thành Công");
                connection.Close();
            }
            else
            {
                try
                {
                    if (txtMALSP.Text.Trim().Length != 0 && txtTENLSP.Text.Trim().Length != 0)
                    {
                        if (KT_KhoaLSP(txtMALSP.Text) == true)
                        {
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }

                            string sqlI = "INSERT LOAISANPHAM (MALOAISP,TENLOAISP) VALUES ('" + txtMALSP.Text + "', N'" + txtTENLSP.Text + "')";
                            SqlCommand sql = new SqlCommand(sqlI, connection);
                            sql.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công");
                            Load_LSP();
                            sp.Load_CB_LoaiSP();
                            connection.Close();
                        }
                        else
                        {
                            Random random = new Random();
                            int randomNumber = random.Next(100, 999);
                            MessageBox.Show("Trùng khóa chính");
                            txtMALSP.Text = "L" + randomNumber;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã loại sản phẩm và tên không được để trống!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại!!!");
                }
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
                    string sqlD = "delete LOAISANPHAM where MALOAISP ='" + txtMALSP.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    Load_LSP();
                    MessageBox.Show("Xóa Thành Công");
                    connection.Close();

                }
                catch
                {
                    MessageBox.Show("Không xóa được!!!");
                }
            }
        }
    }
}
