using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien
{
    class DanhSachNhanVien
    {
        private int SoLuongNhanVien;
        string[] DS;
        public void nhap()
        {
            Console.Write("Nhap so luong nhan vien: ");
            SoLuongNhanVien = Convert.ToInt32(Console.ReadLine());
            DS = new string[SoLuongNhanVien];
            for(int i=0;i<SoLuongNhanVien;i++)
            {
                Console.Write("Nhan vien thu {0} la: ", i);
                DS[i] =Convert.ToString( Console.ReadLine());
            }
        }
        public void xuat()
        {
            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < SoLuongNhanVien; i++)
            {
                Console.WriteLine(DS[i]);
            }

        }
    }
}
