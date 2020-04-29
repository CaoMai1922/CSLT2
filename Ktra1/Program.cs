using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NhanVien[] mangNV = new NhanVien[2];
            for (int i = 0; i < 2; i++)
            {
                mangNV[i] = new NhanVien();
                mangNV[i].nhap();
            }
            for (int i = 0; i < 2; i++)
            {
                mangNV[i].xuat();
                Console.WriteLine("Thu nhap cua nhan vien la: " + mangNV[i].ThuNhap());
            }
            Console.Read();
        }
    }
}
