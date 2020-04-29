using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_part3_bai2
{
    class Xetai : Xe
    {
        public double tinhTien(int soGioThue)
        {
            double sotien = 0;
            if (soGioThue <= 1)
                sotien = 220000;
            else
                sotien = 220000 + (soGioThue - 1) * 85000;
            return (sotien);
        }
    }
}
