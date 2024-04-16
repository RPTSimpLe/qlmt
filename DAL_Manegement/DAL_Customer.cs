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
    public class DAL_Customer : DBConnect
    {
        public DataTable getAll()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "select id as [ID], fullname as [Họ và tên], phone as [Số điện thoại],addres as [Địa chỉ] from customers", conn
                );
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public bool addCustomer(DTO_Customer customer)
        {
            try
            {
                conn.Open();

                string sqlInsert = "INSERT INTO customers (fullname, phone, addres) VALUES (@fullname, @phone,@addres)";
                SqlCommand comm = new SqlCommand(sqlInsert, conn);
                comm.Parameters.AddWithValue("@fullname", customer.getfullname());
                comm.Parameters.AddWithValue("@phone", customer.getphone());
                comm.Parameters.AddWithValue("@addres", customer.getaddres());

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

        public bool updateCustomer(DTO_Customer customer)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE customers SET fullname=@fullname, phone = @phone, addres = @addres WHERE id = @id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@fullname", customer.getfullname());
                comm.Parameters.AddWithValue("@phone", customer.getphone());
                comm.Parameters.AddWithValue("@addres", customer.getaddres());
                comm.Parameters.AddWithValue("@id", customer.getId());

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
        public DataTable findByFullNameByCustomer(string fullname)
        {
            try
            {
                conn.Open();

                string sql = "select id as [ID], fullname as [Họ và tên], phone as [Số điện thoại],addres as [Địa chỉ] FROM customers WHERE fullname LIKE @fullname";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@fullname", "%" + fullname + "%");

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
        public bool deleteById(int id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM customers WHERE id = @Id";
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
