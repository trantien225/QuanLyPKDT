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
    public partial class HoaDon : Form
    {
        SqlConnection connection;
        public HoaDon()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=QL_PKDT;User=sa;Password=sa");
        }
        private void Load_HD()
        {
            string sqlS = "SELECT *FROM HOADON";
            SqlDataAdapter da_hd = new SqlDataAdapter(sqlS, connection);
            DataTable HD = new DataTable();
            da_hd.Fill(HD);
            d_grhd.DataSource = HD;
        }
        private void Load_CTHD()
        {
            string sqlS = "SELECT *FROM CTHOADON WHERE SOHD='"+txtsohd.Text+"'";
            SqlDataAdapter da_cthd = new SqlDataAdapter(sqlS, connection);
            DataTable CTHD = new DataTable();
            da_cthd.Fill(CTHD);
            d_grcthd.DataSource = CTHD;
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            Load_HD();
        }

        private void d_grhd_Click(object sender, EventArgs e)
        {
            int row;
            row = d_grhd.CurrentCell.RowIndex;
            txtsohd.Text = d_grhd.Rows[row].Cells[0].Value.ToString();
            Load_CTHD();
        }

        private void btxoact_Click(object sender, EventArgs e)
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
                    string sqlD = "delete CTHOADON where SOHD ='" + txtsohd.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Xóa Thành Công");
                    Load_HD();
                    Load_CTHD();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Xóa không được!!!");
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
                    string sqlD = "delete HOADON where SOHD ='" + txtsohd.Text + "'";
                    SqlCommand sql = new SqlCommand(sqlD, connection);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Xóa Thành Công");
                    Load_HD();
                    Load_CTHD();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Xóa không được!!!");
                }
            }
        }

        private void btXemIn_Click(object sender, EventArgs e)
        {
            reporthd form1=new reporthd();
            form1.Show();
        }

        private void btxeminct_Click(object sender, EventArgs e)
        {
            CrystalReport2 cry2 = new CrystalReport2();
            reportCTHD form2 = new reportCTHD();
            cry2.SetParameterValue("SOHD", txtsohd.Text);
            form2.Show();


            cry2.SetDatabaseLogon("sa", "sa", ".\\SQLEXPRESS", "QL_PKDT");
        }
    }
}
