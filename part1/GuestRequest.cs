using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        private int GuestRequestKey;
        private string PrivateName;
        private string FamilyName;
        private string MailAddress;
        private string Status;
        private DateTime RegistrationDate;
        private DateTime EntryDate;
        private DateTime ReleaseDate;
        private string Area;
        private string SubArea;
        private string Type;
        private int Adults;
        private int Children;
        private string Pool;
        private string Jacuzzi;
        private string Garden;
        private string ChildrensAttractions;

        public string PrivateName1 { get => PrivateName; set => PrivateName = value; }
        public string FamilyName1 { get => FamilyName; set => FamilyName = value; }
        public string MailAddress1 { get => MailAddress;}
        public string Status1 { get => Status; set => Status = value; }
        public DateTime RegistrationDate1 { get => RegistrationDate; }
        public DateTime EntryDate1 { get => EntryDate; set => EntryDate = value; }
        public DateTime ReleaseDate1 { get => ReleaseDate; set => ReleaseDate = value; }
        public string Area1 { get => Area; set => Area = value; }
        public string SubArea1 { get => SubArea; set => SubArea = value; }
        public string Type1 { get => Type; set => Type = value; }
        public int Adults1 { get => Adults; set => Adults = value; }
        public int Children1 { get => Children; set => Children = value; }
        public string Pool1 { get => Pool; set => Pool = value; }
        public string Jacuzzi1 { get => Jacuzzi; set => Jacuzzi = value; }
        public string Garden1 { get => Garden; set => Garden = value; }
        public string ChildrensAttractions1 { get => ChildrensAttractions; set => ChildrensAttractions = value; }
        public int GuestRequestKey1 { get => GuestRequestKey;}

        public override string ToString()
        {
            return MailAddress1 + Convert.ToString(GuestRequestKey1);
        }

    }
}
