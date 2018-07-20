using System;

namespace VienKhoaHoc
{
    class NhaQuanLy : Person
    {
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }

        public NhaQuanLy() { }

        public NhaQuanLy(string hoTen, string namSinh, string bangCap, string chucVu, int soNgayCong, double bacLuong)
        {
            HoTen = hoTen;
            NamSinh = DateTime.Parse(namSinh);
            BangCap = bangCap;
            ChucVu = chucVu;
            SoNgayCong = soNgayCong;
            BacLuong = bacLuong;
        }

        public override void Input()
        {
            Console.WriteLine("* Nha quan ly *");
            base.Input();
            Console.Write("Chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("So ngay cong trong thang: ");
            SoNgayCong = Int32.Parse(Console.ReadLine());
            Console.Write("Bac luong: ");
            BacLuong = Double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine("* Nha quan ly *");
            base.Output();
            Console.WriteLine("Chuc vu: {0}", ChucVu);
            Console.WriteLine("So ngay cong trong thang: {0}", SoNgayCong);
            Console.WriteLine("Bac luong: {0}", BacLuong);
        }

        public override double Luong()
        {
            return SoNgayCong * BacLuong;
        }
    }
}
