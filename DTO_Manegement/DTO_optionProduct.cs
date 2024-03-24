using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO_Manegement
{
    public class DTO_optionProduct
    {
        private int id;
        private String ram;
        private String storage;
        private long quantity;
        private long importPrice;
        private long sellingPrice;
        private long product_id;

        public DTO_optionProduct() { }
        public DTO_optionProduct(int id, string ram, string storage, long quantity, long importPrice, long sellingPrice, long product_id)
        {
            this.id = id;
            this.ram = ram;
            this.storage = storage;
            this.quantity = quantity;
            this.importPrice = importPrice;
            this.sellingPrice = sellingPrice;
            this.product_id = product_id;
        }

        public int getId() { return id; }
        public String getRam() { return ram; }
        public String getStorage() { return storage; }
        public long getQuantity() { return quantity; }
        public long getImportPrice() { return importPrice; }
        public long getSelllingPrice() { return sellingPrice; }
        public long getProduct_id() { return product_id; }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setRam(String ram)
        {
            this.ram = ram;
        }

        public void setStorage(String storage)
        {
            this.storage = storage;
        }

        public void setQuantity(long quantity)
        {
            this.quantity = quantity;
        }

        public void setImportPrice(long importPrice)
        {
            this.importPrice = importPrice;
        }

        public void setSellingPrice(long sellingPrice)
        {
            this.sellingPrice = sellingPrice;
        }

        public void setProduct_id(long product_id)
        {
            this.product_id = product_id;
        }

    }
}
