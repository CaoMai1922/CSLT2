using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Buoi6_chuong3_part3.HinhHoc;
using Buoi6_chuong3_part3.DemoGiaoDien;
using Buoi6_chuong3_part3.QuanLySinhVien;
using Buoi6_chuong3_part3.QuanLyXe;
namespace Buoi6_chuong3_part3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Đây là vd của lớp abstract
             *Một đối tượng có thể nhìn bên ngoài như đối tượng cha,
            nhưng thực sự nó được thể hiện bên trong là lớp con */

            //HinhChuNhat hcn1 = new HinhChuNhat();
            /*Trước khi thay ten thì tên folder cũ la HinhHoc */
            //HinhHoc.HinhHoc hcn2 = new HinhChuNhat();
            //hcn1.nhap();
            //Console.WriteLine("Dien tich hinh chu nhat la: " + hcn1.dienTich());
            //Console.WriteLine("Toi nhap du lieu cho doi tuong co kieu hinh hoc");
            //hcn2.nhap();
            //hcn2.dienTich();


            //INguoi sv1 = new SinhVien();

            /*
             * Khai báo đối tượng thông qua interface phải chỉ rõ lớp thực thi là lớp nào
             * INguoi sv1 = new SinhVien(); ==> sai
             */

            //sv1.nhap();
            //sv1.hienThi();
            //Console.ReadLine();


            //Demo try...catch
            /* int a, b;
            try
            {
                Console.WriteLine("Nhap a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Thuong cua a/b la: {}", a / b);
            }
            catch ( Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
            */

            DanhSachSinhVien HTTTA = new DanhSachSinhVien();
            HTTTA.Nhap();
            Console.Write("So luong sv duoc lam khoa luan la: " + HTTTA.soLuongSVKhoaLuan());
            Console.Write("\nSo luong sv duoc lam chuyen de la: " + HTTTA.soLuongSVChuyenDe());
            Console.ReadLine();


            //QuanLy to1 = new QuanLy();
            //to1.nhap();
            //to1.hien();
            //Console.ReadKey();



        }
    }
}
