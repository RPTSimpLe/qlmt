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
    public class BUS_Category
    {
        private static DAL_Category category = new DAL_Category();
        public DataTable getAllData()
        {
            return category.getAll();
        }
        public bool AddCategory(DTO_Category c)
        {
            return category.addCategory(c);
        }
        public bool updateCategories(DTO_Category c)
        {
            return category.updateCategory(c);
        }
        public bool deleteCategories(int id)
        {
            return category.deleteCategoryById(id);
        }
        public bool CheckDuplicateCategory(string code, string name)
        {
            return category.checkDuplicateCategory(code, name);
        }
        public DataTable FindCategory(string name, string code)
        {
            return category.FindCategory(name,code);
        }
    }
}
