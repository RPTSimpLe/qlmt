using DAL_Manegement;
using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Manegement
{
    public class BUS_expense_statistics
    {
        private DAL_expense_statistics dal = new DAL_expense_statistics();
        public DataTable total()
        {
            return dal.total();
        }
        public DataTable getAll()
        {
            return dal.getAll();
        }
    }
}
