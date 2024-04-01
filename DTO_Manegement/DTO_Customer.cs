using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_Customer
    {
        private int id;
        private string fullname;
        private string phone;
        private string addres;

        public DTO_Customer(int id, string fullname, string phone, string addres)
        {
            this.id = id;
            this.fullname = fullname;
            this.phone = phone;
            this.addres = addres;
        }
        public DTO_Customer() { }
        public int getId() { return id; }
        public string getfullname() { return fullname; }
        public string getphone() { return phone; }
        public string getaddres() { return addres; }
        public void setfullname(string fullname) { this.fullname = fullname; }
        public void setphone(string phone) { this.phone = phone; }
        public void setId(int id) { this.id = id; }
        public void set(string addres) { this.addres = addres; }
    }
}
