using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var student=new Student();
            student.studentId=1;
            student.studentName="srija";
            
            AddStudent(student);
            Console.WriteLine(DisplayDetails());
        }
    }
}
