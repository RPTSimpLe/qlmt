using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_Category
    {
        private int id;
        private string nameCategory;
        private string code;
        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getNameCategory()
        {
            return nameCategory;
        }

        public void setNameCategory(String nameCategory)
        {
            this.nameCategory = nameCategory;
        }

        public String getCode()
        {
            return code;
        }

        public void setCode(String code)
        {
            this.code = code;
        }
        public DTO_Category() { }
        public DTO_Category(int id, string nameCategory, string code)
        {
            this.id = id;
            this.nameCategory = nameCategory;
            this.code = code;
        }
    }
}
