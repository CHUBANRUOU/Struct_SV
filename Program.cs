using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_sv
{
    class Program
    {
        struct SinhVien
        {
            public int MaSo201;
            public string HoTen201;
            public double DiemToan201;
            public double DiemLy201;
            public double DiemVan201;
        }
        enum enumSV
        {
            MaSo201,
            HoTen201,
            DiemToan201,
            DiemLy201,
            DiemVan201
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma so: ");
            SV.MaSo201 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen201 = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan201 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy201 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan201 = Double.Parse(Console.ReadLine());
        }
        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan201 + SV.DiemLy201 + SV.DiemVan201) / 3;
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSo201);
            Console.WriteLine(" Ho ten: " + SV.HoTen201);
            Console.WriteLine(" Diem toan: " + SV.DiemToan201);
            Console.WriteLine(" Diem ly: " + SV.DiemLy201);
            Console.WriteLine(" Diem van: " + SV.DiemVan201);
        }

        static void Main(string[] args)
        {
            SinhVien SV;
            SinhVien[] arrSV;
            int n;

            Console.WriteLine("nhap so sinh vien can them");
            n = Console.Read();

            for (int i= 0; i < n; i++)
            {
                Console.WriteLine(" Nhap thong tin sinh vien: ");
                NhapThongTinSinhVien(out SV);
                arrSV[i] = SV;
            }

            //in danh sach sinh vien
            foreach(SinhVien sinhvien in arrSV)
            {
                XuatThongTinSinhVien(sinhvien);
                Console.WriteLine("");

            }
            //tim kiem sinh vien
            Console.WriteLine("Nhap ten sinh vien can tim kiem");
            String name = Console.ReadLine();
            foreach(SinhVien sinhvien in arrSV)
            {
                if (sinhvien.HoTen201.CompareTo(name) == 0)
                {
                    Console.WriteLine("Sinh vien co diem trung binh la: " + DiemTBSinhVien(sinhvien));
                }
                else
                    Console.WriteLine("Khong ton tai sinh vien da tim");
                
            }



            Console.ReadKey();
        }
    }
}
