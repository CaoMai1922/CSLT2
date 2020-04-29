using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUONG1
{
    class SinhVien
    {
        //private string maSV;
        //private string HoTen;
        //private double cc, kt1, kt2, ck;
        //public static string tentruong;

        //public SinhVien(string ma, string ten)
        //{
        //    this.HoTen = ten;
        //    this.maSV = ma;
        //}
        //public void nhapdiem()
        //{
        //    Console.Write("nhap diem chuyen can: ");
        //    cc = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("nhap diem kiem tra 1: ");
        //    kt1 = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("nhap diem kiem tra 2: ");
        //    kt2 = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("nhap diem kiem tra cuoi ky: ");
        //    ck = Convert.ToDouble(Console.ReadLine());
        //}
        //public double TongKet()
        //{
        //    double tk=0;
        //    tk =cc*0.1+kt1*0.15+kt2*0.15+ck*0.6;
        //    Console.WriteLine("Diem tong ket cua ban la: " + tk);
        //    if (tk >= 4)
        //        Console.WriteLine("Chuc mung ban da qua mon.");
        //    else
        //        Console.WriteLine("Xin moi ban hoc lai.");
        //    return tk;
        //}
        //public void hienthi()
        //{
        //    Console.WriteLine("Sinh vien: " + HoTen + "Ma: " + maSV + "Hoc truong: " + tentruong);
        //}

        private string masv, hoten;
        private int namsinh;
        private double diemlt, diemcsdl, diemtb;
        public SinhVien(string masv, string hoten, int namsinh, double diemlt, double diemcsdl)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.diemlt = diemlt;
            this.diemcsdl = diemcsdl;
        }
        public SinhVien()
        {
            hoten = "";
            masv = "";
        }
        public void diem()
        {
            diemtb = (diemlt + diemcsdl) / 2;
        }
        public void xuat()
        {
            Console.WriteLine(" ma sinh vien: " + masv + " ho ten: " + hoten + " nam sinh: " + namsinh + " diem trung binh: " + diemtb);
        }
        public void nhap()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap ma sinh vien: ");
            masv = Console.ReadLine();
        } 
    }
}
