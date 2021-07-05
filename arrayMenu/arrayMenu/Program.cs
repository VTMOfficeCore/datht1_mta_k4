using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayMenu
{
    class Program
    {
        private static int intLength;
        private static int[] array;
        static void Main(string[] args)
        {
            Console.WriteLine("Input menu type:");
            Console.WriteLine("1: Nhập thông tin về mảng");
            Console.WriteLine("2: Sắp xếp mảng");
            Console.WriteLine("3: Hiện thông tin về mảng");
            Console.WriteLine("4: In ra phần tử có giá trị lớn nhất/nhỏ nhất");
            Console.WriteLine("5: Tính tổng và trung bình cộng của các phần tử có chỉ số chẵn trong mảng");
            Console.WriteLine("6: In ra số lượng của các phần tử trong mảng có giá trị lớn nhất ");
            Console.WriteLine("7: Kết thúc");
            int menuType = Convert.ToInt32(Console.ReadLine());
            while (menuType != 7)
            {
                switch (menuType)
                {
                    case 1:
                        InputArrayValue();
                        break;
                    case 2:
                        ValidArray();
                        int[] arrayTo = new int[intLength];
                        for (int i = 0; i < intLength; i++)
                        {
                            arrayTo[i] = array[i];
                        }
                        for (int i = 0; i < intLength; i++)
                        {
                            for (int j = i + 1; j < intLength; j++)
                            {
                                if (arrayTo[i] < arrayTo[j])
                                {
                                    int temp = arrayTo[i];
                                    arrayTo[i] = arrayTo[j];
                                    arrayTo[j] = temp;
                                }
                            }
                        }

                        for (int i = 0; i < intLength; i++)
                        {
                            Console.Write(arrayTo[i] + " ");
                        }
                        Console.WriteLine("");
                        break;
                    case 3:
                        ValidArray();
                        Console.WriteLine("Array Origin");
                        for (int i = 0; i < intLength; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        Console.WriteLine("");
                        break;
                    case 4:
                        ValidArray();
                        int maxValue = array[0];
                        int minvalue = array[0];
                        for (int i = 0; i < intLength; i++)
                        {
                            if (array[i] > maxValue)
                            {
                                maxValue = array[i];
                            }
                            if (array[i] < minvalue)
                            {
                                minvalue = array[i];
                            }
                        }
                        Console.WriteLine("Max value:" + maxValue);
                        Console.WriteLine("Min value:" + minvalue);
                        break;
                    case 5:
                        ValidArray();
                        int total = 0;
                        int countItem = 0;                        
                        for (int i = 0; i < intLength; i++)
                        {
                            if(i % 2 == 0)
                            {
                                total = total + array[i];
                                countItem += 1;
                            }
                        }
                        Console.WriteLine("Total even:" + total);
                        Console.WriteLine("Average even:" + total/ countItem);
                        break;
                    case 6:
                        ValidArray();
                        int maxValue1 = array[0];                        
                        for (int i = 0; i < intLength; i++)
                        {
                            if (array[i] > maxValue1)
                            {
                                maxValue1 = array[i];
                            }                            
                        }
                        int countMaxvalue = 0;
                        for (int i=0; i< intLength; i++)
                        {
                            if(array[i]== maxValue1)
                            {
                                countMaxvalue += 1;
                            }
                        }
                        Console.WriteLine("Count max value:" + countMaxvalue);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Input menu type:");
                menuType = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void InputArrayValue()
        {
            Console.WriteLine("Input value Lenght array:");
            intLength = Convert.ToInt32(Console.ReadLine());
            array = new int[intLength];
            Console.WriteLine("Start input value to array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Value item :" + i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void ValidArray()
        {
            if (array == null || array.Length == 0)
            {
                InputArrayValue();
            }
        }
    }
}
