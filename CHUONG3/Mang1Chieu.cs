using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUONG1
{
    class Mang1Chieu
    {
        private int n;
        int[] a;
        public void nhap()
        {
            
            Console.Write("Nhap so phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.Write("Nhap phan tu thu {0}: ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void xuat()
        {
            Console.WriteLine("Mang vua nhap la: ");
            for(int i=0;i<n;i++)
            {
                Console.Write(a[i]+"    ");
            }
            
        }
        public void sapxep()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[i])
                    {
                        //cach trao doi gia tri
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }

            Console.Write("\nMang sau khi sap xep: ");
            for(int i=0;i<n;i++)
            {
                Console.Write(a[i] + "    ");
            }
        }
        public void tim()
        {
            int x;
            int vt = 0;
            Console.Write("\nNhap vao so muon tim: ");
            x = Convert.ToInt32(Console.ReadLine());
            while (a[vt] != x && vt < n)
                vt++;
            if (vt < n)
            {
                Console.WriteLine("Vi tri so can tim la: " + vt);
            }

            else 
                Console.WriteLine("Khong tim thay");
        }
        
    }
}
