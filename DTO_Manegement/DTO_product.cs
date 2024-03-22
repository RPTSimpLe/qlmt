using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_product
    {
        private int id;
        private string nameProduct;
        private int years;
        private String description;
        private String warranty;
        private String nameCategory, nameProducer;

        public DTO_product(int id, string nameProduct, int years, string description, string warranty, string nameCategory, string nameProducer)
        {
            this.id = id;
            this.nameProduct = nameProduct;
            this.years = years;
            this.description = description;
            this.warranty = warranty;
            this.nameCategory = nameCategory;
            this.nameProducer = nameProducer;
        }

        public DTO_product() { }

        public int getId() { return id; }
        public string getNameProduct() { return nameProduct;}
        public int getYears() { return years;}
        public String getDescription() { return description;}
        public String getWarranty() {  return warranty;}
        public String getNameCategory() { return nameCategory;}
        public String getNameProducer() { return nameProducer;}
        public void setId(int id) { this.id = id; }
        public void setNameProduct(String nameProduct) { this.nameProduct = nameProduct; }

        public void setYears(int years) { this.years = years; }
        public void setDescription(String description) { this.description = description; }
        public void setNameCategory(String nameCategory) { this.nameCategory = nameCategory; }
        public void setWarranty(String warranty) { this.warranty = warranty; }
        public void setNameProducer(String nameProducer) { this.nameProducer = nameProducer; }
    }
}
