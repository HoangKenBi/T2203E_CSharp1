using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.BTHetMon.BT2
{
    public class Home
    {
        public double weight;
        public string name;
        public Home(double weight, string name)
        {
            SetMe(weight, name);
        }

        public void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}
