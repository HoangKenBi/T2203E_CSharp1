using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.BTPhone
{
    internal class PhoneNumber
    {
        public PhoneNumber(string name, string phone)
        {
            Name = name;
            Phone = new List<string>();
            Phone.Add(phone);
        }

        public string Name { get; set; }

        public List<string> Phone { get; }
        
        public string this[int index]
        {
            get => Phone[index];
            set => Phone[index];
        }

    }
}
