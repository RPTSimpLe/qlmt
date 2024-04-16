using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO_Manegement
{
    public class DTO_incomeStatistics
    {
        private int id;
        private string nameProduct;
        private string nameOptions;
        private int sellQuantity;
        private long sellPrice;
        private DateTime created_at;

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
        public int GetSellQuantity()
        {
            return sellQuantity;
        }

        public void SetSellQuantity(int sellQuantity)
        {
            this.sellQuantity = sellQuantity;
        }

        public long GetSellPrice()
        {
            return sellPrice;
        }

        public void SetSellPrice(long sellPrice)
        {
            this.sellPrice = sellPrice;
        }

        public DateTime GetCreated_at()
        {
            return created_at;
        }

        public void SetCreated_at(DateTime created_at)
        {
            this.created_at = created_at;
        }

        public DTO_incomeStatistics() { }

        public DTO_incomeStatistics(int id, string nameProduct, string nameOptions, int sellQuantity, long sellPrice, DateTime created_at)
        {
            this.id = id;
            this.nameProduct = nameProduct;
            this.nameOptions = nameOptions;
            this.sellQuantity = sellQuantity;
            this.sellPrice = sellPrice;
            this.created_at = created_at;
        }
    }
}
