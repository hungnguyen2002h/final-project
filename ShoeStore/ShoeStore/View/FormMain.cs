using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore.View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void importExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormInventory();
            form.MdiParent = this;
            form.Show();
        }

        private void importExportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new FormImportExport();
            form.MdiParent = this;
            form.Show();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormStatistics();
            form.MdiParent = this;
            form.Show();
        }

        private void deliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormDeli();
            form.MdiParent = this;
            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
