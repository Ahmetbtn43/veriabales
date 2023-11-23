using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string ahmet = "my name is ahmet emin butun";
            var result = ahmet.Length;
            var result1 = ahmet.Clone();
            ahmet = "my name is ahmet emin";
            bool result2 = ahmet.EndsWith("ğ");
            bool result3 = ahmet.StartsWith("m");
            var result4 = ahmet.IndexOf("name");
            var result5 = ahmet.IndexOf("y");
            var result6 = ahmet.LastIndexOf(" ");
            var result7 = ahmet.Insert(21, "21");
            var result8 = ahmet.Substring(3);
            var result9 = ahmet.ToLower();
            var result10 = ahmet.ToUpper();
            var result11 = ahmet.Replace(" ","-");
            var result12 = ahmet.Remove(2);
           
            Console.WriteLine(result12);



          
            //string city = "ankara";
            // Console.WriteLine(city[1]);
            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}
            //string city2 = "istanbul";
            //Console.WriteLine("{0} {1}",city,city2);
            Console.ReadLine();
        }
    }
    
}
