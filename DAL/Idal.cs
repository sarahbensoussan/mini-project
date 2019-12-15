using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface Idal
    {
        void addGuestRequest(GuestRequest gR);
        void updateGuestRequest(GuestRequest gR);
        void addHostingUnit(HostingUnit hU);
        void deleteHostingUnit(HostingUnit hU);
        void updateHostingUnit(HostingUnit hU);
        void addOrder(Order order);
        void updateOrder(Order order);
        void allHostingUnit();
        void allGuests();
        void allOrders();
        List<BankAccount> allBranches();

    }
}
