using System;

namespace VienKhoaHoc
{
    class NhanVien : Person
    {
        public double LuongTrongThang { get; set; }

        public NhanVien() { }

        /// <summary>
        /// Hàm này ko cần chép.
        /// </summary>
        /// <param name="hoTen"></param>
        /// <param name="namSinh"></param>
        /// <param name="bangCap"></param>
        /// <param name="luongTrongThang"></param>
        public NhanVien(string hoTen, string namSinh, string bangCap, int luongTrongThang)
        {
            HoTen = hoTen;
            NamSinh = DateTime.Parse(namSinh);
            BangCap = bangCap;
            LuongTrongThang = luongTrongThang;
        }

        public override void Input()
        {
            Console.WriteLine("* Nhan vien phong thi nghiem *");
            base.Input();
            Console.Write("Luong trong thang: ");
            LuongTrongThang = Int32.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            Console.WriteLine("* Nhan vien phong thi nghiem *");
            base.Output();
            Console.WriteLine("Luong trong thang: {0}", LuongTrongThang);
        }

        public override double Luong()
        {
            return LuongTrongThang;
        }
    }
}
