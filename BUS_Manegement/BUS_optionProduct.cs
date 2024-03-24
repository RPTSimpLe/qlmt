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
    public class BUS_optionProduct
    {
        private static DAL_optionProduct optionProduct = new DAL_optionProduct();
        public DataTable getAllData(int id)
        {
            return optionProduct.getAll(id);
        }
        public bool addOption(DTO_optionProduct p)
        {
            return optionProduct.addOption(p);
        }
        public bool updateOption(DTO_optionProduct p)
        {
            return optionProduct.updateOption(p);
        }
        public bool deleteOptionById(int id)
        {
            return optionProduct.deleteOptionById(id);
        }
    }
}
