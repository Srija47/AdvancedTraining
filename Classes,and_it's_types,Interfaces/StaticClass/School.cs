using System;
using System.Collections.Generic;

namespace StaticClass
{
    public static class School
    {
        //static members/fields
        public static string SchoolName="XYZ";
        public static List<Student> slist;

        //static constructor
        public static School()
        {
            slist=new List<Student>();
        }
        //static methods
        public static void DisplayDetails()
        {
            Console.WriteLine(SchoolName);
            foreach(var i in slist)
            {
                Console.WriteLine(i);
            }
            
        }
        public static void AddStudent(Student student)
        {
            slist.Add(student);
        }
    }
}