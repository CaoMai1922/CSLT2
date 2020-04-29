using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien
{
    class NhanVienSanXuat : NhanVien
    {
        public int soSanPham;
        public NhanVienSanXuat(string ht, string dc, DateTime ns, int sp) : base(ht, dc, ns)
        {
            this.soSanPham = sp;
        }
        //public NhanVienSanXuat()
        //{
        //    Console.Write("Nhap so san pham: ");
        //    soSanPham = Convert.ToInt32(Console.ReadLine());
        //}
        public double TienLuong()
        {
            luong = soSanPham * 30000;
            return luong;
        }
        public override void xuat()
        {
            Console.WriteLine();
            base.xuat();
            Console.Write(" So san pham: " + soSanPham);
           
        }
        
    }
}
