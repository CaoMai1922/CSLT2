using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6_chuong3_part3.HinhHoc
{
    class HinhChuNhat:HinhHoc
    {
        private int chieuRong, chieuDai;
        public override double chuVi()
        {
            return 2 * (chieuRong + chieuDai);
        }
        public override double dienTich()
        {
            return chieuRong * chieuDai;
        }
        public override void nhap()
        {
            Console.Write("Nhap chieu rong hinh chu nhat: ");
            chieuRong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu dai hinh chu nhat: ");
            chieuDai = Convert.ToInt32(Console.ReadLine());

        }
    }
}
