using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strDizi = sevgi();
            int son = strDizi.Length + 1;
            for (int i = son; i <= 0; i++)
            {
                Console.WriteLine(strDizi[i]);
            }
            Console.ReadLine();
        }

        private static string[] sevgi()
        {
           return sevgi();
        }
    }
}
