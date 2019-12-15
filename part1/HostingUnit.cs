using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class HostingUnit
    {
        private string HostingUnitKey;
        private Host Owner;
        private string HostingUnitName;
        private bool[,] Diary;

        public string HostingUnitKey1 { get => HostingUnitKey;}
        public string HostingUnitName1 { get => HostingUnitName; set => HostingUnitName = value; }
        public bool[,] Diary1 { get => Diary; set => Diary = value; }
        internal Host Owner1 { get => Owner; set => Owner = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
