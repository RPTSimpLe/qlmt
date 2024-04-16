using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Manegement
{
    public class DAL_expense_statistics : DBConnect
    {
        public bool add(DTO_expense_statistics dto)
        {
            try
            {
                conn.Open();

                string s1 = "INSERT INTO expense_statistics (nameProduct, nameOptions, importQuantity,importPrice,created_at) VALUES (@nameProduct,@nameOptions, @sellQuantity ,@sellPrice , (SELECT GETDATE()))";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@nameProduct", dto.GetNameProduct());
                comm.Parameters.AddWithValue("@nameOptions", dto.GetNameOptions());
                comm.Parameters.AddWithValue("@sellQuantity", dto.GetImportQuantity());
                comm.Parameters.AddWithValue("@sellPrice", dto.GetImportPrice());

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

        public bool update(DTO_expense_statistics dto)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE expense_statistics SET importQuantity=@importQuantity ,  importPrice = @importPrice WHERE nameOptions = @nameOptions and nameProduct = @nameProduct ";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@importQuantity", dto.GetImportQuantity());
                comm.Parameters.AddWithValue("@nameOptions", dto.GetNameOptions());
                comm.Parameters.AddWithValue("@nameProduct", dto.GetNameProduct());
                comm.Parameters.AddWithValue("@importPrice", dto.GetImportPrice());

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
                "select expense_statistics.nameProduct, expense_statistics.nameOptions, expense_statistics.importQuantity, expense_statistics.importPrice, " +
                "(expense_statistics.importQuantity*expense_statistics.importPrice) as tong , expense_statistics.created_at " +
                "from expense_statistics", conn );
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable total()
        {
            string sql = "select sum(expense_statistics.importQuantity*expense_statistics.importPrice) as [tong] from expense_statistics";

            SqlCommand comm = new SqlCommand(sql, conn);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
