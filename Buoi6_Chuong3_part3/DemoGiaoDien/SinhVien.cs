using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6_chuong3_part3.DemoGiaoDien
{
    class SinhVien:INguoi
    {
        private string hoTen;
        private string maSV;
        private int Tuoi;
        private int namSinh;

        public void nhap()
        {
            Console.WriteLine("Hay nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            namSinh = Convert.ToInt32(Console.ReadLine());
        }
        public void hienThi()
        {
            Console.WriteLine("Thong tin cua sinh vien la: "
                +hoTen+ ", ma SV: " +maSV+ ", tuoi: " + tuoi);

        }
        public int tuoi
        {
            get
            {
                return this.Tuoi = System.DateTime.Today.Year - namSinh;

            }
            set
            {
                this.Tuoi = value;
            }
        }
    }
}
