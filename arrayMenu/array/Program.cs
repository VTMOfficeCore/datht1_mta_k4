using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static int N;
        static int[] intArray = new int[N];
        static void Main(string[] args)
        {
            showMenu();
        }
        public static void showMenu()
        {
            int chose;
            do
            {

                Console.WriteLine("*******************MAIN MENU*************");
                Console.WriteLine("*******LUA CHON CAC THAO TAC VOI MANG INTARRAY********");
                Console.WriteLine("1.   NHAP THONG TIN MANG");
                Console.WriteLine("2.   IN DU LIEU CUA MANG");
                Console.WriteLine("3.   GIA TRI TRUNG BINH CUA ");
                Console.WriteLine("4.   GIA TRI LON NHAT CUA MANG");
                Console.WriteLine("5.   DEM SO LUONG CAC PHAN TU CUA MANG CO GIA TRI 5");
                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");

                chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        validArray();
                        writeArr();
                        break;

                    case 2:
                        validArray();
                        printArr();
                        break;

                    case 3:
                        validArray();
                        calAvgArr();
                        break;
                    case 4:
                        validArray();
                        findMaxVal();
                        break;
                    case 5:
                        validArray();
                        countVal5();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("vui long nhap lai");
                        break;
                }

            } while (chose < 6);
            Console.ReadLine();
        }
        public static void validArray()
        {
            if (intArray == null || intArray.Length == 0)
            {
                Console.WriteLine("Ban phai nhap du lieu cho mang da");
                writeArr();
            }
        }

        public static void writeArr()
        {
            Console.WriteLine("Nhap kich thuoc mang:");
            N = Convert.ToInt32(Console.ReadLine());
            intArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Nhap gia tri phan tu thu {0} cho mang", i + 1);
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void printArr()
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Gia tri phan tu thu {0} là: {1}", i + 1, intArray[i]);
            }
        }

        public static void calAvgArr()
        {
            int sumArr = 0;
            float avgArr = 0;
            for (int i = 1; i < N; i++)
            {
                sumArr = sumArr + intArray[i];
            }
            avgArr = sumArr / N;
            Console.WriteLine("Gia tri trung binh cua mang la: {0} ", avgArr);
        }

        public static void findMaxVal()
        {
            int maxValue = intArray[0];
            for (int i = 1; i < N; i++)
            {
                if (intArray[i] > maxValue)
                {
                    maxValue = intArray[i];
                }
            }
            Console.WriteLine("Gia tri lon nhat cua mang la: {0} ", maxValue);
        }

        public static void countVal5()
        {
            int count = 0;
            for (int i = 1; i < N; i++)
            {
                if (intArray[i] == 5)
                {
                    count++;
                }
            }
            Console.WriteLine("So phan tu co gi tri 5 la: {0} ", count);
        }
    }
}
