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
    public class BUS_Phong
    {
        DAL_Phong dalPhong = new DAL_Phong();

        public DataTable getPhong()
        {
            return dalPhong.getPhong();
        }

        public bool themPhong(DTO_Phong tp)
        {
            return dalPhong.themPhong(tp);
        }

        public bool xoaPhong(int maphong)
        {
            return dalPhong.xoaPhong(maphong);
        }

        public bool suaPhong(DTO_Phong sp)
        {
            return dalPhong.suaPhong(sp);
        }

        public DataTable timPhong(string tenphong)
        {
            return dalPhong.timPhong(tenphong);
        }

        public DataTable timPhongTrong(string tinhtrang)
        {
            return dalPhong.timPhongTrong(tinhtrang);
        }

        public bool datPhong(int maphong)
        {
            return dalPhong.datPhong(maphong);
        }

        public bool thanhToan(int maphong)
        {
            return dalPhong.thanhToan(maphong);
        }
    }
}
