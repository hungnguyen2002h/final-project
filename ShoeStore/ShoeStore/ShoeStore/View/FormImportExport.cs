using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStore.Controller;
using ShoeStore.Object;
using static System.Net.Mime.MediaTypeNames;

namespace ShoeStore.View
{
    public partial class FormImportExport : Form
    {
        InvoiceController invoiceCtrler = new InvoiceController();
        public FormImportExport()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormImportExport_Load_1(object sender, EventArgs e)
        {
            DataTable invoiceDtb = new DataTable();
            invoiceDtb = invoiceCtrler.getData();
            dgvInvoice.DataSource = invoiceDtb;
        }

        private void ImportQuantity(InvoiceObject imp)
        {
            imp.Id = textID.Text.Trim();
            imp.Name = textName.Text.Trim();
            imp.Pid = comboPID.Text.Trim();
            imp.Import = Convert.ToInt32(textQuantity.Text);
        }

        private void ExportQuantity(InvoiceObject imp)
        {
            imp.Id = textID.Text.Trim();
            imp.Name = textName.Text.Trim();
            imp.Pid = comboPID.Text.Trim();
            imp.Export = Convert.ToInt32(textQuantity.Text.Trim());
        }

        private void buttonImp_Click(object sender, EventArgs e)
        {
            InvoiceObject invoiceObj = new InvoiceObject();
            ImportQuantity(invoiceObj);
            if (invoiceCtrler.ImportQuantity(invoiceObj))
                MessageBox.Show("Fail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormImportExport_Load_1(sender, e);
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            InvoiceObject invoiceObj = new InvoiceObject();
            ExportQuantity(invoiceObj);
            if (invoiceCtrler.ExportQuantity(invoiceObj))
                MessageBox.Show("Fail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormImportExport_Load_1(sender, e);
        }
    }
}
