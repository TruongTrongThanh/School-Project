using System;

namespace VienKhoaHoc
{
    abstract class Person
    {
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string BangCap { get; set; }

        public virtual void Input()
        {
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nam sinh: ");
            NamSinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Bang cap: ");
            BangCap = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("Nam sinh: {0}", NamSinh.ToString("MMMM dd, yyyy"));
            Console.WriteLine("Bang cap: {0}", BangCap);
        }

        public abstract double Luong();
    }
}
