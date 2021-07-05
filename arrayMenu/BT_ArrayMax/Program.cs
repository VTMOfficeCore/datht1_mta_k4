using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome BT C# array max");
            int sales = -1;
            string input = "";

            Console.WriteLine("Nhap doanh so :");
            input = Console.ReadLine();

            if (int.TryParse(input, out sales))
            {
                InThuong(sales);
            }
            else
            {
                Console.WriteLine("Nhap doanh so sai");
            }


            Console.WriteLine("Phan nang cao");

            Console.WriteLine("Nhap do dai mang :");
            input = Console.ReadLine();
            int totalArray = 0;

            if (int.TryParse(input, out totalArray))
            {
                Staff[] arrayStaff = new Staff[totalArray];
                Staff staff;
                for (int i = 0; i < totalArray; i++)
                {
                    staff = new Staff();
                    staff.Input();
                    arrayStaff[i] = staff;
                    InThuong(staff.Sales);
                }

                Console.WriteLine("Hay in ra nhan vien co sales cao nhat.");
                List<Staff> listMaxSales = new List<Staff>();
                int maxSales = 0;
                for (int i = 0; i < totalArray; i++)
                {
                    if (arrayStaff[i].Sales > maxSales)
                    {
                        maxSales = arrayStaff[i].Sales;
                    }
                }

                for (int i = 0; i < totalArray; i++)
                {
                    if (arrayStaff[i].Sales == maxSales)
                    {
                        arrayStaff[i].Print();
                    }
                }

                Console.WriteLine("Hay in ra tong so nhan vien co sales  > 2000");
                for (int i = 0; i < totalArray; i++)
                {
                    if (arrayStaff[i].Sales > 2000)
                    {
                        arrayStaff[i].Print();
                    }
                }
            }
            

            Console.WriteLine("Ket thuc, nhan phim bat key de ket thuc");
            Console.ReadLine();
        }

        private static void InThuong(int sales)
        {
            sales = sales / 1000;
            if (0 <= sales && sales <= 3)
            {
                System.Console.WriteLine(" Rat kem (-1 %)");
            }
            else if (sales == 4)
            {
                System.Console.WriteLine(" Kem (0.5%)");
            }
            else if (sales == 5)
            {
                System.Console.WriteLine(" Co co gang (0.5%");
            }
            else if (sales == 6)
            {
                System.Console.WriteLine("Tot (2%)");
            }
            else if (sales == 7)
            {
                System.Console.WriteLine(" Rat tot (3.5%)");
            }
            else if (sales >= 8 && sales <= 10)
            {
                System.Console.WriteLine(" Tuyet voi (5%)");
            }
            else
            {
                System.Console.WriteLine(" Nhap sai");
            }
        }

    }
}
