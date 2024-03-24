using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_Role
    {
        private int id;
        private string roles;
        public int RoleId { get { return id; } set { id = value; } }
        public string RoleName { get { return roles; } set { roles = value; } }
        public DTO_Role() { }
        public DTO_Role(int id, string roles)
        {
            this.id = id;
            this.roles = roles;
        }
    }
}
