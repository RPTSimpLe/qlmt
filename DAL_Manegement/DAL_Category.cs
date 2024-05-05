using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Manegement;

namespace DAL_Manegement
{
    public class DAL_Category : DBConnect
    {
        public DataTable getAll()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "select id as [ID], code as [Mã], nameCategory as [Tên danh mục] from category", conn
                );
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public bool addCategory(DTO_Category cate)
        {
            try
            {
                conn.Open();

                string s1 = "INSERT INTO category (code, nameCategory) VALUES (@Code, @Name)";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Code", cate.getCode());
                comm.Parameters.AddWithValue("@Name", cate.getNameCategory());

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
        public bool updateCategory(DTO_Category cate)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE category SET code = @Code, nameCategory = @Name WHERE id = @Id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Code", cate.getCode());
                comm.Parameters.AddWithValue("@Name", cate.getNameCategory());
                comm.Parameters.AddWithValue("@Id", cate.getId());

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

        public bool deleteCategoryById(int id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM category WHERE id = @Id";
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


        public bool checkDuplicateCategory(string code, string name)
        {
            try
            {
                conn.Open();

                string s1 = "SELECT COUNT(*) FROM category WHERE code = @Code AND nameCategory = @Name";
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

        public DataTable FindCategory(string name, string code)
        {
            try
            {
                conn.Open();

                string sql = "SELECT id AS [ID], code AS [Mã], nameCategory AS [Tên danh mục] FROM category WHERE nameCategory LIKE @name and code LIKE @code";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@name", "%" + name + "%");
                comm.Parameters.AddWithValue("@code", "%" + code + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

    }

}
