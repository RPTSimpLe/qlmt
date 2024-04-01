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
    public class BUS_Customer
    {
        public static DAL_Customer customer = new DAL_Customer();
        public DataTable getAllData()
        {
            return customer.getAll();
        }
        public bool addAccountCustomer(DTO_Customer customers)
        {
            return customer.addCustomer(customers);
        }
        public bool updateAccountCustomer(DTO_Customer customers)
        {
            return customer.updateCustomer(customers);
        }
        public DataTable findCustomerByFullName(string fullName)
        {
            return customer.findByFullNameByCustomer(fullName);
        }
    }
}
