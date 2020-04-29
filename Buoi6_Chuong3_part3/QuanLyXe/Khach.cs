using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6_chuong3_part3.QuanLyXe
{
    class Khach
    {
        private string hoTen;
        private float SoGioThue;
        private string loaiXeThue;
        public void nhap()
        {
            Console.Write("Hay nhap ho ten nguoi thue: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap so gio thue: ");
            SoGioThue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap loai xe: ");
            loaiXeThue = Console.ReadLine();
        }
        public void hien()
        {
            Console.Write("Ten khach hang: {0}, loai xe: {1}, so gio thue: {2}", hoTen, loaiXeThue, SoGioThue);
        }
        public void TinhTien()
        {

        }
        
    }
}
