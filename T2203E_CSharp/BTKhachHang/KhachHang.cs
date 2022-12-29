using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.BTKhachHang
{
    public class KhachHang
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime BillDate { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public class KHVN : KhachHang
    {
        public string LoaiKH { get; set; }
        
        public KHVN(string id, string name, DateTime billDate, string loaiKH, int quantity, int price)
        {
            Id = id;
            Name = name;
            BillDate = billDate;
            LoaiKH = loaiKH;
            Quantity = quantity;
            Price = price;
        }
    }

    public class KHNN : KhachHang
    {
        public string QuocGia { get; set; }

        public KHNN(string id, string name, DateTime billDate, string quocgia, int quantity, int price)
        {
            Id = id;
            Name = name;
            BillDate = billDate;
            QuocGia = quocgia;
            Quantity = quantity;
            Price = price;
        }
    }


    public class QLHoaDon
    {
        public int TinhHoaDon(KHVN khachhang)
        {
            int HoaDon;
            if (khachhang.Quantity > 50)
            {
                HoaDon = khachhang.Quantity * khachhang.Price;
            }
            else if (khachhang.Quantity <= 100)
            {
                HoaDon = 50 * 1000 + (khachhang.Quantity - 50) * 1200;
            }
            else if (khachhang.Quantity <= 200)
            {
                HoaDon = 50 * 1000 + 50 * 1200 + (khachhang.Quantity - 100) * 1500;
            }
            else
            {
                HoaDon = 50 * 1000 + 50 * 1200 + 100 * 1500 + (khachhang.Quantity - 200) * 2000;
            }
            return HoaDon;
        }

        public int TinhHoaDon(KHNN khachhang)
        {
            return khachhang.Quantity * khachhang.Price;
        }

    }

}
