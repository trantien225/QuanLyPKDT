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
using DOANCNNET;
namespace formMenu
{
    public partial class GioHang : Form
    {
        SqlConnection connection;
        public GioHang()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }

        private void dgr_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Load_GH()
        {
            string sqlS = "SELECT MASP,TENSP,SOLUONG,GIABAN FROM GIOHANG";
            SqlDataAdapter da_gh = new SqlDataAdapter(sqlS, connection);
            DataTable GH = new DataTable();
            da_gh.Fill(GH);
            dgr_sp.DataSource = GH;
        }
        private void GioHang_Load(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            Load_GH();
        }
        public double CK()
        {
            double tck;
            double ck = double.Parse(txttongtien.Text);
            if (double.Parse(txtslmua.Text) > 10)
            {
                tck = ck * 0.1;
                return tck;
            }
            return 0;
        }
        //public double TT()
        //{
        //    double t;
        //    double tt = double.Parse(txtthanhtien.Text);
        //    t = tt - CK();
        //    return t;

        //}
        private void label6_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(txtslmua.Text);
            int gn = int.Parse(txtGiaBan.Text);
            
            int Tong,thanhtien;
            Tong = sl * gn;
            txttongtien.Text = Tong.ToString();
            int tong= int.Parse(txttongtien.Text);
            thanhtien = (int)(tong - CK());
            ThanhTien.Text=thanhtien.ToString();
        }

        private void dgr_sp_Click(object sender, EventArgs e)
        {
            int row;
            row = dgr_sp.CurrentCell.RowIndex;
            txtMASP.Text = dgr_sp.Rows[row].Cells[0].Value.ToString();
            txtTENSP.Text = dgr_sp.Rows[row].Cells[1].Value.ToString();
            txtslmua.Text = dgr_sp.Rows[row].Cells[2].Value.ToString();
            txtGiaBan.Text = dgr_sp.Rows[row].Cells[3].Value.ToString();
            btXoa.Enabled = true;
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
                    string sqlD = "delete GIOHANG where MASP ='" + txtMASP.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    Load_GH();
                    MessageBox.Show("Xóa Thành Công");
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Xóa không được!!!");
                }
            }
        }
        public bool KT_HD(string sohd)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlS = "select * from HOADON where SOHD='" + sohd + "'";
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
        private void btMua_Click(object sender, EventArgs e)
        {
            if (txtKH.Text.Trim().Length != 0 && txtDC.Text.Trim().Length != 0 && txtSDT.Text.Trim().Length != 0)
            {
                DateTime date = DateTime.Now;
                try
                {
                    if (KT_HD(txtSOHD.Text) == true)
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }
                        string sqlI = "INSERT INTO HOADON VALUES('"+txtSOHD.Text+"','"+date+"','"+ThanhTien.Text+"',N'"+txtKH.Text+"',N'"+txtDC.Text+"','"+txtSDT.Text+"')";
                        SqlCommand sql1 = new SqlCommand(sqlI, connection);
                        sql1.ExecuteNonQuery();
                        //MessageBox.Show("Thanh toán thành công!!!");
                        connection.Close();

                    }

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string sqlI2 = "INSERT INTO CTHOADON VALUES('" + txtSOHD.Text + "', '" + txtMASP.Text + "'," + txtslmua.Text + ", " + txtGiaBan.Text + ", " + CK().ToString() + ","+ThanhTien.Text+")";
                    SqlCommand sql3 = new SqlCommand(sqlI2, connection);
                    sql3.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    string sqlD = "delete GIOHANG where MASP ='" + txtMASP.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    Load_GH();
                    connection.Close();
                    txtTENSP.Clear();
                    txtMASP.Clear();
                    txtslmua.Clear();
                    txtGiaBan.Clear();
                    txttongtien.Clear();

                }
                catch
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string sqlI1 = "INSERT INTO CTHOADON VALUES('" + txtSOHD.Text + "', '" + txtMASP.Text + "','" + txtslmua.Text + "', '" + txtGiaBan.Text + "', '" + CK().ToString() + "'," + ThanhTien.Text+")";
                    SqlCommand sql2 = new SqlCommand(sqlI1, connection);
                    sql2.ExecuteNonQuery();
                    string sqlU = "UPDATE HOADON SET TONGTIEN = TONGTIEN +'"+ThanhTien.Text+"' WHERE SOHD='"+txtSOHD.Text+"'";
                    SqlCommand sql4 = new SqlCommand(sqlU, connection);
                    sql4.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!!!");
                    string sqlD = "delete GIOHANG where MASP ='" + txtMASP.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    Load_GH();
                    connection.Close();
                    txtTENSP.Clear();
                    txtMASP.Clear();
                    txtslmua.Clear();
                    txtGiaBan.Clear();
                    txttongtien.Clear();

                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin khách hàng!!!");
            }
        }

        private void txtKH_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Không được để trống!!!");
            }
            else
                this.errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100, 999);
            txtSOHD.Text = "HD" + randomNumber.ToString();
        }
    }
}
