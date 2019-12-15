using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Order
    {
        private string HostingUnitKey;
        private string GuestRequestKey;
        private string OrderKey;
        private string Status;
        private DateTime CreateDate;
        private DateTime OrderDate;

        public string HostingUnitKey1 { get => HostingUnitKey;}
        public string GuestRequestKey1 { get => GuestRequestKey; }
        public string OrderKey1 { get => OrderKey;}
        public string Status1 { get => Status; set => Status = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }
        public DateTime OrderDate1 { get => OrderDate; set => OrderDate = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
