using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien
{
    class NhanVienCongNhat:NhanVien
    {
        protected float SoNgayCong;
        //protected int Luong;
        public NhanVienCongNhat(string ht, string dc, DateTime ns, float ngayCong) : base(ht, dc, ns)
        {
            this.SoNgayCong = ngayCong;
        }
        public double tienLuong()
        {
            luong = SoNgayCong * 90000;
            return luong;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine(" So ngay cong la: " + SoNgayCong);            
        }

    }
}
