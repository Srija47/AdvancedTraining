using System;

namespace Methods
{
    public class Calculator
    {
        //Example of using params modifier
        public int Add(params int[] numbers)
        {
            var sum=0;
            foreach(var number in numbers)
            {
                sum+=number;
            }
            return sum;
        }
    }
}