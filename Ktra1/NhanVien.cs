using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra1
{
    class NhanVien:Nguoi
    {
       
        private string maNV;
        private string chucVu;
        private string phongBan;
        private double heSoLuong;
       
        public double ThuNhap()
        {
            return Convert.ToDouble(heSoLuong * 1080000);
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write("Hay nhap chuc vu: ");
            chucVu = Console.ReadLine();
            Console.Write("Hay nhap ten phong ban: ");
            phongBan = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            heSoLuong = Convert.ToDouble(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("Ma nhan vien: {0}, chuc vu: {1}, phong ban: {2}, he so luong: {3}",
                maNV, chucVu, phongBan, heSoLuong);
            base.xuat();
        }
        public NhanVien()
        {
            hoTen = "Cao Thi Mai";
            ngaySinh = Convert.ToDateTime("19-02-2000");
        }
    }
}
