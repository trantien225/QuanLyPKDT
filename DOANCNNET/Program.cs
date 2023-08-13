
using System;
using DOANCNNET;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using formMenu;

namespace DOANCNNET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TrangChu());
            //Application.Run(new NhanVien());
            Application.Run(new DangNhap());
            //Application.Run(new DangKy());
            //Application.Run(new SanPham());
            //Application.Run(new CuaHang());
            //Application.Run(new PhieuNhap());
            //Application.Run(new GioHang());
            //Application.Run(new LoaiSP());
            //Application.Run(new NhaCC());
            //Application.Run(new HoaDon());
            //Application.Run(new Form1());
        }
    }
}
