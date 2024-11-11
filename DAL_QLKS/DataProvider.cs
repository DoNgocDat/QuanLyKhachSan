using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL_QLKS
{
    public class DataProvider
    {   
        protected SqlConnection connection = new SqlConnection("Data Source=DESKTOP-015OE7K\\SQLEXPRESS;Initial Catalog=qlks;Integrated Security=True");
    }
}
