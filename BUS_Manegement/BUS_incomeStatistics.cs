using DAL_Manegement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Manegement
{
    public class BUS_incomeStatistics
    {
        private DAL_incomeStatistics dal = new DAL_incomeStatistics();
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
