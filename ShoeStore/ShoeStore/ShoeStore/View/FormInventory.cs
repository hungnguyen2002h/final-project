using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShoeStore.Model;

namespace ShoeStore.View
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand cmd = new SqlCommand();
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

            dgvShowInventory.DataSource = dtb;
        }
    }
}
