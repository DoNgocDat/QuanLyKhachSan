using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_Phong
    {
        private int _MaPhong;
        private string _TenPhong;
        private int _MaDanhMuc;
        private float _GiaPhong;
        private string _TinhTrang;

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

        public string TenPhong
        {
            get
            {
                return _TenPhong;
            }
            set
            {
                _TenPhong = value;
            }
        }

        public int MaDanhMuc
        {
            get
            {
                return _MaDanhMuc;
            }

            set
            {
                _MaDanhMuc = value;
            }
        }

        public float GiaPhong
        {
            get
            {
                return _GiaPhong;
            }
            set
            {
                _GiaPhong = value;
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

        public DTO_Phong()
        {

        }

        public DTO_Phong(int map, string tenp, int madm, float giap, string tt)
        {
            this.MaPhong = map;
            this.TenPhong = tenp;
            this.MaDanhMuc = madm;
            this.GiaPhong = giap;
            this.TinhTrang = tt;
        }
    }
}
