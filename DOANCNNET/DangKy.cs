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

namespace formMenu
{
    public partial class DangKy : Form
    {
        SqlConnection connection;
        public DangKy()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {
         
        }
        public bool KT_DK()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlS = "select * from NHANVIEN where MANV='" + txtmanv.Text + "'";
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
        private void btDangKi_Click(object sender, EventArgs e)
        {
            if (txtmk.Text.Trim().Length != 0 && txtconfirm.Text == txtmk.Text)
            {
                if (KT_DK() == false)
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string sqlI = "UPDATE  NHANVIEN SET MATKHAU=N'" + txtmk.Text + "'where MANV= N'" + txtmanv.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlI, connection);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí Thành Công");
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!!!");
                }
            }else
            {
                MessageBox.Show("Kiểm tra lại thông tin!!!");
            }    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void txttendn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmanv_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Không được để trống!!!");
            }
            else
                this.errorProvider1.Clear();
            if(txtconfirm.Text!= txtmk.Text)
            {
                this.errorProvider1.SetError(ctr, "Mật Khẩu không trùng khớp!!!");
            }    
        }
    }
}
