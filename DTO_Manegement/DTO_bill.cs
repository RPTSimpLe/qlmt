using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_bill
    {
        private String id;
        private long quantity;
        private long price;
        private int customer_id;
        private int optionProduct_id;

        public DTO_bill() { }
        public DTO_bill(long quantity, long price, int optionProduct_id)
        {
            this.quantity = quantity;
            this.price = price;
            this.optionProduct_id = optionProduct_id;
        }
        public DTO_bill(String id, long quantity, long price,  int customer_id, int optionProduct_id)
        {
            this.id = id;
            this.quantity = quantity;
            this.price = price;
            this.customer_id = customer_id;
            this.optionProduct_id = optionProduct_id;
        }
        public String getId() { return id; }
        public long getQuantity() { return quantity; }
        public long getprice() {  return price; }
        public int getCustomer_id() {  return customer_id; }
        public int getoptionProduct_id() { return optionProduct_id; }
        public void setId(String id) { this.id = id;}
        public void setQuantity(long quantity) { this.quantity = quantity; }
        public void setPrice(long price) { this.price = price; }
        public void setCustomer_id(int customer_id) { this.customer_id = customer_id; }
        public void setoptionProduct_id(int optionProduct_id) { this.optionProduct_id = optionProduct_id; }

    }
}
