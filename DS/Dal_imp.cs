using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Dal_imp: Idal
    {
        public void addGuestRequest(GuestRequest gR)
        {
            GuestRequestList.Add(gR);
        }
        public void updateGuestRequest(GuestRequest gR)
        {
            foreach (var getR in GuestRequestList)
            {
                if (getR.GuestRequestKey == gR.GuestRequestKey)
                    getR = gR;
            }
        }
        public void addHostingUnit(HostingUnit hU)
        {
            HostingUnitList.Add(hU);
        }
        public void deleteHostingUnit(HostingUnit hU)
        {
            foreach (var hostingU in HostingUnitList)
            {
                if (hostingU.HostingUnitKey == hU.HostingUnitKey)
                    hostingU.remove(hU);
            }
        }
        public void updateHostingUnit(HostingUnit hU)
        {
            foreach (var hostingU in HostingUnitList)
            {
                if (hostingU.HostingUnitKey == hU.HostingUnitKey)
                    hostingU = hU;
            }
        }
        public void addOrder(Order order)
        {
            OrderList.Add(order);
        }
        public void updateOrder(Order order)
        {
            foreach (var o in OrderList)
            {
                if (o.OrderKey == order.OrderKey)
                    o = order;
            }
        }


    }
}
