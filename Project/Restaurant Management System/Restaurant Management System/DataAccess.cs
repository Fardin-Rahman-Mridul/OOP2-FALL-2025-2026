using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{

    internal class DataAccess
    {
        private SqlConnection sqlcon;
       
        public DataAccess()
        {
            string cs = @"Data Source=DESKTOP-SKDGCME\SQLEXPRESS;Database=RestaurantManagement;Trusted_Connection=True;TrustServerCertificate=True;";
            this.sqlcon = new SqlConnection(cs);
        }

       

        public DataSet ExecuteQuery(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("DB Error: " + ex.Message);
            }
            return ds;
        }
    
        public DataTable ExecuteQueryTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("DB Error: " + ex.Message);
            }
            return dt;
        }

     
        public int ExecuteUpdateQuery(string sql)
        {
            int rows = 0;
            try
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlcon))
                {
                    rows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("DB DML Error: " + ex.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            return rows;
        }

     
    }
}
