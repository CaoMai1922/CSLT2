using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_part3_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThongTinThue A = new ThongTinThue();
           // A.nhap();
           // A.xuat();
            ThongTinThue[] DanhSach = new ThongTinThue[3];
            for(int i=0;i<3;i++)
            {
                DanhSach[i] = new ThongTinThue();
                DanhSach[i].nhap();

            }
            for(int i=0;i<3;i++)
            {
                DanhSach[i].xuat();
            }
            Console.Read();
        }
    }
}
