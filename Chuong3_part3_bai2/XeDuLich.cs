using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_part3_bai2
{
    class XeDuLich:Xe
    {
        public double tinhTien(int soGioThue)
        {
            double tongtien = 0;
            if (soGioThue <= 1)
                tongtien = 250000;
            else
                tongtien = Convert.ToDouble(250000 + (soGioThue - 1) * 70000);
            return tongtien;
        }
    }
}
