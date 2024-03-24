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
    public class BUS_Role
    {
        private static DAL_Role role = new DAL_Role();
        public DataTable getAllData()
        {
            return role.getAll();
        }
        public bool AddRoles(DTO_Role roles)
        {
            return role.addRole(roles);
        }
        public bool updateRoles(DTO_Role roles)
        {
            return role.updateRole(roles);
        }
        public bool deleteRoles(int id)
        {
            return role.deleteRoleById(id);
        }
    }
}
