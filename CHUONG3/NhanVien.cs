using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CHUONG1
{
    class NhanVien
    {
        private string hoten, diachi;
        private int namsinh;
        private double luongcb, heso, phucap, tongtien;
        
        public void nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();
            Console.Write("Luong co ban: ");
            luongcb= Convert.ToInt32(Console.ReadLine());
            Console.Write("He so: ");
            heso= Convert.ToInt32(Console.ReadLine());
            Console.Write("Phu cap: ");
            phucap= Convert.ToInt32(Console.ReadLine());


        }
        public void luong()
        {
            tongtien = luongcb * heso + phucap;
            Console.Write("Tien luong duoc nhan la: " + tongtien);
        }
        public void xuat()
        {
            Console.Write("\nHo ten: " + hoten + "  Nam sinh: " + namsinh + "  Dia chi: " + diachi + "  Tien luong: " + tongtien);
        }
    }
}
