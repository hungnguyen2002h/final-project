using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ShoeStore.Object;
using System.Windows.Forms;

namespace ShoeStore.Model
{
    internal class DeliveryModel
    {
        DatabaseConnection conn = new DatabaseConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dtb = new DataTable();

            cmd.CommandText = "Select * from Receipt";
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
        public bool UpdateDeli(DeliveryObject delivery)
        {
            cmd.CommandText = "Update Receipt Set Status = '" + delivery.Status + "', Payment = '" + delivery.Payment + "' Where RID = '" + delivery.Id + "'";
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
