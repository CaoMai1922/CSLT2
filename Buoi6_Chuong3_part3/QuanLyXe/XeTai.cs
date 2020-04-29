using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6_chuong3_part3.QuanLyXe
{
    class XeTai:Xe
    {
       
        public override void nhap()
        {
            Console.Write("Nhap so gio thue: ");
            soGioThue = Convert.ToInt32(Console.ReadLine());
        }
        public override void hien()
        {
            Console.Write("So gio thue: {0}", soGioThue);
        }
        public override float tinhTien()
        {
            return 220000 + 85000*(soGioThue - 1);

        }
    }
}
