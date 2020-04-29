using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUONG1
{
    class HinhChuNhat
    {
        private float chieuDai;
        private float chieuRong;
        public void nhap()
        {
            Console.Write("hay nhap chieu dai cua hcn ");
            chieuDai = float.Parse(Console.ReadLine());
            Console.Write("hay nhap chieu rong cua hcn ");
            chieuRong = float.Parse(Console.ReadLine());
        }
        public float dientich()
        {
            float dt=0;
            dt = chieuDai * chieuRong;
            return dt;
        }

        public HinhChuNhat(float dai, float rong)
            /*
             * PHUONG THUC KHOI TAO
             * ham khoi tao co public, ten lop, khong co kieu tra ve
             */
        {
            chieuDai = dai;
            chieuRong = rong;

        }
        
         ~HinhChuNhat()
            //Phuong thuc huy
          
        {
           
        }

    }
}
