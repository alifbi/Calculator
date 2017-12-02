using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Num 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Num 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            int sub = a - b;
            int mul = a * b;

            //calcuataro

            Console.WriteLine("Sum Is :" + sum);
            Console.WriteLine("sub Is :" + sub);
            Console.WriteLine("mul Is :" + mul);

            Console.ReadLine();
        }
    }
}
