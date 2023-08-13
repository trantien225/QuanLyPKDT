using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions;

namespace DOANCNNET
{
    public partial class reporthd : Form
    {
        public reporthd()
        {
            InitializeComponent();

        }
        public void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            CrystalReport1 cry1 = new CrystalReport1();
            cry1.SetDatabaseLogon("sa", "sa", ".\\SQLEXPRESS", "QL_PKDT");
            CachedCrystalReport1 rpt = new CachedCrystalReport1();            
            crystalReportViewer1.ReportSource = rpt;    
            crystalReportViewer1.Refresh();

        }
    }
}
