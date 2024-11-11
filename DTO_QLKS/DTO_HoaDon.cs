using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_HoaDon
    {
        private int _MaHoaDon;
        private DateTime _NgayVao;
        private DateTime _NgayRa;
        private int _MaPhong;
        private int _SoLuong;
        private float _TongTien;
        private string _TinhTrang;

        public int MaHoaDon
        {
            get 
            { 
                return _MaHoaDon;
            }
            set
            {
                _MaHoaDon = value;
            }
        }

        public DateTime NgayVao
        {
            get
            {
                return _NgayVao;
            }
            set
            {
                _NgayVao = value;
            }
        }

        public DateTime NgayRa
        {
            get
            {
                return _NgayRa;
            }
            set
            {
                _NgayRa = value;
            }
        }

        public int MaPhong
        {
            get
            {
                return _MaPhong;
            }
            set
            {
                _MaPhong = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }
            set
            {
                _SoLuong = value;
            }
        }

        public float TongTien
        {
            get
            {
                return _TongTien;
            }
            set
            {
                _TongTien = value;
            }
        }

        public string TinhTrang
        {
            get
            {
                return _TinhTrang;
            }
            set
            {
                _TinhTrang = value;
            }
        }

        public DTO_HoaDon()
        {

        }

        public DTO_HoaDon(int mahd, DateTime nv, DateTime nr, int map, int sl, float ttien, string tt)
        {
            this.MaHoaDon = mahd;
            this.NgayVao = nv;
            this.NgayRa = nr;
            this.MaPhong = map;
            this.SoLuong = sl;
            this.TongTien = ttien;
            this.TinhTrang = tt;
        }
    }
}
