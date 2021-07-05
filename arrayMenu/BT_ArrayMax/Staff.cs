using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_ArrayMax
{
    class Staff
    {
        private string _name;
        private int _age;
        private int _sales;
       // private int _salary;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public int Sales
        {
            get
            {
                return _sales;
            }
            set
            {
                _sales = value;
            }
        }

        //public int Salary
        //{
        //    get
        //    {
        //        return _salary;
        //    }
        //    set
        //    {
        //        _salary = value;
        //    }
        //}


        public void Input()
        {
            Console.WriteLine("input staff");

            Console.WriteLine("input name:" );
            _name = Console.ReadLine();


            string input = "";
            Console.WriteLine("input age:");
            input = Console.ReadLine();

            int.TryParse(input, out _age);

            Console.WriteLine("input sales:");
            input = Console.ReadLine();
            int.TryParse(input, out _sales);

            //Console.WriteLine("input salary:");
            //input = Console.ReadLine();
            //int.TryParse(input, out _salary);
        }


        public void Print()
        {
            Console.WriteLine("Staff info");

            Console.WriteLine("Ten : {0}, age : {1} , sales : {2}", _name, _age, _sales);

        }


    }
}
