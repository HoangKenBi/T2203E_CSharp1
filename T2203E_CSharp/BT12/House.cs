using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.BT12
{
    public class House : IHouse
    {
        public String soNha;
        public String diaChi;
        public String loaiNha;

        // Contructor k tham số
        public House()
        {
            this.soNha = "";
            this.diaChi = "";
            this.loaiNha = "";
        }

        // Contructor có tham số
        public House(string soNha, string diaChi, string loaiNha)
        {
            this.soNha = soNha;
            this.diaChi = diaChi;
            this.loaiNha = loaiNha;
        }

        // get set
        public String SoNha
        {
            get { return soNha; }
            set { soNha = value; }
        }
        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public String LoaiNha
        {
            get { return loaiNha; }
            set { loaiNha = value; }
        }

        // cài đè (override) display từ IHouse
        public virtual void Display()
        {
            Console.WriteLine("thông tin nhà: ");
            Console.WriteLine("Số nhà: ");
        }

        // cài đè (override) input từ IHouse
        public virtual void Input()
        {
            Console.WriteLine("Nhập thông tin  nhà: ");
            Console.WriteLine("Số nhà: ");
            soNha = Console.ReadLine();
            Console.WriteLine("Địa chỉ: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Loại nhà: ");
            loaiNha = Console.ReadLine();
        }

        


    }
}
