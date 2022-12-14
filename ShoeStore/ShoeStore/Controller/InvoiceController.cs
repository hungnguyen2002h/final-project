using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Model;
using ShoeStore.Object;

namespace ShoeStore.Controller
{
    internal class InvoiceController
    {
        InvoiceModel imodel = new InvoiceModel();
        public DataTable getData()
        {
            return imodel.GetData();
        }

        public bool ImportQuantity(InvoiceObject invoice)
        {
            return imodel.ImportQuantity(invoice);
        }

        public bool ExportQuantity(InvoiceObject invoice)
        {
            return imodel.ExportQuantity(invoice);
        }
    }
}
