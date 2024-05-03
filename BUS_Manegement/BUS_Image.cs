using DAL_Manegement;
using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Manegement
{
    public class BUS_Image
    {
        private DAL_Image DAL_Image = new DAL_Image();

        public string getByUrl(int productId)
        {
            return DAL_Image.getByUrl(productId);
        }
        public bool add(DTO_Image img)
        {
            return DAL_Image.add(img);
        }

        public bool update(DTO_Image img)
        {
            return DAL_Image.update(img);
        }
    }
}
