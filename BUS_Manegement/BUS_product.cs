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
    public class BUS_product
    {
        private static DAL_Product DAL_Product = new DAL_Product();

        public DataTable getAllData()
        {
            return DAL_Product.findProduct("","","");
        }
        public bool AddProduct(DTO_product p)
        {
            return DAL_Product.addProduct(p);
        }
        public bool updateProduct(DTO_product p)
        {
            return DAL_Product.updateProduct(p);
        }
        public bool deleteProduct(int id)
        {
            return DAL_Product.deleteProductById(id);
        }
        public bool CheckDuplicateProduct(string code, string name)
        {
            return DAL_Product.checkDuplicateProduct(code, name);
        }
        public DataTable FindProduct(String name, String type, String hang)
        {
            return DAL_Product.findProduct(name,type,hang);
        }
        public long GetProductId()
        {
            return DAL_Product.GetProductId();
        }
        public DataTable FindProductById(int id)
        {
            return DAL_Product.findProductById(id);
        }
    }
}
