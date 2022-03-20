using System;
using System.Linq;

using System.Security.Cryptography;
namespace calc
{
    public class Bogosort
    {
        public static void bogoSort()
        {
            
            int[] numbers = new int[9]{
                1,
                9,
                7,
                12,
                34,
                56,
                43,
                23,
                54
                


                
                
            };
            bool passes = false;
            while (passes == false)
            {
                int[] sortedNumbers = mixUp(numbers);
                foreach (var item in sortedNumbers)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("");
                passes = true;
                for (int i = 0; i < sortedNumbers.Length - 1; i++)
                {
                    if (sortedNumbers[i] >= sortedNumbers[i + 1])
                    {
                        passes = false;
                        break;
                    }
                }
            }
            return;

        }

        public static int[] mixUp(int[] numbers)
        {
            Random random = new Random();
            numbers = numbers.OrderBy(x => random.Next()).ToArray();
            
            return numbers;
        }
    }

    
}
