using DAL_QLKS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;

namespace BUS_QLKS
{
    public class BUS_DanhMuc
    {
        DAL_DanhMuc dalDanhMuc = new DAL_DanhMuc();

        public DataTable getDanhMuc()
        {
            return dalDanhMuc.getDanhMuc();
        }

        public bool themDanhMuc(DTO_DanhMuc dm)
        {
            return dalDanhMuc.themDanhmuc(dm);
        }

        public bool xoaDanhMuc(int madanhmuc)
        {
            return dalDanhMuc.xoaDanhMuc(madanhmuc);
        }

        public bool suaDanhMuc(DTO_DanhMuc dm)
        {
            return dalDanhMuc.suaDanhMuc(dm);
        }
    }
}
