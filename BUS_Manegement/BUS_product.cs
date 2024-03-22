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
    internal class BUS_product
    {
        private static DAL_Product DAL_Product = new DAL_Product();

        public DataTable getAllData()
        {
            return DAL_Product.findProduct("","","");
        }
        public bool AddProducer(DTO_product p)
        {
            return DAL_Product.addProducer(p);
        }
        public bool updateProducer(DTO_product p)
        {
            return DAL_Product.updateProducer(p);
        }
        public bool deleteProducer(int id)
        {
            return DAL_Product.deleteProducerById(id);
        }
        public bool CheckDuplicateProducer(string code, string name)
        {
            return DAL_Product.checkDuplicateProducer(code, name);
        }
        public DataTable FindProduct(String name, String type, String hang)
        {
            return DAL_Product.findProduct(name,type,hang);
        }
    }
}
