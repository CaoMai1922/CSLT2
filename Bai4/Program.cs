using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //SinhVien sv1 = new SinhVien();
            //sv1.nhap();
            //sv1.xuat();
            //Console.ReadKey();

            //TuDien td1 = new TuDien();
            //td1.nhap();
            //Console.Write("Dien tich day cua tu dien: " + td1.dientich());
            //Console.Write("\nThe tich cua tu dien la: " + td1.thetich());
            //Console.ReadKey();


            //TienDien td1 = new TienDien("Mai","Da Tien",100,150);
            //td1.hien();
            //td1.TinhTienDien();
            //Console.ReadKey();

            TienDien tienDien1 = new TienDien("Mai", "BN", 100, 700);
            TienDienMoi tienDien2 = new TienDienMoi("Mai", "BN", 100, 700, 300);
            TienDienMoi tienDien3 = new TienDienMoi("My", "HD", 20, 30, 100);
            TienDien tienDien4 = new TienDienMoi("My", "HD", 20, 30, 10);
            tienDien2.nhap();
            tienDien2.hien();
            Console.Write("So tien cua doi tuong tien dien 1 la: " + tienDien1.TinhTienDien());
            Console.Write("\nSo tien cua doi tuong tien dien 2 la: " + tienDien2.tinhTienDien());
            Console.Write("\nSo tien cua doi tuong tien dien 3 la: " + tienDien3.tinhTienDien());
            Console.Write("\nSo tien cua doi tuong tien dien 4 la: " + tienDien4.TinhTienDien());
            Console.ReadKey();
        }
    }
}
