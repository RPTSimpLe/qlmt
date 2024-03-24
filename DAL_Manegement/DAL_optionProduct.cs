using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Manegement;

namespace DAL_Manegement
{
    public class DAL_optionProduct : DBConnect
    {
        private SqlDataAdapter dataAdapter;
        public DataTable getAll(int product_id)
        {
            string sql = "select options.id, options.ram, options.storage, options.quantity, options.importPrice,options.sellingPrice from options where product_id = @id";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", product_id.ToString());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public bool addOption(DTO_optionProduct optionProduct)
        {
            try
            {
                conn.Open();

                string s1 = "INSERT INTO options(ram, storage, quantity, importPrice, sellingPrice, product_id) VALUES (@ram,@storage,@quantity,@importPrice,@sellingPrice,@product_id)";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@ram", optionProduct.getRam());
                comm.Parameters.AddWithValue("@storage", optionProduct.getStorage());
                comm.Parameters.AddWithValue("@quantity", optionProduct.getQuantity());
                comm.Parameters.AddWithValue("@importPrice", optionProduct.getImportPrice());
                comm.Parameters.AddWithValue("@sellingPrice", optionProduct.getSelllingPrice());
                comm.Parameters.AddWithValue("@product_id", optionProduct.getProduct_id());

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
        public bool updateOption(DTO_optionProduct optionProduct)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE options SET ram = @ram, storage =@storage, quantity = @quantity, importPrice @importPrice, sellingPrice =@sellingPrice WHERE product_id = @product_id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@ram", optionProduct.getRam());
                comm.Parameters.AddWithValue("@storage", optionProduct.getStorage());
                comm.Parameters.AddWithValue("@quantity", optionProduct.getQuantity());
                comm.Parameters.AddWithValue("@importPrice", optionProduct.getImportPrice());
                comm.Parameters.AddWithValue("@sellingPrice", optionProduct.getSelllingPrice());
                comm.Parameters.AddWithValue("@product_id", optionProduct.getProduct_id());

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
        public bool deleteOptionById(int id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM options WHERE id = @Id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Id", id);

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
    }
}
