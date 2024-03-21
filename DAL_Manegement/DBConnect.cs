using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Manegement
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(
            "Data Source=XuanTruong\\SQLEXPRESS;Initial Catalog=qlmt;Integrated Security=True"
            );
    }
}
