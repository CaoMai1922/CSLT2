using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUONG1
{
    class DanhSach
    {
        private int soluongsinhvien;    //Số lượng sinh viên
        private SinhVien[] danhSach = new SinhVien[50];   //Mảng chứa danh sách Sinh viên
        public void nhap()
        {
            Console.Write("Nhap so luong sinh vien: ");
            soluongsinhvien = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<soluongsinhvien;i++)
            {
                danhSach[i] = new SinhVien();
                danhSach[i].nhap();
            }
        }
        public void hienthi()
        {
            for (int i = 0; i < soluongsinhvien; i++)
                danhSach[i].xuat();
        }
    }
}
