using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Manegement
{
    public class DAL_bill : DBConnect
    {
        private DAL_DetailBill detailBill = new DAL_DetailBill();
        public DataTable findBill(string id, string nameCus)
        {
            try
            {
                conn.Open();

                string sql = "exec sp_select_bill @id , @nameCus";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", "%" + id + "%");
                comm.Parameters.AddWithValue("@nameCus", "%" + nameCus + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable findAllFeatureBill(string id)
        {
            try
            {
                conn.Open();

                string sql = "exec sp_select_feature_bill @id";

                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", id );

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable findAllLatedBill()
        {
            try
            {
                conn.Open();

                string sql = "select top 1 bill.id as [MaHD],sum(detailBill.price) as [tongTien], customers.fullname as [tenkh], " +
                    "customers.phone as [dienthoai],customers.addres as [diachi], bill.created_at as [ngaytao] " +
                    "from bill " +
                    "join detailBill on detailBill.bill_id = bill.id " +
                    "join options on options.id = detailBill.options_id " +
                    "join product on options.product_id = product.id " +
                    "join customers on customers.id = bill.customer_id " +
                    "Group by bill.id,product.nameProduct, customers.fullname ,bill.created_at,customers.phone ,customers.addres " +
                    "ORDER BY bill.created_at DESC";

                SqlCommand comm = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool addBill(List<DTO_bill> bills)
        {
            try
            {
                conn.Open();
                string s1 = "select top 1 id from bill order by id desc";
                SqlCommand comm = new SqlCommand(s1, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                string result = "HD001";
                if (dt.Rows.Count > 0)
                {
                    string input = dt.Rows[0]["id"].ToString();
                    string prefix = input.Substring(0, 2);
                    int number = int.Parse(input.Substring(2));
                    number++; // Tăng giá trị lên 1
                    result = prefix + number.ToString("D3");
                }


                string s2 = "insert into bill (id,customer_id,created_at) values (@id,@customer_id,(SELECT GETDATE()))";
                SqlCommand comm2 = new SqlCommand(s2, conn);
                comm2.Parameters.AddWithValue("@id", result);
                comm2.Parameters.AddWithValue("@customer_id", bills[0].getCustomer_id());

                foreach (DTO_bill bill in bills)
                {
                    bill.setId(result);
                }

                if (comm2.ExecuteNonQuery() > 0)
                {
                    detailBill.addBill(bills);
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
      
        public bool deleteBillById(String id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM bill WHERE id = @Id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Id", id);
                detailBill.deleteBillById(id);

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
