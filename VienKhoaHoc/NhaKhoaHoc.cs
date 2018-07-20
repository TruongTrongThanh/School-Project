using System;

namespace VienKhoaHoc
{
    class NhaKhoaHoc : Person
    {
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }

        public int SoBaiBao { get; set; }

        /// <summary>
        /// hàm này ko cần chép.
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="namSinh"></param>
        /// <param name="bangCap"></param>
        /// <param name="chucVu"></param>
        /// <param name="soBaiBao"></param>
        /// <param name="soNgayCong"></param>
        /// <param name="bacLuong"></param>
        public NhaKhoaHoc(string hoTen, string namSinh, string bangCap, string chucVu, int soBaiBao, int soNgayCong, double bacLuong)
        {
            HoTen = hoTen;
            NamSinh = DateTime.Parse(namSinh);
            BangCap = bangCap;
            ChucVu = chucVu;
            SoBaiBao = soBaiBao;
            SoNgayCong = soNgayCong;
            BacLuong = bacLuong;
        }

        public NhaKhoaHoc(){}

        public override void Input()
        {
            Console.WriteLine("* Nha khoa hoc *");
            base.Input();
            Console.Write("Chuc vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("So bai bao cong bo: ");
            SoBaiBao = Int32.Parse(Console.ReadLine());
            Console.Write("So ngay cong trong thang: ");
            SoNgayCong = Int32.Parse(Console.ReadLine());
            Console.Write("Bac luong: ");
            BacLuong = Double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine("* Nha khoa hoc *");
            base.Output();
            Console.WriteLine("Chuc vu: {0}", ChucVu);
            Console.WriteLine("So bai bao cong bo: {0}", SoBaiBao);
            Console.WriteLine("So ngay cong trong thang: {0}", SoNgayCong);
            Console.WriteLine("Bac luong: {0}", BacLuong);
        }

        public override double Luong()
        {
            return SoNgayCong * BacLuong;
        }
    }
}
