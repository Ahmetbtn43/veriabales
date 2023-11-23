using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.update();
            ProducManager producManager = new ProducManager();
            producManager.Add();
            producManager.update();
            Customer customer = new Customer
            {
                Id = 2,city="istanbul",firstname="derin",lastname = "demiroğ"
            };
            Console.WriteLine(customer.firstname);

           Console.ReadLine();
        }

    }
   
}
