using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_Users
    {
        private int id;
        private string fullname;
        private string username;
        private string pass;
        private string phone;
        private DateTime birthday;
        private string email;
        private string gender;
        private string address;
        private int role_id;


        public DTO_Users(int id, string fullname, string username, string pass, string gender, string phone, DateTime birthday, string email, string address, int role_id)
        {
            this.id = id;
            this.fullname = fullname;
            this.username = username;
            this.pass = pass;
            this.gender = gender;
            this.phone = phone;
            this.birthday = birthday;
            this.email = email;
            this.address = address;
            this.role_id = role_id;
        }
        public DTO_Users() { }


        public int getId()
        {
            return id;
        }
        public int getRole_id()
        {
            return role_id;
        }
        public void setRole_id(int role_id)
        {
            this.role_id = role_id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getFullname()
        {
            return fullname;
        }

        public void setFullname(String fullname)
        {
            this.fullname = fullname;
        }

        public String getUsername()
        {
            return username;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getPass()
        {
            return pass;
        }

        public void setPass(String pass)
        {
            this.pass = pass;
        }

        public String getPhone()
        {
            return phone;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public DateTime getBirthday()
        {
            return birthday;
        }

        public void setBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }
        public String getGender()
        {
            return gender;
        }
        public void setGender(string gender)
        {
            this.gender = gender;
        }

    }
}
