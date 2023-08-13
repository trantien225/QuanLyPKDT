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
    public partial class NhanVien : Form
    {
        SqlConnection connection;
        public NhanVien()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            Load_NV();
            txtMaNV.Enabled = false;
            txtHTNV.Enabled = false;
            txtMK.Enabled = false;
            txtSDT.Enabled = false;
            txtTDN.Enabled= false;
            maskedTextBox1.Enabled = false;
            cbNV.Enabled= false;
            cbChucVu.Enabled = false;
        }
        public int CreateAutoID()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlS = "SELECT MANV FROM NHANVIEN";
            SqlDataAdapter da_nv = new SqlDataAdapter(sqlS, connection);
            DataTable NV = new DataTable();
            da_nv.Fill(NV);
            int lastID = NV.Rows.Count;
            int newID = lastID + 1;
            return newID;

        }
        private void Load_NV()
        {
            string sqlS = "SELECT MANV,TENNV,GIOITINH,FORMAT(NGAYSINH, 'dd/MM/yyyy') AS NGAYSINH,SDT,CHUCVU AS N'Chức Vụ',TENDN,MATKHAU FROM NHANVIEN";
            SqlDataAdapter da_nv = new SqlDataAdapter(sqlS, connection);
            DataTable NV = new DataTable();
            da_nv.Fill(NV);
            dgr_nv.DataSource = NV;
        }

        private void dgr_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgr_nv_Click(object sender, EventArgs e)
        {
            
            int row;
            row = dgr_nv.CurrentCell.RowIndex;
            txtMaNV.Text = dgr_nv.Rows[row].Cells[0].Value.ToString();
            txtHTNV.Text = dgr_nv.Rows[row].Cells[1].Value.ToString();
            cbNV.Text = dgr_nv.Rows[row].Cells[2].Value.ToString();
            maskedTextBox1.Text = dgr_nv.Rows[row].Cells[3].Value.ToString();
            txtSDT.Text = dgr_nv.Rows[row].Cells[4].Value.ToString();
            cbChucVu.Text= dgr_nv.Rows[row].Cells[5].Value.ToString();
            txtTDN.Text= dgr_nv.Rows[row].Cells[6].Value.ToString();
            txtMK.Text= dgr_nv.Rows[row].Cells[7].Value.ToString();
            btSua.Enabled = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string sqlS = "SELECT MANV,TENNV,GIOITINH,NGAYSINH,SDT FROM NHANVIEN WHERE MANV='" + txtTim.Text + "'";
            SqlDataAdapter da_nv = new SqlDataAdapter(sqlS, connection);
            DataTable NV = new DataTable();
            da_nv.Fill(NV);
            dgr_nv.DataSource = NV;
        }
        public bool KT_KhoaNV(string manv)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string sqlS = "select * from NHANVIEN where MANV='" + manv + "'";
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
        private void btThem_Click(object sender, EventArgs e)
        {
            txtHTNV.Clear();
            txtHTNV.Focus();
            txtTDN.Text = txtMaNV.Text;
            txtMaNV.Enabled=false;
            txtHTNV.Enabled = true;
            txtMK.Enabled = true;
            txtSDT.Enabled = true;
            maskedTextBox1.Enabled = true;
            cbNV.Enabled = true;
            cbChucVu.Enabled = true;
            txtSDT.Clear();
            txtMK.Clear();
            maskedTextBox1.Clear();
            btSua.Enabled = false;
            cbChucVu.Text = "";

            if (CreateAutoID() <= 9)
            {
                txtMaNV.Text = "SP00" + CreateAutoID();
            }
            else if (CreateAutoID() > 9)
            {
                txtMaNV.Text = "SP0" + CreateAutoID();
            }
            else if (CreateAutoID() > 99)
            {
                txtMaNV.Text = "SP" + CreateAutoID();
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
                    string sqlD = "delete NHANVIEN where MANV ='" + txtMaNV.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    Load_NV();
                    MessageBox.Show("Xóa Thành Công");
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
            txtMK.Enabled = true;
            txtHTNV.Enabled = true;
            txtSDT.Enabled = true;
            cbChucVu.Enabled = true;
            cbNV.Enabled = true;
            maskedTextBox1.Enabled = true;
            txtHTNV.Focus();
           
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            string strdate = DateTime.ParseExact(maskedTextBox1.Text, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            if (btSua.Enabled == true)
            {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string sqlI = "UPDATE  NHANVIEN SET TENNV=N'" + txtHTNV.Text + "',GIOITINH=N'"+cbNV.SelectedItem.ToString()+"',NGAYSINH='"+strdate+"',SDT='"+txtSDT.Text+"',CHUCVU=N'"+cbChucVu.SelectedItem.ToString()+"',TENDN=N'"+txtTDN.Text+"',MATKHAU='"+txtMK.Text+"'  where MANV= N'" + txtMaNV.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlI, connection);
                    sql.ExecuteNonQuery();
                    Load_NV();
                    MessageBox.Show("Sửa Thành Công");
                    connection.Close();
            }
            else
            {
                try
                {
                    if (txtMaNV.Text.Trim().Length != 0 && txtHTNV.Text.Trim().Length != 0)
                    {
                        if (KT_KhoaNV(txtMaNV.Text) == true)
                        {
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            //string sqlI = "INSERT NHANVIEN (MANV,TENNV,GIOITINH,NGAYSINH,SDT) VALUES (N'" + txtMaNV.Text + "', N'" + txtHTNV.Text + "','"+cbNV.SelectedItem.ToString()+"',N'08/08/2002','0978264832')";
                            string sqlI = "INSERT NHANVIEN (MANV,TENNV,GIOITINH,NGAYSINH,SDT,CHUCVU,TENDN,MATKHAU) VALUES ('" + txtMaNV.Text + "', N'" + txtHTNV.Text + "',N'" + cbNV.SelectedItem.ToString() + "','" + strdate + "',N'" + txtSDT.Text + "',N'"+cbChucVu.SelectedItem.ToString()+"',N'"+txtTDN.Text+"',N'"+txtMK.Text+"')";
                            SqlCommand sql = new SqlCommand(sqlI, connection);
                            sql.ExecuteNonQuery();
                            Load_NV();
                            MessageBox.Show("Thêm Thành Công");
                            connection.Close();
                        
                        }
                        else
                        {
                            Random random = new Random();
                            int randomNumber = random.Next(100, 999);
                            MessageBox.Show("Trùng khóa chính");
                            txtMaNV.Text = "SP" + randomNumber;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên và tên không được để trống!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm không được!!!");
                }

            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if(cbChucVu.SelectedIndex == 1)
        //    {
        //        txtTDN.Enabled = false;
        //        txtMK.Clear();
        //        txtTDN.Clear();
                
        //    }
        //    else if(cbChucVu.SelectedIndex == 0)
        //    {
        //        txtMK.Enabled = true;
        //        txtTDN.Text = txtMaNV.Text;
        //    }    
        }
    }
}
