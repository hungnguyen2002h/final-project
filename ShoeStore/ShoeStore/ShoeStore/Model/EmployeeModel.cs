using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ShoeStore.Object;

namespace ShoeStore.Model
{
    internal class EmployeeModel
    {
        DatabaseConnection conn = new DatabaseConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dtb = new DataTable();

            cmd.CommandText = "SELECT * from Employee";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtb);
                conn.CloseConn();
            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            
            return dtb;
        }

        public bool AddData(EmployeeObject employee)
        {
            cmd.CommandText = "Insert into Employee values ('"+employee.Id+ "','"+employee.Name + "','" + employee.User + "','" + employee.Pass + "','" + employee.Age + "','" + employee.Gender + "','" + employee.PhoneNumber + "','" + employee.Address + "')";
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

        public bool UpdateData(EmployeeObject employee)
        {
            cmd.CommandText = "Update Employee set EmployeeName = '" + employee.Name + "', EmployeeUser = '" + employee.User + "', EmployeePass = '" + employee.Pass + "', EmployeeAge = '" + employee.Age + "', EmployeeGender = '" + employee.Gender + "', EmployeePhone = '" + employee.PhoneNumber + "', EmployeeAddress = '" + employee.Address + "'Where EID = '" + employee.Id + "'";
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

        public bool DeleteData(String Id)
        {
            cmd.CommandText = "Delete Employee Where EID = '" + Id + "'";
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
