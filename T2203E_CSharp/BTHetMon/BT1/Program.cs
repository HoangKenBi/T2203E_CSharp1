using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.BTHetMon.BT1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(38.64, 22.48);
            cylinder.Process();
            Console.WriteLine(cylinder.Result());
        }   
    }
}
