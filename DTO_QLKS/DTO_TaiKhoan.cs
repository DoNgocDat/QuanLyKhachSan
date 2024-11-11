using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKS
{
    public class DTO_TaiKhoan
    {
        private string _TenDangNhap;
        private string _TenHienThi;
        private string _MatKhau;
        private int _LoaiTaiKhoan;

        public string TenDangNhap
        {
            get
            {
                return _TenDangNhap;
            }
            set
            {
                _TenDangNhap = value;
            }
        }

        public string TenHienThi
        {
            get
            {
                return _TenHienThi;
            }
            set
            {
                _TenHienThi = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }
            set
            {
                _MatKhau = value;
            }
        }

        public int LoaiTaiKhoan
        {
            get
            {
                return _LoaiTaiKhoan;
            }
            set
            {
                _LoaiTaiKhoan = value;
            }
        }

        public DTO_TaiKhoan()
        {

        }

        public DTO_TaiKhoan(string tendn, string tenht, string mk, int ltk)
        {
            this.TenDangNhap = tendn;
            this.TenHienThi = tenht;
            this.MatKhau = mk;
            this.LoaiTaiKhoan= ltk;
        }

        

    }
}
