using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using System.Data.Common;

namespace DAL_QLKS
{
    public class DAL_Phong : DataProvider
    {
        public DataTable getPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("select maphong as N'Mã Phòng', tenphong as N'Tên Phòng', madanhmuc as N'Mã Danh Mục', giaphong as N'Giá Phòng', tinhtrang as N'Tình Trạng' from phong", connection);
            DataTable dtPhong = new DataTable();
            da.Fill(dtPhong);
            return dtPhong;
        }

        public bool themPhong(DTO_Phong tp)
        {
            try
            {
                connection.Open();
                string sql = string.Format("insert into phong values (N'{0}', '{1}', '{2}', N'{3}')", tp.TenPhong, tp.MaDanhMuc, tp.GiaPhong, tp.TinhTrang);
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

        public bool xoaPhong (int maphong)
        {
            try
            {
                connection.Open();
                string sql = string.Format("delete from phong where maphong = {0}", maphong);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if( cmd.ExecuteNonQuery() > 0 )
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close ();
            }
            return false;
        }

        public bool suaPhong(DTO_Phong sp)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update phong set tenphong = N'{0}', madanhmuc = {1}, giaphong = {2}, tinhtrang = N'{3}' where maphong = {4}", sp.TenPhong, sp.MaDanhMuc, sp.GiaPhong, sp.TinhTrang, sp.MaPhong);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if(cmd.ExecuteNonQuery() > 0 )
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close ();
            }
            return false;
        }

        public DataTable timPhong(string tenphong)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from phong where tenphong like N'%{0}%'", tenphong);
                SqlDataAdapter cmd = new SqlDataAdapter (sql, connection);
                DataTable data = new DataTable();
                cmd.Fill (data);
                return data;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public DataTable timPhongTrong(string tinhtrang)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from phong where tinhtrang = N'{0}'", tinhtrang);
                SqlDataAdapter cmd = new SqlDataAdapter(sql, connection);
                DataTable data = new DataTable();
                cmd.Fill(data);
                return data;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public bool datPhong(int maphong)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update phong set tinhtrang = N'Đã Đặt' where maphong = '{0}'", maphong);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool thanhToan(int maphong)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update phong set tinhtrang = N'Trống' where maphong = '{0}'", maphong);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
    }
}
