using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Manegement
{
    public class DAL_Product : DBConnect
    {
        private SqlDataAdapter dataAdapter;
        public DataTable findProduct(String name, String type, String hang)
        {
            string sql = "SELECT product.id AS [ID], product.nameProduct AS [Tên sản phẩm], product.years AS [Năm sản xuất], product.warranty AS [Bảo hành], product.descriptions AS [Ghi chú]," +
                "category.nameCategory as [Loại], producer.nameProducer as [Hãng]" +
                "join category on category.id = product.category_id" +
                "join producer on producer.id = producer.id" +
                " FROM product WHERE nameCategory LIKE @type and nameProduct like @name and nameProducer like @hang";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@name", "%" + name + "%");
            comm.Parameters.AddWithValue("@type", "%" + type + "%");
            comm.Parameters.AddWithValue("@hang", "%" + hang + "%");

            dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public bool addProducer(DTO_product product)
        {
            try
            {
                conn.Open();

                string s1 = "exec sp_insert_product @nameProduct,@year,@description,@warrantly,@nameCategory,@nameProducer";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@nameProduct", "N'%"+product.getNameProduct()+"%'");
                comm.Parameters.AddWithValue("@year", product.getYears());
                comm.Parameters.AddWithValue("@description", "N'%" + product.getDescription() + "%'");
                comm.Parameters.AddWithValue("@warrantly", "N'%" + product.getWarranty() + "%'");
                comm.Parameters.AddWithValue("@nameCategory", "N'%" + product.getNameCategory() + "%'");
                comm.Parameters.AddWithValue("@nameProducer", "N'%" + product.getNameProducer() + "%'");

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

        public bool updateProducer(DTO_product product)
        {
            try
            {
                conn.Open();

                string s1 = "exec sp_update_product @nameProduct,@year,@description,@warrantly,@nameCategory,@nameProducer";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@nameProduct", "N'%" + product.getNameProduct() + "%'");
                comm.Parameters.AddWithValue("@year", product.getYears());
                comm.Parameters.AddWithValue("@id", product.getYears());
                comm.Parameters.AddWithValue("@description", "N'%" + product.getDescription() + "%'");
                comm.Parameters.AddWithValue("@warrantly", "N'%" + product.getWarranty() + "%'");
                comm.Parameters.AddWithValue("@nameCategory", "N'%" + product.getNameCategory() + "%'");
                comm.Parameters.AddWithValue("@nameProducer", "N'%" + product.getNameProducer() + "%'");

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
        public bool deleteProducerById(int id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM product WHERE id = @Id";
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
        public bool checkDuplicateProducer(string code, string name)
        {
            try
            {
                conn.Open();

                string s1 = "SELECT COUNT(*) FROM producer WHERE code = @Code AND nameProducer = @Name";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Code", code);
                comm.Parameters.AddWithValue("@Name", name);

                int count = (int)comm.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
