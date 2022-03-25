using System;
namespace calc
{
    public class Factorials
    {
        public static void factorials()
        {
           float result = factorial(100);
            Console.WriteLine(result);
        }

        public static float factorial(float number)
        {
            //EXITCONDITION
            if (number == 1)
            {
                return number;
            }

            return number * factorial(number - 1);
          
        }
    }
}
