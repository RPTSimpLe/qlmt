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
    public class Bus_detailBill
    {
        DAL_DetailBill detailBill = new DAL_DetailBill();

        public List<DTO_detailBill> findDetailBill(String idBill) {
            return detailBill.findDetailBill(idBill);
        }

    }
}
