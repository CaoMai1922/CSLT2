using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4
{
    class TienDien
    {
        protected string tenChuHo, diaChi;
        protected int soCongToThangTruoc, soCongToThangNay;
        protected int soDien, tienDien;
        protected int soCongToDaDung;
        public TienDien(string tenChuHo, string diaChi, int soCongToThangTruoc, int soCongToThangNay)
        {
            this.tenChuHo = tenChuHo;
            this.diaChi = diaChi;
            this.soCongToThangTruoc = soCongToThangTruoc;
            this.soCongToThangNay = soCongToThangNay;
        }
        public TienDien()
        {
            tenChuHo = "";
            diaChi = "";
            soCongToThangTruoc = soCongToThangNay = 0;
        }
        public virtual void nhap()
        {
            Console.Write("Hay nhap vao ten chu ho: ");
            tenChuHo = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap so cong to thang truoc: ");
            soCongToThangTruoc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so cong to thang nay: ");
            soCongToThangNay = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void hien()
        {
            Console.WriteLine("Ten chu ho: {0}, dia chi: {1}, so cong to thang truoc la: {2}" +
                ", so cong to thang nay la: {3}", tenChuHo, diaChi, soCongToThangTruoc, soCongToThangNay);
        }
 
        public int TinhTienDien()
        {
            soCongToDaDung = soCongToThangNay - soCongToThangTruoc;
            return soCongToDaDung * 500;
        }
    }
}
