﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using System.Data.SqlTypes;

namespace DAL_QLKS
{
    public class DAL_DanhMuc : DataProvider
    {
        public DataTable getDanhMuc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select madanhmuc as N'Mã Danh Mục', tendanhmuc as N'Tên Danh Mục' from danhmucphong", connection);
            DataTable dtDanhMuc = new DataTable();
            da.Fill(dtDanhMuc);
            return dtDanhMuc;
        }

        public bool themDanhmuc(DTO_DanhMuc dm)
        {
            try
            {
                connection.Open();
                string sql = string.Format("insert into danhmucphong values(N'{0}')", dm.TenDanhMuc);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if(cmd.ExecuteNonQuery() >0)
                    return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool xoaDanhMuc(int madanhmuc)
        {
            try
            {
                connection.Open();
                string sql = string.Format("delete from danhmucphong where madanhmuc = {0}", madanhmuc);
                SqlCommand cmd = new SqlCommand (sql, connection);
                if( cmd.ExecuteNonQuery() >0 )
                    return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close() ;
            }
            return false;
        }

        public bool suaDanhMuc(DTO_DanhMuc dm)
        {
            try
            {
                connection.Open();
                string sql = string.Format("update danhmucphong set tendanhmuc = N'{0}' where madanhmuc = {1}", dm.TenDanhMuc, dm.MaDanhMuc);
                SqlCommand cmd = new SqlCommand(sql, connection);
                if(cmd.ExecuteNonQuery() >0)
                    return true;
            }
            catch (Exception ex)
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
