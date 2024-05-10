using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_Manegement;
using DTO_Manegement;
using DAL_Manegement;
using System.Data;

namespace BUS_Manegement
{
    public class BUS_optionProduct
    {
        private static DAL_optionProduct optionProduct = new DAL_optionProduct();
        public DataTable getAllData(int id)
        {
            return optionProduct.getAll(id);
        }
        public DataTable findName(int id)
        {
            return optionProduct.findName(id);
        }
        public DTO_optionProduct findById(int id)
        {
            return optionProduct.findById(id);
        }

        public DataTable findId(String ram, String storage, long sellingPrice)
        {
            return optionProduct.findId(ram, storage, sellingPrice);
        }
        public DataTable findIdOp(int proId)
        {
            return optionProduct.findIdOp(proId);
        }
        public bool addOption(DTO_optionProduct p)
        {
            return optionProduct.addOption(p);
        }
        public bool updateOption(DTO_optionProduct p, int i)
        {
            return optionProduct.updateOption(p, 1);
        }
        public bool deleteOptionById(int id)
        {
            return optionProduct.deleteOptionById(id);
        }
    }
}
