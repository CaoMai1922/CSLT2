using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6_chuong3_part3.QuanLySinhVien
{
    class sinhVien
    {
        private string hoTen;
        private DateTime ngaySinh;
        private float diemCSLT, diemCSDL, diemThietKeWeb;
        
        public sinhVien()
        {
            hoTen = "";
            ngaySinh = new DateTime();
            diemCSLT = diemCSDL = diemThietKeWeb = 0;
        }
        public sinhVien(string hoTen, DateTime ngaySinh, float diemCSLT,float diemCSDL,float diemThietKeWeb )
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diemCSLT = diemCSLT;
            this.diemCSDL = diemCSDL;
            this.diemThietKeWeb = diemThietKeWeb;
        }
        
        public void nhap()
        {
            Console.Write("\nHay nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Hay nhap ngay sinh: ");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhap diem co so lap trinh: ");
            diemCSLT = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem co so du lieu: ");
            diemCSDL = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap diem thiet ke web: ");
            diemThietKeWeb = Convert.ToInt32(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("Ho ten: {0}, ngay sinh: {1}, diem cslt: {2}, diem csdl: {3}, diem web: {4}"
                , hoTen, ngaySinh, diemCSLT, diemCSDL, diemThietKeWeb);

        }
        public int KieuTotNghiep()
        {
            // 1: lam khoa luan, 2: lam chuyen de, 0: truot
            double diemtb = (diemCSLT + diemCSDL + diemThietKeWeb) / 3;
            int kieu = 0;
            bool duocTN = false;
            if ((diemCSLT >= 5) & (diemCSDL >= 5) & (diemThietKeWeb >= 5))
                duocTN = true;
            if(duocTN==true)
            {
                if (diemtb >= 8)
                    kieu = 1;
                else
                    kieu = 2;
            }


            return kieu;
        }
    }
}
