using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien
{
    class NhanVien
    {
        protected string hoTen;
        protected string diaChi;
        protected DateTime ngaySinh = new DateTime();
        public double luong;
        public NhanVien()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
        }
        public NhanVien(string ht, string dc, DateTime ns)
        {
            this.hoTen = ht;
            this.diaChi = dc;
            this.ngaySinh = ns;
        }
        public double TienLuong()
        {
            return luong;
        }
        public virtual void xuat()
        {
            Console.Write(" " +
                "Ho ten nhan vien la: " + hoTen + ", dia chi: " + diaChi + ", ngay sinh: " + ngaySinh.ToString());

        }


    }
}
