using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_detailBill
    {
        private string namePro;
        private string ram;
        private string storage;
        private double price;
        private double quantity;
        private double tongTien;

        public DTO_detailBill() { }
        public DTO_detailBill(string namePro, string ram, string storage, double price, double quantity, double tongTien)
        {
            this.namePro = namePro;
            this.ram = ram;
            this.storage = storage;
            this.price = price;
            this.quantity = quantity;
            this.tongTien = tongTien;
        }
        public String getNamePro()
        {
            return namePro;
        }

        public void setNamePro(String namePro)
        {
            this.namePro = namePro;
        }

        public String getRam()
        {
            return ram;
        }

        public void setRam(String ram)
        {
            this.ram = ram;
        }

        public String getStorage()
        {
            return storage;
        }

        public void setStorage(String storage)
        {
            this.storage = storage;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public double getQuantity()
        {
            return quantity;
        }

        public void setQuantity(double quantity)
        {
            this.quantity = quantity;
        }

        public double getTongTien()
        {
            return tongTien;
        }

        public void setTongTien(double tongTien)
        {
            this.tongTien = tongTien;
        }
    }
}
