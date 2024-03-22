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
        //Dxt
        //"Data Source=XuanTruong\\SQLEXPRESS;Initial Catalog=qlmt;Integrated Security=True"
        //Bmv
        //"Data Source=DESKTOP-RIDI94M\SQLEXPRESS;Initial Catalog=qlmt;Integrated Security=True"
        //Nnm
        "Data Source=LAPTOP-4FSB8OCK\\SQLEXPRESS;Initial Catalog=qlmt;Integrated Security=True"
        //Ltd
        //"Data Source=localhost\\SQLEXPRESS;Initial Catalog=qlmt;Integrated Security=True"
        //Ltl
        //"Data Source=XuanTruong\\SQLEXPRESS;Initial Catalog=qlmt;Integrated Security=True"
        );
    }
}
