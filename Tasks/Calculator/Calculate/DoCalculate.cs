using System;

namespace Calculate
{
    public class DoCalculate
    {
        public double DoOperation(double input_1, double input_2,string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "+":
                    result = input_1 + input_2;
                    break;
                case "-":
                    result = input_1 - input_2;
                    break;
                case "*":
                    result = input_1 * input_2;
                    break;
                case "/":
                    result = input_1 / input_2;
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
}