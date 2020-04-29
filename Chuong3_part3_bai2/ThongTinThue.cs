using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_part3_bai2
{
    class ThongTinThue
    {
        private string hoTenThue;
        private int soGioThue;
        private Xe kieuXe;
        public void nhap()
        {
            try
            {
                Console.Write("Hay nhap ho ten nguoi thue: ");
                hoTenThue = Console.ReadLine();
                Console.Write("Nhap so gio thue: ");
                soGioThue = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hay chon loai xe can thue: Chon 1 neu la xe tai, chon 2 neu la xe du lich \n1/2?  ");
                int loaixe = Convert.ToInt32(Console.ReadLine());
                if (loaixe == 1)
                    kieuXe = new Xetai();
                else
                    kieuXe = new XeDuLich();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void xuat()
        {
            Console.WriteLine("Thong tin nguoi thue: {0}, so gio thue: {1}, so tien thue: {2}"
                , hoTenThue, soGioThue, kieuXe.tinhTien(soGioThue));
        }
        
    }
}
