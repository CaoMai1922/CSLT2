using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            //NhanVien nv1 = new NhanVien("mai", "xl", Convert.ToDateTime("19/02/2000"));
            //nv1.xuat();

            //NhanVienSanXuat n1 = new NhanVienSanXuat("Phuong", "da tien", Convert.ToDateTime("02/02/1997"), 10);
            //n1.xuat();
            //Console.WriteLine(" So tien luong cua nhan vien la: " + n1.TienLuong());

            //NhanVienCongNhat m1 = new NhanVienCongNhat("My", "HN", Convert.ToDateTime("01-12-1998"), 2.5f);
            //m1.xuat();
            //Console.Write(" Luong cua ban la: "+ m1.tienLuong());

            //NhanVienQuanLy q1 = new NhanVienQuanLy("Na","TB",Convert.ToDateTime("09/09/1889"),2,4.5f);
            //q1.xuat();
            //Console.Write(" Tien luong: " + q1.tienluong());

           // string[] DS = new string[100];
            DanhSachNhanVien ds1 = new DanhSachNhanVien();
            ds1.nhap();
            ds1.xuat();
            Console.ReadKey();
        }
    }
}
