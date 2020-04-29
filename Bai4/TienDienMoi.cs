using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4
{
    class TienDienMoi:TienDien
    {
        private int dinhMuc;

        public TienDienMoi(string tenChuHo, string diaChi, int soCongToThangTruoc, int soCongToThangNay,int dinhMuc)
            :base(tenChuHo,diaChi,soCongToThangTruoc,soCongToThangNay)

        {
            this.dinhMuc = dinhMuc;
        }
        public override void nhap()
        {
            base.nhap();
            
            Console.Write("Nhap dinh muc: ");
            dinhMuc = Convert.ToInt32(Console.ReadLine());
        }
        public override void hien()
        {
            Console.WriteLine("Ten chu ho: {0}, dia chi: {1}, so cong to thang truoc la: {2}" +
                ", so cong to thang nay la: {3}, dinh muc: {4}"
                , tenChuHo, diaChi, soCongToThangTruoc, soCongToThangNay, dinhMuc);
        }

        public int tinhTienDien()
        {
            soCongToDaDung = soCongToThangNay - soCongToThangTruoc;
            if(soCongToDaDung<=dinhMuc)
            {
                return soCongToDaDung * 500;
            }
            else
            {
                return (dinhMuc * 500 + (soCongToDaDung - dinhMuc) * 600);
            }
        }
    }
}
