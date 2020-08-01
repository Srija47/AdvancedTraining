using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num=int.Parse("abc");
                
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed");
            }
            
            int number;
            //using out modifier
            var result=int.TryParse("abc",out number);

                if(result)
                    System.Console.WriteLine(number);
                else
                    System.Console.WriteLine("Conversion failed");

            UseParams();
            UsePoints();
           
        }
        static void UseParams()
        {
            var cal=new Calculator();
            Console.WriteLine(cal.Add(1,2));
            Console.WriteLine(cal.Add(1,2,3));
            Console.WriteLine(cal.Add(1,2,3,4));
            Console.WriteLine(cal.Add(new int[]{1,2,3,4,5}));
        }
        static void UsePoints()
        {
            try
            {
                var point=new Point(10,20);
                point.Move(null);
                Console.WriteLine("Point is at ({0},{1})",point.X,point.Y);

                point.Move(200,300);
                Console.WriteLine("Point is at ({0},{1})",point.X,point.Y);    
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurs");
            }
        } 
    }
}
