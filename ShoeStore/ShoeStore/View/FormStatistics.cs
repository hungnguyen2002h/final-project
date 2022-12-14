using ShoeStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore.View
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatictis_Load(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable dtb = new DataTable();

            cmd.CommandText = "Select * from Invoice";
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

            dgvStatistics.DataSource = dtb;
        }
    }
}
