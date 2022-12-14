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
    internal class DeliveryController
    {
        DeliveryModel imodel = new DeliveryModel();
        public DataTable getData()
        {
            return imodel.GetData();
        }

        public bool UpdateDeli(DeliveryObject delivery)
        {
            return imodel.UpdateDeli(delivery);
        }
    }
}
