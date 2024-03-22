using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Manegement;

namespace DAL_Manegement
{
    public class DAL_Producer : DBConnect
    {
        public DataTable getAll()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "select id as [ID], code as [Mã NSX], nameProducer as [Tên NSX] from producer", conn
                );
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public bool addProducer(DTO_Producer producer)
        {
            try
            {
                conn.Open();

                string s1 = "INSERT INTO producer (code, nameProducer) VALUES (@Code, @Name)";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Code", producer.getCode());
                comm.Parameters.AddWithValue("@Name", producer.getNameProducer());

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
        public bool updateProducer(DTO_Producer producer)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE producer SET code = @Code, nameProducer = @Name WHERE id = @Id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Code", producer.getCode());
                comm.Parameters.AddWithValue("@Name", producer.getNameProducer());
                comm.Parameters.AddWithValue("@Id", producer.getId());

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

                string s1 = "DELETE FROM producer WHERE id = @Id";
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
        public DataTable findByNameProducer(string name)
        {
            try
            {
                conn.Open();

                string sql = "SELECT id AS [ID], code AS [Mã NSX], nameProducer AS [Tên NSX] FROM producer WHERE nameProducer LIKE @name";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@name", "%" + name + "%");

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
        public DataTable findByCodeProducer(string code)
        {
            try
            {
                conn.Open();

                string sql = "SELECT id AS [ID], code AS [Mã NSX], nameProducer AS [Tên NSX] FROM producer WHERE code LIKE @code";

                SqlCommand comm = new SqlCommand(sql, conn);
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
