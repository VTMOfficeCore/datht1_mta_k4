using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_13_TienDienThoai
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bt ");
            int soPhutGoi =  inputNumber("nhap so phut goi:");
            int tienCuoc = CaculateTienCuoc(soPhutGoi);
            System.Console.WriteLine("Tien cuoc : {0}", tienCuoc);

            Staff staff = null;
            int option = -1;
            while (option != 4)
            {
                DisplayMenu();
                option = inputNumber("");
                switch (option)
                {
                    case 1:
                        staff = new Staff();
                        staff.Input();
                        break;
                    case 2:
                        if (staff == null)
                        {
                            Console.WriteLine("Nhap thong tin khach hang truoc");

                        }
                        else
                        {
                            tienCuoc = CaculateTienCuoc(staff.SoPhutGoi);
                            Console.WriteLine("Tien cuoc : {0}", tienCuoc);
                        }
                        break;
                    case 3:
                        if (staff == null)
                        {
                            Console.WriteLine("Nhap thong tin khach hang truoc");

                        }
                        else
                        {
                            tienCuoc = CaculateTienCuoc(staff.SoPhutGoi);
                            //tinh tien sau khi bi tru
                            if (staff.LoaiKhachHang == 0)
                            {
                                if (staff.SoPhutGoi <= 50)
                                {
                                    tienCuoc = 0;
                                }
                                else
                                {
                                    tienCuoc = tienCuoc - 50 * 120;
                                }
                            }
                            Console.WriteLine("Tien ca thue : {0}", ((float)1.0 * tienCuoc + ((float)1.0 * tienCuoc / 10)));
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        break;
                }
            }

        }

        static int CaculateTienCuoc(int soPhutGoi)
        {
            int result = 27000;
            if (soPhutGoi <= 200)
            {
                result = result + soPhutGoi * 120;
            }
            else if (soPhutGoi <= 400)
            {
                result = result + 200 * 120 + (soPhutGoi - 200) * 80;
            }
            else
            {
                result = result + 200 * 120 + 200 * 80 + (soPhutGoi - 400) * 40;
            }
            return result;
        }

        static int inputNumber(string message = "")
        {
            string input = "";
            int result = -1;
            if (message != "")
            {
                Console.WriteLine(message);
            }
            input = Console.ReadLine();

            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("y/c nhap so");
            }
            return result;
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Nhap thong tin khac hang");
            Console.WriteLine("2. Tinh va in cuoc cua khach hang");
            Console.WriteLine("3. In so thue cua khach hang");
            Console.WriteLine("4. thoat");
        }
    }
}
