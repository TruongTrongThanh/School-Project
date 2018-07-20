using System;
using System.Collections.Generic;

namespace VienKhoaHoc
{
    class Program
    {
        static int choice;
        static List<Person> list = new List<Person>();

        static void Main(string[] args)
        {
        Phase1:
            Console.WriteLine("CHUONG TRINH QUAN LY NHAN SU VIEN KHOA HOC");
            Console.WriteLine("1. Nhap thong tin nhan su");
            Console.WriteLine("2. In danh sach nhan vien");
            Console.WriteLine("3. Tong luong da chi tra cho nhan su");
            Console.WriteLine("4. Auto generate");
            Console.WriteLine("0. Thoat\n");

            Console.Write("Choice: ");
            int firstChoice = Int32.Parse(Console.ReadLine());
            Console.Clear();
        Phase2v1:
            switch (firstChoice)
            {
                case 1:
                    Console.WriteLine("1. Nhap nha khoa hoc");
                    Console.WriteLine("2. Nhap nha quan ly");
                    Console.WriteLine("3. Nhap nhan vien phong thi nghiem");
                    Console.WriteLine("4. Quay ve menu chinh\n");

                    Console.Write("Choice: ");
                    int secondChoice = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (secondChoice)
                    {
                        case 1:
                            NhaKhoaHoc nkh = new NhaKhoaHoc();
                            nkh.Input();
                            list.Add(nkh);
                            break;
                        case 2:
                            NhaQuanLy nql = new NhaQuanLy();
                            nql.Input();
                            list.Add(nql);
                            break;
                        case 3:
                            NhanVien nv = new NhanVien();
                            nv.Input();
                            list.Add(nv);
                            break;
                        case 4:
                            goto Phase1;
                    }
                    Console.Clear();
                    Console.WriteLine("Nhap thanh cong!\n");
                    Console.WriteLine("1. Ve menu chinh.");
                    Console.WriteLine("2. Tiep tuc nhap.");
                    Console.WriteLine("0. Thoat.\n");

                    Console.Write("Choice: ");
                    choice = Int32.Parse(Console.ReadLine());

                    Console.Clear();
                    if (choice == 1)
                        goto Phase1;
                    else if (choice == 2)
                        goto Phase2v1;
                    else
                        break;
                case 2:
                    Console.WriteLine("Danh sach nhan su trong vien khoa hoc:\n");
                    foreach (var person in list)
                    {
                        person.Output();
                        Console.WriteLine();
                    }
                    Pause();

                    Console.Clear();
                    goto Phase1;
                case 3:
                    double luongNKH = 0, luongNQL = 0, luongNV = 0;
                    foreach (var person in list)
                    {
                        if (person.GetType() == typeof(NhaKhoaHoc))
                            luongNKH += person.Luong();
                        if (person.GetType() == typeof(NhaQuanLy))
                            luongNQL += person.Luong();
                        if (person.GetType() == typeof(NhanVien))
                            luongNV += person.Luong();
                    }
                    Console.WriteLine("Tong tien luong da chi tra:");
                    Console.WriteLine("\tNha khoa hoc: " + luongNKH);
                    Console.WriteLine("\tNha quan ly: " + luongNQL);
                    Console.WriteLine("\tNhan vien: " + luongNV);
                    Pause();

                    Console.Clear();
                    goto Phase1;
                case 4:
                    AutoGenerate();
                    Console.Clear();
                    goto Phase1;
                default:
                    break;
            }

            Console.WriteLine("See you again!\n");
        }

        /// <summary>
        /// Hàm này không cần chép.
        /// </summary>
        static void AutoGenerate()
        {
            list.Add(new NhaKhoaHoc("Truong Trong Thanh", "21/11/1998", "Bang gia", "Thu tuong", 15, 25, 2.5));
            list.Add(new NhaKhoaHoc("Truong Trong Quy", "21/11/1998", "Bang gia", "Thu tuong", 15, 25, 2.5));
            list.Add(new NhaQuanLy("Ho Hao Hon", "21/11/1998", "Bang gia", "Thu tuong", 25, 2.5));
            list.Add(new NhanVien("Lionel Messi", "21/11/1998", "Bang gia", 2500000));
        }

        /// <summary>
        /// Hàm này cần chép.
        /// </summary>
        static void Pause()
        {
            Console.Write("\nPress any keys to continue...");
            Console.ReadKey();
        }
    }
}
