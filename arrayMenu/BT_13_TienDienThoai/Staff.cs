using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_13_TienDienThoai
{
    class Staff
    {
        public string Ten { get; set; }
        public int SoPhutGoi { get; set; }
        public int LoaiKhachHang { get; set; }

        public void Input()
        {
            Console.WriteLine("input staff");

            Console.WriteLine("input name:");
            this.Ten = Console.ReadLine();


            string input = "";
            int tmpNumber;
            Console.WriteLine("input so phut goi:");
            input = Console.ReadLine();

            if (int.TryParse(input, out tmpNumber))
            {
                SoPhutGoi = tmpNumber;
            }

            Console.WriteLine("input loai khach hang:");
            input = Console.ReadLine();
            if (int.TryParse(input, out tmpNumber))
            {
                LoaiKhachHang = tmpNumber;
            }
        }


        public void Print()
        {
            Console.WriteLine("Staff info");

            Console.WriteLine("Ten : {0}, SoPhutGoi : {1} , sales : {2}", Ten, SoPhutGoi, LoaiKhachHang);

        }
    }
}
