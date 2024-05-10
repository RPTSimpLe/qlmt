using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Manegement;

namespace DAL_Manegement
{
    public class DAL_optionProduct : DBConnect
    {
        private DAL_expense_statistics dAL_Expense_Statistics = new DAL_expense_statistics();
        private SqlDataAdapter dataAdapter;
        public DataTable getAll(int product_id)
        {
            string sql = "select options.id as [id], options.ram as [ram], options.storage as [storage], options.quantity as [quantity], " +
                "options.importPrice as [importPrice],options.sellingPrice as [sellingPrice] from options where product_id = @id";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", product_id);
            DataTable dt = new DataTable();
            dataAdapter = new SqlDataAdapter(comm);
            dataAdapter.Fill(dt);
            return dt;
        }
        public bool addOption(DTO_optionProduct optionProduct)
        {
            try
            {
                conn.Open();

                string s1 = "INSERT INTO options(ram, storage, quantity, importPrice, sellingPrice, product_id) VALUES (@ram,@storage,@quantity,@importPrice,@sellingPrice,@product_id)";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@ram", optionProduct.getRam());
                comm.Parameters.AddWithValue("@storage", optionProduct.getStorage());
                comm.Parameters.AddWithValue("@quantity", optionProduct.getQuantity());
                comm.Parameters.AddWithValue("@importPrice", optionProduct.getImportPrice());
                comm.Parameters.AddWithValue("@sellingPrice", optionProduct.getSelllingPrice());
                comm.Parameters.AddWithValue("@product_id", optionProduct.getProduct_id());

                if (comm.ExecuteNonQuery() > 0)
                {
                    addExpenseStatics(optionProduct);
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
        public void addExpenseStatics(DTO_optionProduct optionProduct)
        {
            string select = "SELECT product.nameProduct AS [tensp] from product WHERE product.id = @product_id ";
            SqlCommand comm2 = new SqlCommand(select, conn);
            comm2.Parameters.AddWithValue("@product_id", optionProduct.getProduct_id());
            DataTable dt = new DataTable();
            dataAdapter = new SqlDataAdapter(comm2);
            dataAdapter.Fill(dt);

            DTO_expense_statistics dTO = new DTO_expense_statistics(0, dt.Rows[0]["tensp"].ToString(),"ram: "+optionProduct.getRam()+" - ổ cứng: "+optionProduct.getStorage(),
                                                                    Convert.ToInt32(optionProduct.getQuantity()),optionProduct.getImportPrice(), DateTime.Now);
            dAL_Expense_Statistics.add(dTO);
        }

        public void updateExpenseStatics(DTO_optionProduct optionProduct)
        {
            string select = "SELECT product.nameProduct AS [tensp] from product WHERE product.id = @product_id ";
            SqlCommand comm2 = new SqlCommand(select, conn);
            comm2.Parameters.AddWithValue("@product_id", optionProduct.getProduct_id());
            DataTable dt = new DataTable();
            dataAdapter = new SqlDataAdapter(comm2);
            dataAdapter.Fill(dt);

            DTO_expense_statistics dTO = new DTO_expense_statistics(0, dt.Rows[0]["tensp"].ToString(), "ram: " + optionProduct.getRam() + " - ổ cứng: " + optionProduct.getStorage(),
                                                                    Convert.ToInt32(optionProduct.getQuantity()), optionProduct.getImportPrice(), DateTime.Now);
            dAL_Expense_Statistics.update(dTO);
        }
        public DataTable findId(String ram, String storage, long sellingPrice)
        {
            string sql = "select id from options where ram = @ram and storage = @storage and sellingPrice = @sellingPrice";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@ram", ram);
            comm.Parameters.AddWithValue("@storage", storage );
            comm.Parameters.AddWithValue("@sellingPrice",  sellingPrice );

            dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable findIdOp(int proId)
        {
            string sql = "select id from options where product_id = @proId";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@proId", proId);

            dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable findName(int id)
        {
            string sql = "select product.nameProduct as [tensp], options.ram as [ram], options.storage as [storage] from options " +
                "join product on product.id = options.product_id " +
                "where options.id = @id";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", id);

            dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DTO_optionProduct findById(int id)
        {
            string sql = "select * from options where options.id = @id";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", id);

            dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            int idOp = Convert.ToInt32(dt.Rows[0]["id"].ToString());
            String ram = dt.Rows[0]["ram"].ToString();
            String storage = dt.Rows[0]["storage"].ToString();
            long quantity = Convert.ToInt64(dt.Rows[0]["quantity"].ToString());
            long importPrice = Convert.ToInt64(dt.Rows[0]["importPrice"].ToString());
            long sellingPrice = Convert.ToInt64(dt.Rows[0]["sellingPrice"].ToString());
            long product_id = Convert.ToInt64(dt.Rows[0]["product_id"].ToString());

            return new DTO_optionProduct(idOp, ram, storage, quantity, importPrice, sellingPrice, product_id);
        }
        public bool updateOption(DTO_optionProduct optionProduct, int i)
        {
            try
            {
                conn.Open();

                string s1 = "UPDATE options SET ram = @ram, storage =@storage, quantity = @quantity, importPrice = @importPrice, sellingPrice =@sellingPrice WHERE id = @id";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@ram", optionProduct.getRam());
                comm.Parameters.AddWithValue("@storage", optionProduct.getStorage());
                comm.Parameters.AddWithValue("@quantity", optionProduct.getQuantity());
                comm.Parameters.AddWithValue("@importPrice", optionProduct.getImportPrice());
                comm.Parameters.AddWithValue("@sellingPrice", optionProduct.getSelllingPrice());
                comm.Parameters.AddWithValue("@id", optionProduct.getId());

                if (comm.ExecuteNonQuery() > 0)
                {
                    if (i == 0)
                    {
                        updateExpenseStatics(optionProduct);
                    }
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
        public bool deleteOptionById(int id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM options WHERE id = @Id";
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
