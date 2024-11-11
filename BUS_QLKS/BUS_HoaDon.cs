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
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHoaDon = new DAL_HoaDon();

        public DataTable getHoaDon()
        {
            return dalHoaDon.getHoaDon();
        }

        public DataTable timHoaDon(int mahoadon)
        {
            return dalHoaDon.timHoaDon(mahoadon);
        }

        public bool thanhToan(int maphong)
        {
            return dalHoaDon.thanhToan(maphong);
        }

        public bool datPhong(DTO_HoaDon dp)
        {
            return dalHoaDon.datPhong(dp);
        }
    }
}
