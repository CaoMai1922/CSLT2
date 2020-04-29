using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien
{
    class NhanVienQuanLy:NhanVien
    {
        protected float HeSoLuong;
        protected float LuongCoBan;
        public NhanVienQuanLy(string ht, string dc, DateTime ns, float hs,float lcb):base(ht,dc,ns)
        {
            this.HeSoLuong = hs;
            this.LuongCoBan = lcb;
        }
        public double tienluong()
        {
            luong = HeSoLuong * LuongCoBan;
            return luong;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine(", he so luong: "+ HeSoLuong);
            Console.WriteLine(", luong co ban: " + LuongCoBan);
        }
    }
}
