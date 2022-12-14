using ShoeStore.Controller;
using ShoeStore.Model;
using ShoeStore.Object;
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
using static System.Net.Mime.MediaTypeNames;

namespace ShoeStore.View
{
    public partial class FormDeli : Form
    {
        DeliveryController deliveryCtrler = new DeliveryController();
        public FormDeli()
        {
            InitializeComponent();
        }

        private void FormDeli_Load(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            dtb = deliveryCtrler.getData();
            dgvReceipt.DataSource = dtb;
        }

        private void UpdateDeli(DeliveryObject deli)
        {
            int index = dgvReceipt.SelectedRows[0].Index;

            String IDAtIndex = (string)dgvReceipt.Rows[index].Cells[0].Value;

            deli.Status = "";
            deli.Payment = "";

            deli.Id = IDAtIndex;
            deli.Status = comboStatus.Text.Trim();
            deli.Payment = comboPayment.Text.Trim();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DeliveryObject deliObj = new DeliveryObject();
            UpdateDeli(deliObj);
            if (deliveryCtrler.UpdateDeli(deliObj))
                MessageBox.Show("Fail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormDeli_Load(sender, e);
        }
    }
}
