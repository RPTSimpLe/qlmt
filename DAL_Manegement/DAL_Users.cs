using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Manegement;
using DAL_Manegement;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Security.Policy;

namespace DAL_Manegement
{
    public class DAL_Users : DBConnect
    {
        public DataTable getAll()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                @"SELECT u.id AS [ID], 
                 u.fullname AS [Họ và tên], 
                 u.username AS [Tên đăng nhập], 
                 u.pass AS [Mật khẩu], 
                 u.phone AS [Số điện thoại], 
                 u.gender AS [Giới tính], 
                 u.birthday AS [Ngày sinh], 
                 u.address AS [Địa chỉ], 
                 u.email AS [Email], 
                 r.roles AS [Quyền]
          FROM users u
          INNER JOIN role r ON u.role_id = r.id", conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }


        public bool addUser(DTO_Users user, string roleName)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO users (fullname, username, pass, phone, gender, birthday, address, email, role_id) VALUES (@Fullname, @Username, @Pass, @Phone, @Gender, @Birthday, @Address, @Email, @role_id)";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Parameters.AddWithValue("@Fullname", user.getFullname());
                comm.Parameters.AddWithValue("@Username", user.getUsername());
                comm.Parameters.AddWithValue("@Pass", user.getPass());
                comm.Parameters.AddWithValue("@Phone", user.getPhone());
                comm.Parameters.AddWithValue("@Gender", user.getGender());
                comm.Parameters.AddWithValue("@Birthday", user.getBirthday());
                comm.Parameters.AddWithValue("@Address", user.getAddress());
                comm.Parameters.AddWithValue("@Email", user.getEmail());
                comm.Parameters.AddWithValue("@role_id", user.getRole_id());

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
            finally { conn.Close(); }
        }

        public int GetRoleIdByRoleName(string roleName)
        {
            int roleId = -1;
            try
            {
                conn.Open();

                string query = "SELECT id FROM role WHERE roles = @RoleName";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Parameters.AddWithValue("@RoleName", roleName);
                object result = comm.ExecuteScalar();
                if (result != null)
                {
                    roleId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return roleId;
        }


        public bool updateUsers(DTO_Users user)
        {
            try
            {
                conn.Open();

                string sql_insert = "UPDATE users SET fullname = @Fullname, username = @Username, pass = @Pass, phone = @Phone, gender = @Gender, birthday = @Birthday, address = @Address, email = @Email, role_id = @role_id WHERE id = @Id";
                SqlCommand comm = new SqlCommand(sql_insert, conn);
                comm.Parameters.AddWithValue("@Fullname", user.getFullname());
                comm.Parameters.AddWithValue("@Username", user.getUsername());
                comm.Parameters.AddWithValue("@Pass", user.getPass());
                comm.Parameters.AddWithValue("@Phone", user.getPhone());
                comm.Parameters.AddWithValue("@Gender", user.getGender());
                comm.Parameters.AddWithValue("@Birthday", user.getBirthday());
                comm.Parameters.AddWithValue("@Address", user.getAddress());
                comm.Parameters.AddWithValue("@Email", user.getEmail());
                comm.Parameters.AddWithValue("@role_id", user.getRole_id());
                comm.Parameters.AddWithValue("@Id", user.getId());
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
        public bool deleteUserById(int id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM users WHERE id = @Id";
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
        public DataTable findByNameUser(string name)
        {
            try
            {
                conn.Open();

                string sql = @"SELECT u.id AS [ID], 
                              u.fullname AS [Họ và tên], 
                              u.username AS [Tên đăng nhập], 
                              u.pass AS [Mật khẩu], 
                              u.phone AS [Số điện thoại], 
                              u.gender AS [Giới tính], 
                              u.birthday AS [Ngày sinh], 
                              u.address AS [Địa chỉ], 
                              u.email AS [Email], 
                              r.roles AS [Quyền]
                       FROM users u
                       INNER JOIN role r ON u.role_id = r.id
                       WHERE u.fullname LIKE @name";
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
        public void LoadRoleToComboBox(System.Windows.Forms.ComboBox comboRole)
        {
            try
            {
                conn.Open();
                string sql_query = "SELECT roles FROM role";
                SqlCommand cmd = new SqlCommand(sql_query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboRole.Items.Add(dr["roles"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public string loginWithRoles(string username, string pass, string roleName)
        {
            try
            {
                conn.Open();

                string query = @"SELECT r.roles 
                         FROM users u
                         INNER JOIN role r ON u.role_id = r.id
                         WHERE u.username = @Username AND u.pass = @Pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Pass", pass);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string userRole = result.ToString();
                    if (userRole == roleName)
                    {
                        return "Đăng nhập thành công : " + roleName;
                    }
                    else
                    {
                        return "Đăng nhập thất bại ! ";
                    }
                }
                else
                {
                    return "Tên đăng nhập hoặc mật khẩu không đúng";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        public string GetRoleByIdRole(int roleId)
        {
            try
            {
                conn.Open();
                string query = "SELECT roles FROM role WHERE id = @RoleId";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.Parameters.AddWithValue("@RoleId", roleId);
                object result = comm.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
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
