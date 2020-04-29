using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6_chuong3_part3.QuanLyXe
{
    class QuanLy
    {
        Xe[] DS;
        private int n;
        public void nhap()
        {
            Console.Write("Nhap so luong khach hang: ");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new Xe[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("Nhap khach hang thu {0}: " , i + 1);
                DS[i].nhap();
            }
        }
        public void hien()
        {
            Console.WriteLine("Danh sach khach hang la: ");
            for (int i = 0; i < n; i++)
            {
                DS[i].hien();
            }
        }
    }
}
