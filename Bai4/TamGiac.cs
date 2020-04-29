using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4
{
    class TamGiac
    {
        protected double canh1;
        protected double canh2;
        protected double canh3;
        public TamGiac(double canh1, double canh2, double canh3)
        {
            this.canh1 = canh1;
            this.canh2 = canh2;
            this.canh3 = canh3;
        }
        public TamGiac()
        {
            canh1 = canh2 = canh3 = 0;

        }
       
        public void xuat()
        {
            Console.WriteLine("ba canh tam giac vua nhap la: {0}   {1}    {2}", canh1, canh2, canh3);

        }
        public double dientich()
        {
            double dt,nuacv;
            nuacv = (canh1 + canh2 + canh3) / 2;
            dt = Math.Sqrt(nuacv * (nuacv - canh1) * (nuacv - canh2) * (nuacv - canh3));
            return dt;
        }
    }
}
