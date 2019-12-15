using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class DataSource
    {
        List<GuestRequest> guestRequestList;
        List<HostingUnit> hostingUnitList;
        List<Order> ordersList;

        public List<GuestRequest> GuestRequestList { get => guestRequestList; set => guestRequestList = value; }
        public List<HostingUnit> HostingUnitList { get => hostingUnitList; set => hostingUnitList = value; }
        public List<Order> OrdersList { get => ordersList; set => ordersList = value; }

         
    }
}
