﻿using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL_Manegement;

namespace DAL_Manegement
{
    public class DAL_Product : DBConnect
    {
        private SqlDataAdapter dataAdapter;
        
        public long GetProductId()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "select top 1 id as [ID] from product order by id desc", conn
                );
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return Convert.ToInt32(dt.Rows[0]["ID"].ToString());
        }
        public DataTable findProduct(String name, String type, String hang)
        {
            string sql = "exec sp_select_product @nameProduct = @name, @nameCategory = @type, @nameProducer = @hang";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@name", "%" + name + "%");
            comm.Parameters.AddWithValue("@type", "%" + type + "%");
            comm.Parameters.AddWithValue("@hang", "%" + hang + "%");

            dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable findProductById(int id)
        {
            string sql = "exec sp_select_productById @id";

            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", id);
            dataAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public bool addProduct(DTO_product product)
        {
            try
            {
                conn.Open();

                string s1 = "exec sp_insert_product @nameProduct,@year,@description,@warrantly,@nameCategory,@nameProducer";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@nameProduct", product.getNameProduct());
                comm.Parameters.AddWithValue("@year", product.getYears());
                comm.Parameters.AddWithValue("@id", product.getId());
                comm.Parameters.AddWithValue("@description", product.getDescription());
                comm.Parameters.AddWithValue("@warrantly", product.getWarranty());
                comm.Parameters.AddWithValue("@nameCategory", product.getNameCategory());
                comm.Parameters.AddWithValue("@nameProducer", product.getNameProducer());

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

        public bool updateProduct(DTO_product product)
        {
            try
            {
                conn.Open();

                string s1 = "exec sp_update_product @id,@nameProduct,@year,@description,@warrantly,@nameCategory,@nameProducer";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@nameProduct", product.getNameProduct() );
                comm.Parameters.AddWithValue("@year", product.getYears());
                comm.Parameters.AddWithValue("@id", product.getId());
                comm.Parameters.AddWithValue("@description", product.getDescription() );
                comm.Parameters.AddWithValue("@warrantly", product.getWarranty() );
                comm.Parameters.AddWithValue("@nameCategory", product.getNameCategory() );
                comm.Parameters.AddWithValue("@nameProducer", product.getNameProducer() );

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
        public bool deleteProductById(int id)
        {
            try
            {
                conn.Open();

                string s1 = "DELETE FROM product WHERE id = @Id";
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
        public bool checkDuplicateProduct(string code, string name)
        {
            try
            {
                conn.Open();

                string s1 = "SELECT COUNT(*) FROM Product WHERE code = @Code AND nameProduct = @Name";
                SqlCommand comm = new SqlCommand(s1, conn);
                comm.Parameters.AddWithValue("@Code", code);
                comm.Parameters.AddWithValue("@Name", name);

                int count = (int)comm.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
