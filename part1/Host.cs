using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Host
    {
        private string HostKey;
        private string PrivatrName;
        private string PrivateFamily;
        private string PhoneNumber;
        private string MailAddress;
        private BankAccount BankAccount;
        private bool CollectionClearance;

        public string HostKey1 { get => HostKey;}
        public string PrivatrName1 { get => PrivatrName; set => PrivatrName = value; }
        public string PrivateFamily1 { get => PrivateFamily; set => PrivateFamily = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string MailAddress1 { get => MailAddress; set => MailAddress = value; }
        public bool CollectionClearance1 { get => CollectionClearance; set => CollectionClearance = value; }
        internal BankAccount BankAccount1 { get => BankAccount; set => BankAccount = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
