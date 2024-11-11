using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLKS;
using DTO_QLKS;

namespace BUS_QLKS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();

        public DataTable getTaiKhoan()
        {
            return dalTaiKhoan.getTaiKhoan();
        }

        public bool themTaiKhoan(DTO_TaiKhoan tk)
        {
            return dalTaiKhoan.themTaiKhoan(tk);
        }

        public bool xoaTaiKhoan(string tendangnhap)
        {
            return dalTaiKhoan.xoaTaiKhoan(tendangnhap);
        }

        public bool suaTaiKhoan(DTO_TaiKhoan tk)
        {
            return dalTaiKhoan.suaTaiKhoan(tk);
        }

        public bool dangNhap(string tendangnhap, string matkhau)
        {
            return dalTaiKhoan.dangNhap(tendangnhap, matkhau);
        }

        public int getQuyen (string tendangnhap)
        {
            return dalTaiKhoan.getQuyen(tendangnhap);
        }

        public bool doiMatKhau(DTO_TaiKhoan tk)
        {
            return dalTaiKhoan.doiMatKhau(tk);
        }
    }
}
