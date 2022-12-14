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
    internal class EmployeeController
    {
        EmployeeModel emodel = new EmployeeModel();
        public DataTable getData()
        {
            return emodel.GetData();
        }

        public bool AddData(EmployeeObject employee)
        {
            return emodel.AddData(employee);
        }

        public bool UpdateData(EmployeeObject employee)
        {
            return emodel.UpdateData(employee);
        }

        public bool DeleteData(String id)
        {
            return emodel.DeleteData(id);
        }
    }
}
