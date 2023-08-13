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
    public partial class NhaCC : Form
    {
        SanPham sp= new SanPham();
        SqlConnection connection;
        public NhaCC()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }

        private void dgr_sp_Click(object sender, EventArgs e)
        {
            int row;
            row = dgr_ncc.CurrentCell.RowIndex;
            txtMANCC.Text = dgr_ncc.Rows[row].Cells[0].Value.ToString();
            txtTENNCC.Text = dgr_ncc.Rows[row].Cells[1].Value.ToString();
            txtdc.Text = dgr_ncc.Rows[row].Cells[2].Value.ToString();
            txtsdt.Text = dgr_ncc.Rows[row].Cells[3].Value.ToString();
            txtemail.Text = dgr_ncc.Rows[row].Cells[4].Value.ToString();
            btSua.Enabled = true;
        }
        private void Load_NCC()
        {
            string sqlS = "SELECT * FROM NHACUNGCAP";
            SqlDataAdapter da_lsp = new SqlDataAdapter(sqlS, connection);
            DataTable LSP = new DataTable();
            da_lsp.Fill(LSP);
            dgr_ncc.DataSource = LSP;
        }
        private void NhaCC_Load(object sender, EventArgs e)
        {
            Load_NCC();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtTENNCC.Clear();
            txtdc.Clear();
            txtsdt.Clear();
            txtemail.Clear();
            txtTENNCC.Focus();
            Random random = new Random();
            int randomNumber = random.Next(100, 999);
            txtMANCC.Text = "NCC" + randomNumber.ToString();
            btSua.Enabled = false;
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
                    string sqlD = "delete NHACUNGCAP where MANCC ='" + txtMANCC.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    Load_NCC();
                    MessageBox.Show("Xóa Thành Công");
                    txtTENNCC.Clear();
                    txtdc.Clear();
                    txtsdt.Clear();
                    txtemail.Clear();
                    txtTENNCC.Focus();
                    connection.Close();

                }
                catch
                {
                    MessageBox.Show("Không xóa được!!!");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            txtTENNCC.Focus();
        }
        public bool KT_KhoaNCC(string mancc)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlS = "select * from NHACUNGCAP where MANCC='" + mancc + "'";
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
                string sqlI = "UPDATE NHACUNGCAP SET TENNCC=N'" + txtTENNCC.Text + "',DIACHI='"+txtdc.Text+"',SDT='"+txtsdt.Text+"',EMAIL='"+txtemail.Text+"' where MANCC= N'" + txtMANCC.Text + "'";
                SqlCommand sql = new SqlCommand(sqlI, connection);
                sql.ExecuteNonQuery();
                Load_NCC();
                MessageBox.Show("Sửa Thành Công");
                connection.Close();
            }
            else
            {
                try
                {
                    if (txtMANCC.Text.Trim().Length != 0 && txtTENNCC.Text.Trim().Length != 0)
                    {
                        if (KT_KhoaNCC(txtMANCC.Text) == true)
                        {
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }

                            string sqlI = "INSERT INTO NHACUNGCAP VALUES ('" + txtMANCC.Text + "', N'" + txtTENNCC.Text + "',N'"+txtdc.Text+"',"+txtsdt.Text+",N'"+txtemail.Text+"')";
                            SqlCommand sql = new SqlCommand(sqlI, connection);
                            sql.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công");
                            Load_NCC();
                            sp.Load_CB();
                            connection.Close();
                        }
                        else
                        {
                            Random random = new Random();
                            int randomNumber = random.Next(100, 999);
                            MessageBox.Show("Trùng khóa chính");
                            txtMANCC.Text = "NCC" + randomNumber;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhà cung cấp và tên không được để trống!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại!!!");
                }
            }
        }
    }
}
