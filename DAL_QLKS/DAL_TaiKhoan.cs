using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace DAL_QLKS
{
    public class DAL_TaiKhoan : DataProvider
    {
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("select tendangnhap as N'Tên Đăng Nhập', tenhienthi as N'Tên Hiển Thị', matkhau as N'Mật Khẩu', loaitaikhoan as N'Loại Tài Khoản' from taikhoan", connection);
            DataTable dtTaiKhoan = new DataTable();
            da.Fill(dtTaiKhoan);
            return dtTaiKhoan;
        }

        public bool themTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                connection.Open();
                string sql = string.Format("insert into taikhoan values (N'{0}', N'{1}', N'{2}', '{3}') ", tk.TenDangNhap, tk.TenHienThi, tk.MatKhau, tk.LoaiTaiKhoan);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool xoaTaiKhoan(string tendangnhap)
        {
            try
            {
                connection.Open();
                string sql = string.Format("delete from taikhoan where tendangnhap = N'{0}'", tendangnhap);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if(cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool suaTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update taikhoan set tenhienthi = N'{0}', matkhau = N'{1}', loaitaikhoan = {2} where tendangnhap = N'{3}'", tk.TenHienThi, tk.MatKhau, tk.LoaiTaiKhoan, tk.TenDangNhap);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if( cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool dangNhap(string tendangnhap, string matkhau)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from taikhoan where tendangnhap = N'{0}' and matkhau = N'{1}'", tendangnhap, matkhau);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public int getQuyen(string tendangnhap)
        {
            int quyen = 0;
            try
            {
                connection.Open();
                string sql = string.Format("select loaitaikhoan from taikhoan where tendangnhap = N'{0}'", tendangnhap);
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    quyen = Convert.ToInt16(dataReader["loaitaikhoan"]);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return quyen;
        }

        public bool doiMatKhau(DTO_TaiKhoan tk)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update taikhoan set matkhau = N'{0}' where tendangnhap = N'{1}'", tk.MatKhau, tk.TenDangNhap);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }
    }
}
