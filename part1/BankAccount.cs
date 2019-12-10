using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class BankAccount
    {
        private int BankNumber;
        private string BankName;
        private int BranchNumber;
        private string BranchAddress;
        private string BranchCity;
        private string BankAccountNumber;

        public int BankNumber1 { get => BankNumber;}
        public string BankName1 { get => BankName;}
        public int BranchNumber1 { get => BranchNumber;}
        public string BranchAddress1 { get => BranchAddress;}
        public string BranchCity1 { get => BranchCity;}
        public string BankAccountNumber1 { get => BankAccountNumber;}

        public override string ToString()
        {
            return BankName1 + " " + BranchCity1 + " " + BankAccountNumber1;
        }
    }
}
