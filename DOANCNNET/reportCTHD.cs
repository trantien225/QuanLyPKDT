using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCNNET
{
    public partial class reportCTHD : Form
    {
        HoaDon hd = new HoaDon();
        public reportCTHD()
        {
            InitializeComponent();
        }

        private void reportCTHD_Load(object sender, EventArgs e)
        {
            CachedCrystalReport2 rpt = new CachedCrystalReport2();
            CrystalReport2 cry2 = new CrystalReport2();
            cry2.SetDatabaseLogon("SOHD", hd.txtsohd.Text);
            crystalReportViewer1.ReportSource = rpt;
            cry2.SetDatabaseLogon("sa", "sa", ".\\SQLEXPRESS", "QL_PKDT");
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
