using DOANCNNET;
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
    public partial class DangNhap : Form
    {
        SqlConnection connect;
        TrangChu tc = new TrangChu();
        string pq = "NV001";
        public DangNhap()
        {
            InitializeComponent();
            connect = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy DK = new DangKy();
            DK.Show();
            this.Hide();
        }
        public bool KT_DN()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string sqlS = "select * from NHANVIEN where MANV='" + txtTenDN.Text + "'and MATKHAU='" + txtMK.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlS, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            
            if (rd.HasRows)
            {
                rd.Close();
                connect.Close();
                return false;
            }
            else
            {
                rd.Close();
                connect.Close();
                return true;
            }
     }
        //CHƯA KT ĐƯỢC=========================================================================
        public bool KT_PQ()
        {
            //if (connect.State == ConnectionState.Closed)
            //{
            //    connect.Open();
            //}
            //string sqlSs = "select * from NHANVIEN where CHUCVU= N'Quản Lý' AND MANV='NV001'";
            //SqlCommand cmdd = new SqlCommand(sqlSs, connect);
            //SqlDataReader rdd = cmdd.ExecuteReader();
            //if (rdd.HasRows)
            //{
            //    rdd.Close();
            //    connect.Close();
            //    return false;
            //}
            //else
            //{

            //    rdd.Close();
            //    connect.Close();
            //    return true;
            //}
            if(pq==txtTenDN.Text)
            {
                return true;
            }    
            return false;
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
        }
        private void btDN_Click(object sender, EventArgs e)
        {
            if (KT_DN() == false)
            {
               
                if(KT_PQ()==true)
                {
                    MessageBox.Show("Đăng Nhập Thành công");                  
                    tc.Show();
                    tc.Sender(txtTenDN.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thành công");
                    tc.PQ();
                    tc.Show();
                    tc.Sender(txtTenDN.Text);
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Không đúng Tên người dùng/Mật khẩu!", "Nhập lại!!!");
                txtTenDN.Focus();
                txtTenDN.Clear();
                txtMK.Clear();
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (DialogResult.No == r)
            {
                e.Cancel = true;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
