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
    public class BUS_bill
    {
        private static DAL_bill bill = new DAL_bill();
        public DataTable findBill(string id, string nameCus)
        {
            return bill.findBill(id, nameCus);
        }
        public DataTable findAllFeatureBill(string id)
        {
            return bill.findAllFeatureBill(id);
        }
        public bool addBill(List<DTO_bill> dTO_Bills)
        {
            return bill.addBill(dTO_Bills);
        }
        public bool deleteBillById(String id)
        {
            return bill.deleteBillById(id);
        }
        public DataTable findLatedBill()
        {
            return bill.findAllLatedBill();
        }
    }
}
