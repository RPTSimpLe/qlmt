using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Manegement
{
    public class DAL_Image : DBConnect
    {
        public string getByUrl(int productId)
        {
            string sql = "select images.url from images where product_id = @productId";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@productId", productId);

            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt.Rows[0]["url"].ToString();
        }
        public bool add(DTO_Image img)
        {
            try
            {
                conn.Open();

                string sqlInsert = "INSERT INTO images ( product_id, url) VALUES (@productId,@url)";
                SqlCommand comm = new SqlCommand(sqlInsert, conn);
                Console.WriteLine(img.getProductId());
                Console.WriteLine(img.getUrl());
                comm.Parameters.AddWithValue("@productId", img.getProductId());
                comm.Parameters.AddWithValue("@url", img.getUrl());

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

        public bool update(DTO_Image img)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE images SET url=@url  WHERE product_id = @productId";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@url", img.getUrl());
                comm.Parameters.AddWithValue("@productId", img.getProductId());

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
