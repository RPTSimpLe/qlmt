using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Manegement;
using DAL_Manegement;
using System.Data.SqlClient;
using System.Data;
namespace DAL_Manegement
{
    public class DAL_Role : DBConnect
    {
        public DataTable getAll()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "select id as [ID], roles as [Quyền] from role", conn
                );
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public bool addRole(DTO_Role role)
        {
            try
            {
                conn.Open();

                string s1 = "INSERT INTO role (roles) VALUES (@roles)";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@roles", role.RoleName);

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
        public bool updateRole(DTO_Role role)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE role SET roles = @roles WHERE id = @Id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@roles", role.RoleName);
                comm.Parameters.AddWithValue("@Id", role.RoleId);

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
        public bool deleteRoleById(int id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM role WHERE id = @Id";
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
