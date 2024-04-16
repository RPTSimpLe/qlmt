using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO_Manegement
{
    public class DTO_expense_statistics
    {
        private int id;
        private string nameProduct;
        private string nameOptions;
        private int importQuantity;
        private long importPrice;
        private DateTime created_at;


        public DTO_expense_statistics() { }
        public DTO_expense_statistics(int id, string nameProduct, string nameOptions, int importQuantity, long importPrice, DateTime created_at)
        {
            this.id = id;
            this.nameProduct = nameProduct;
            this.nameOptions = nameOptions;
            this.importQuantity = importQuantity;
            this.importPrice = importPrice;
            this.created_at = created_at;
        }
        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNameProduct()
        {
            return nameProduct;
        }

        public void SetNameProduct(string nameProduct)
        {
            this.nameProduct = nameProduct;
        }

        public string GetNameOptions()
        {
            return nameOptions;
        }

        public void SetNameOptions(string nameProduct)
        {
            this.nameOptions = nameOptions;
        }

        public int GetImportQuantity()
        {
            return importQuantity;
        }

        public void SetImportQuantity(int importQuantity)
        {
            this.importQuantity = importQuantity;
        }

        public long GetImportPrice()
        {
            return importPrice;
        }

        public void SetImportPrice(long importPrice)
        {
            this.importPrice = importPrice;
        }

        public DateTime GetCreated_at()
        {
            return created_at;
        }

        public void SetCreated_at(DateTime created_at)
        {
            this.created_at = created_at;
        }
    }
}
