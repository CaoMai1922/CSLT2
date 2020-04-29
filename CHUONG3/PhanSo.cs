using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUONG1
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;
        
        public PhanSo(int tu=0, int mau=1)
        {
            tuSo = tu;
            mauSo = mau;
        }
        public void nhap()
        {
            Console.Write("nhap tu so: ");
            tuSo = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap mau so: ");
            mauSo = Convert.ToInt32(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Phan so vua nhap la: "+ tuSo +"/"+ mauSo);

        }
        int ucln()
        {
            int a = tuSo;
            int b = mauSo;
            if (a == 0 || b == 0)
                return a + b;
            while(a!=b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        public void rutgon()
        {
            int uc = ucln();
            tuSo = tuSo / uc;
            mauSo = mauSo / uc;
        }
        public void tong()
        {

        }
    }
}
