using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra1
{
    class Nguoi
    {
        
        protected string hoTen;
        protected DateTime ngaySinh;
        

        public virtual void nhap()
        {
            Console.Write("Hay nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Hay nhap ngay sinh: ");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ho ten: {0}, ngay sinh: {1}", hoTen, ngaySinh);
        }
    }
}
