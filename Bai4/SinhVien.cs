using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4
{
    class SinhVien: Nguoi
    {
        private string maSV;
        public void nhap()
        {
            Console.WriteLine("Nhap ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap que quan: ");
            queQuan = Console.ReadLine();
            Console.WriteLine("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();
        }
        public void xuat()
        {
            Console.Write("thong tin cua sinh vien: " + hoTen
                + "; ma: " + maSV + "; ngay sinh: " + ngaySinh.ToString() +
                "; que quan: " + queQuan);
        }
    }
}
