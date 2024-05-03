using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Manegement
{
    public class DAL_incomeStatistics : DBConnect
    {
        public bool add(DTO_incomeStatistics dto)
        {
            try
            {
                conn.Open();

                string s1 = "INSERT INTO incomeStatistics (nameProduct, nameOptions, sellQuantity,sellPrice,created_at) VALUES (@nameProduct,@nameOptions, @sellQuantity ,@sellPrice , (SELECT GETDATE()))";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@nameProduct", dto.GetNameProduct());
                comm.Parameters.AddWithValue("@nameOptions", dto.GetNameOptions());
                comm.Parameters.AddWithValue("@sellQuantity", dto.GetSellQuantity());
                comm.Parameters.AddWithValue("@sellPrice", dto.GetSellPrice());
                if (comm.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool update(DTO_incomeStatistics dto)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE incomeStatistics SET sellQuantity= (sellQuantity + @sellQuantity)  WHERE nameOptions = @nameOptions and nameProduct = @nameProduct and sellPrice = @sellPrice";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@sellQuantity", dto.GetSellQuantity());
                comm.Parameters.AddWithValue("@nameOptions", dto.GetNameOptions());
                comm.Parameters.AddWithValue("@nameProduct", dto.GetNameProduct());
                comm.Parameters.AddWithValue("@sellPrice", dto.GetSellPrice());

                if (comm.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable getAll()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "select incomeStatistics.nameProduct as [Tên sản phẩm], incomeStatistics.nameOptions as [Linh kiện], incomeStatistics.sellQuantity  as [Số lượng], incomeStatistics.sellPrice as [Giá], " +
                "(incomeStatistics.sellQuantity*incomeStatistics.sellPrice) as Tổng , " +
                "incomeStatistics.created_at as [Ngày bán]" +
                "from incomeStatistics", conn
                );
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable total()
        {
            string sql = "select sum(incomeStatistics.sellQuantity*incomeStatistics.sellPrice) as [tong] from incomeStatistics";

            SqlCommand comm = new SqlCommand(sql, conn);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
