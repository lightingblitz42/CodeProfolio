using System;
namespace calc
{
    public class IfPowerOfTwo
    {
       
        
        public static void ifPowerOfTwo()
        {
            int n = 28;
            
            Console.WriteLine(Code(n));


    }
        public static bool Code(int nl)
        {
            int d = 9;
            if (nl == 0)
            {
                return false;
            }
            if(nl % 2 == 1)
            {
                return false;
            }
            if (nl != 2)
            {
               // Console.WriteLine(Code(nl / 2));
                if (nl % 2 != 0)
                {
                    return false;
                }
                Console.WriteLine(nl);

                return Code(nl / 2);

            }
            else
            {
                return true;
            }

          
        }
       
    }
}
