using System;
using System.Collections.Generic;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer=new Customer();
            customer.Id=1;
            customer.Name="Srija";

            var order=new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
