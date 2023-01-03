using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.BT12
{
    public class HaNoiHouse : House
    {
        public String tenQuan;

        public HaNoiHouse()
        {

        }

        public HaNoiHouse(String tenQuan, String soNha, String diaChi, String loaiNha) : base(soNha, diaChi, loaiNha)
        {
            this.tenQuan = tenQuan;
        }

        public String TenQuan
        {
            get { return tenQuan; }
            set { tenQuan = value; }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Tên Quận: " + tenQuan);
        }
    }
}
