using ShoeStore.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Model
{
    internal class InvoiceModel
    {
        DatabaseConnection conn = new DatabaseConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dtb = new DataTable();

            cmd.CommandText = "Select * from Product";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtb);
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }

            return dtb;
        }

        public bool ImportQuantity(InvoiceObject invoice)
        {
            cmd.CommandText = "Insert into Invoice values ('" + invoice.Id + "','" + invoice.Name + "','" + invoice.Pid + "'," + invoice.Import + ", 0)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }

            cmd.CommandText = "Update Product Set Quantity = Quantity + " + invoice.Import + "Where PID = '" + invoice.Pid + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }

            return false;
        }

        public bool ExportQuantity(InvoiceObject invoice)
        {
            cmd.CommandText = "Insert into Invoice values ('" + invoice.Id + "','" + invoice.Name + "','" + invoice.Pid + "', 0," + invoice.Export + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }

            cmd.CommandText = "Update Product Set Quantity = Quantity - " + invoice.Export + "Where PID = '" + invoice.Pid + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();  
                conn.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }

            return false;
        }
    }
}
