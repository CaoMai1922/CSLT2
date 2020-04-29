using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6_chuong3_part3.QuanLySinhVien
{
    class DanhSachSinhVien
    {
        private sinhVien[] DanhSach;
        private int soLuongSV;
        public void Nhap()
        {
            Console.Write("Nhap so luong sinh vien: ");
            soLuongSV = Convert.ToInt32(Console.ReadLine());
            DanhSach = new sinhVien[soLuongSV];
            for(int i=0;i<soLuongSV;i++)
            {
                Console.Write("Nhap sinh vien thu {0}: ", i+1);
                DanhSach[i] = new sinhVien();
                DanhSach[i].nhap();               
            }
        }
        public void Hien()
        {
            Console.WriteLine("Danh sach sinh vien vua nhap la: ");
            for(int i=0;i<soLuongSV;i++)
            {
                DanhSach[i].hien();
            }
        }
        
        public int soLuongSVChuyenDe()
        {
            int dem = 0;

            for(int i=0;i<soLuongSV;i++)
            {
                if (DanhSach[i].KieuTotNghiep() == 2)
                    dem = dem + 1;
            }
            return dem;
        }
        public int soLuongSVKhoaLuan()
        {
            int dem = 0;
            for(int i=0;i<soLuongSV;i++)
            {
                if (DanhSach[i].KieuTotNghiep() == 1)
                    dem++;

            }
            return dem;
        }
    }
}
