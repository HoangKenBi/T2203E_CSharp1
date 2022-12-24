using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.BTPhanSo
{
    internal class PhanSo
    {
        public int tuso { get; set; }
        public int mauso { get; set; }

        //Tính chất
        public double Value
        {
            get { return (double)tuso / mauso; }
        }

        // Nhập phân số
        public void Input()
        {
            Console.Write("Nhập tử số: ");
            tuso = int.Parse(Console.ReadLine());

            Console.Write("Nhập mẫu số: ");
            mauso = int.Parse(Console.ReadLine());
        }

        // In phân số
        public void Print()
        {
            Console.WriteLine("Phân số: {0}/{1}", tuso, mauso)
;
        }

        // rút gọn

        public int GetGCD(int tuso, int mauso)
        {
            throw new NotImplementedException();
        }
        public void Simplity()
        {
            int gcd = GetGCD(tuso, mauso);
            tuso /= gcd;
            mauso /= gcd;
        }

        // nghịch đảo
        public void Invert()
        {
            int temp = tuso;
            tuso = mauso;
            mauso = temp;

        }

        // cộng 2 phân số 
        public PhanSo Add(PhanSo other)
        {
            int newtuso = tuso * other.mauso + mauso * other.tuso;
            int newmauso = mauso * other.mauso;

            PhanSo result = new PhanSo();
            result.tuso = newtuso;
            result.mauso = newmauso;
            result.Simplity();
            return result;
        }

        // Trừ 2 phân số 
        public PhanSo Subtract(PhanSo other)
        {
            int newtuso = tuso * other.mauso - mauso * other.tuso;
            int newmauso = mauso * other.mauso;

            PhanSo result = new PhanSo();
            result.tuso = newtuso;
            result.mauso = newmauso;
            result.Simplity();
            return result;
        }
    }
}
