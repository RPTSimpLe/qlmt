using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_Category
    {
        private int id;
        private string name;
        private string code;

        public DTO_Category(int id, string name, string code)
        {
            this.id = id;
            this.name = name;
            this.code = code;
        }
        public DTO_Category() { }
        

    



    }
}
