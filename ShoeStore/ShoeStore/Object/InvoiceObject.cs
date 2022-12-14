using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Object
{
    internal class InvoiceObject
    {
        String id, name, pid;
        int import, export;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Pid { get => pid; set => pid = value; }
        public int Import { get => import; set => import = value; }
        public int Export { get => export; set => export = value; }

        public InvoiceObject() { }

        public InvoiceObject(string id, string name, string pid, int import, int export)
        {
            Id = id;
            Name = name;
            Pid = pid;
            Import = import;
            Export = export;
        }
    }
}
