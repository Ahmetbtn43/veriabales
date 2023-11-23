using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IPerson
    {
         int Id { get; set; }
        int Firstname { get; set; }
        int Lastname { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public int Firstname { get; set; }
        public int Lastname { get; set; }
        public String Departmant { get; set; }
    }
    class Student:IPerson
    {

        public int Id { get; set; }
        public int Firstname { get; set; }
        public int Lastname { get; set; }
    }
}
