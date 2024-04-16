using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Manegement;
using DAL_Manegement;
using System.Data;

namespace BUS_Manegement
{
    public class BUS_Users
    {
        public static DAL_Users users = new DAL_Users();
        public DataTable getAllData()
        {
            return users.getAll();
        }
        public DataTable getAllRoleId()
        {
            return users.getAllRoleId();
        }
        public bool addUser(DTO_Users user, string roleName)
        {
            return users.addUser(user, roleName);
        }
        public bool deleteUser(int id)
        {
            return users.deleteUserById(id);
        }
        public bool updateUser(DTO_Users user)
        {
            return users.updateUsers(user);
        }
        public DataTable FindByNameAccount(string name)
        {
            return users.findByNameUser(name);
        }
        public void LoadRoleToComboBox(System.Windows.Forms.ComboBox comboRole)
        {
            users.LoadRoleToComboBox(comboRole);
        }
        public string loginWithRoles(string username, string pass, string roleName)
        {
            string loginResult = users.loginWithRoles(username, pass, roleName);
            return loginResult;
        }
    }
}
