using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4
{
    class TuDien:TamGiac
    {
        private double chieucao;
        public void nhap()
        {
            Console.Write("Nhap canh 1: ");
            canh1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh 2: ");
            canh2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh 3: ");
            canh3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap chieu cao: ");
            chieucao = Convert.ToDouble(Console.ReadLine());
        }
        public double thetich()
        {
            double the_tich = ( chieucao * dientich())/3;
            return the_tich;
        }

    }
}
