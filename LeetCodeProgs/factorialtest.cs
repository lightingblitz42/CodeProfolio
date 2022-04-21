using System;
namespace calc.LeetCodeProgs
{
    public class factorialtest
    {
        
        public static void Factorialtest(int factorialThis, int i)
        {
            i -= 1;
           if(i == 1)
            {
                Console.WriteLine(factorialThis);
                return;
            }
            else
            {
                Factorialtest(factorialThis * i , i);
            }

        }
    }
}
