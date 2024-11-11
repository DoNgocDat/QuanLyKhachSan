using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_HoaDon : DataProvider
    {
        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("select mahoadon as N'Mã Hóa Đơn', ngayvao as N'Ngày Vào', ngayra as N'Ngày Ra', maphong as N'Mã Phòng', soluong as N'Số Lượng', tongtien as N'Tổng Tiền', tinhtrang as N'Tình Trạng' from hoadon", connection);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }

        public DataTable timHoaDon(int mahoadon)
        {
            try
            {
                connection.Open();
                string sql = string.Format("select * from hoadon where mahoadon = {0}", mahoadon);
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

        public bool thanhToan(int maphong)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update hoadon set tinhtrang = N'Đã Thanh Toán' where maphong = '{0}'", maphong);
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

        public bool datPhong(DTO_HoaDon dp)
        {
            try
            {
                connection.Open();
                string sql = string.Format("insert into hoadon values('{0}', '{1}', {2}, {3}, {4}, N'{5}')", dp.NgayVao.ToString("yyyy-MM-dd"), dp.NgayRa.ToString("yyyy-MM-dd"), dp.MaPhong, dp.SoLuong, dp.TongTien, dp.TinhTrang);
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
