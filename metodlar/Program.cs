using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            //int result = Add2(500);
            //Console.WriteLine(result);
            Console.WriteLine(Multiplay(1, 5, 3));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7));
            Console.ReadLine();

        }
        static void Add()
        {
            Console.WriteLine("ADD!!");
        }
        static int Add2(int number1, int number2 = 30)
        {
            int result = number1 + number2;
            return result;
        }
        static int Add3(int number1, int number2)
        {
            return  number1 + number2;
        }
        static int Multiplay (int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
