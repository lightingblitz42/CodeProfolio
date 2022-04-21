using System;
namespace calc
{
    public class IfPowerOfThree
    {
        

        public static void ifPowerOfThree()
        {
            int n = 43046721;
            Console.WriteLine(n);
            Console.WriteLine(threeCode(n));


        }
        public static bool threeCode(int nl)
        {
            if (nl == 0)
            {
                return false;
            }
            if (nl == 3)
            {
                return true;
            }
            if(nl%2 == 0)
            {
                return false;
            }
            while (nl != 3)
            {
                Console.WriteLine(threeCode(nl/3));
                return threeCode(nl/3);
            }
            Console.WriteLine(nl);
            return false;
        }
    }
}