using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4
{
    class Nguoi
    {
        protected string hoTen;
        protected DateTime ngaySinh = new DateTime();
        protected string queQuan;
        public void xuat()
        {
            Console.Write("Thong tin cua sinh vien: " + hoTen + " ngay sinh" 
                + ngaySinh.ToString() + " que quan: " + queQuan);

        }
    }
}
