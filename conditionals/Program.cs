using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        
        {
            var number = 20;
            //if (number == 10)
            //{
            //    Console.WriteLine("number is 10");
            //}
            //else
            //{
            //    Console.WriteLine("number is not 10");
            //}
            switch (number)
            {
                case 10:
                    Console.WriteLine("seni seviyorum");
                    break;
                case 20:
                    Console.WriteLine("okey donuyoz");
                    break;
                default:
                    Console.WriteLine("kaybettiniz");
                    break;
                   
                    
            }
            Console.ReadLine();

        }
    }
}
