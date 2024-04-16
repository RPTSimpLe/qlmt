using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Manegement;
using System.Data.Common;

namespace DAL_Manegement
{
    public class DAL_DetailBill : DBConnect
    {
        private DAL_incomeStatistics dal_in = new DAL_incomeStatistics();
        public List<DTO_detailBill> findDetailBill(String idBill)
        {
            string sql = "\tselect product.nameProduct as[tensp], options.ram as [ram], options.storage as [ocung], " +
                "detailBill.price as [dongia], detailBill.quantity as [sl], (detailBill.price * detailBill.quantity) as [tien] " +
                "from detailBill " +
                "join options on options.id = detailBill.options_id " +
                "join product on product.id = options.product_id " +
                "where detailBill.bill_id = @idBill";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@idBill", idBill); 

            SqlDataAdapter dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

           List<DTO_detailBill> list = new List<DTO_detailBill>();
           for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_detailBill detailBill = new DTO_detailBill();
                detailBill.setNamePro(dt.Rows[i]["tensp"].ToString());
                detailBill.setRam(dt.Rows[i]["ram"].ToString());
                detailBill.setStorage(dt.Rows[i]["ocung"].ToString());
                detailBill.setQuantity(Convert.ToInt64(dt.Rows[i]["sl"].ToString()));
                detailBill.setPrice(Convert.ToInt64(dt.Rows[i]["dongia"].ToString()));
                detailBill.setTongTien(Convert.ToInt64(dt.Rows[i]["tien"].ToString()));
                list.Add(detailBill);
            }

            return list;
        }
        public bool addBill(List<DTO_bill> bills)
        {
            try
            {
                conn.Open();

               foreach (DTO_bill bill in bills)
                {
                    string s2 = "insert into detailBill (quantity,price,bill_id,options_id) values (@quantity,@price,@bill_id,@options_id)";
                    SqlCommand comm2 = new SqlCommand(s2, conn);
                    comm2.Parameters.AddWithValue("@price", bill.getprice());
                    comm2.Parameters.AddWithValue("@quantity", bill.getQuantity());
                    comm2.Parameters.AddWithValue("@bill_id", bill.getId());
                    comm2.Parameters.AddWithValue("@options_id", bill.getoptionProduct_id());
                    comm2.ExecuteNonQuery();


                }
                addIncomeStatistics(bills);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public void addIncomeStatistics(List<DTO_bill> bills)
        {
           foreach (DTO_bill bill in bills)
            {
                string select = "SELECT product.nameProduct AS [tensp], options.ram, options.storage from options " +
                    "join product on product.id = options.product_id " +
                    "WHERE options.id = @option_id ";
                SqlCommand comm2 = new SqlCommand(select, conn);
                comm2.Parameters.AddWithValue("@option_id", bill.getoptionProduct_id());
                DataTable dt = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comm2);
                dataAdapter.Fill(dt);

                DTO_incomeStatistics dTO = new DTO_incomeStatistics(0, dt.Rows[0]["tensp"].ToString(), "ram: " + dt.Rows[0]["ram"].ToString() + " - ổ cứng: " + dt.Rows[0]["storage"].ToString(),
                                                                        Convert.ToInt32(bill.getQuantity()), bill.getprice(), DateTime.Now);

                string select3 = "select incomeStatistics.nameProduct, incomeStatistics.nameOptions, " +
                    "incomeStatistics.sellQuantity, incomeStatistics.sellPrice, incomeStatistics.created_at " +
                    "from incomeStatistics where nameOptions = @nameOptions and nameProduct= @nameProduct";
                SqlCommand comm3 = new SqlCommand(select3, conn);
                comm3.Parameters.AddWithValue("@nameOptions", "ram: " + dt.Rows[0]["ram"].ToString() + " - ổ cứng: " + dt.Rows[0]["storage"].ToString());
                comm3.Parameters.AddWithValue("@nameProduct", dt.Rows[0]["tensp"].ToString());
                DataTable dt3 = new DataTable();
                SqlDataAdapter dataAdapter3 = new SqlDataAdapter(comm3);
                dataAdapter3.Fill(dt3);
               
                int count = 0;
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        if (dt3.Rows[i]["sellPrice"].ToString() == dTO.GetSellPrice().ToString())
                        {
                            dal_in.update(dTO);
                            count++;
                        }
                    }
                    
                   if (count==0) { dal_in.add(dTO); }
            }
        }
        public bool deleteBillById(String id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM detailBill WHERE bill_id = @Id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Id", id);

                if (comm.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
