using System;
using System.Collections.Generic;

namespace Constructor
{
    public class Customer
    {
        public int Id;
        public string Name;        
        public List<Order>Orders;
        //default parameterless constructor
        public Customer()
        {
            //When class has list of objects ,it always gets initilaized that list to an empty list not the null obj
            Orders= new List<Order>();
        }
        //constructor
        //pass control using : this() keyword
        public Customer(int id):this()
        {
            this.Id=id;
        }

        //Constructor Overloading
        public Customer(int id,string name):this(id)
        {
            this.Id=id;
            this.Name=name;
        }
    }
}