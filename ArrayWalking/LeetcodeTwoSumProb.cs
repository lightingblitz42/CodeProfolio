using System;
namespace calc.ArrayWalking
{
    public class LeetcodeTwoSumProb
    {
        public static void TwoSumProb()
        {
            int[] numbers = new int[7]
            {
                3,
                5,
                1,
                2,
                7,
                8,
                2
            };

            Codestuff(numbers);
            

        }
        public static void Codestuff(int[] numbers)
        {
            
            int whatwewanttofind = 10;
            
            int counter = 0;
            
            while (counter <= numbers.Length - 2)
            {
                if (numbers[counter] + numbers[counter + 1] == whatwewanttofind)
                {
                    Console.WriteLine(numbers[counter] + " + " + numbers[counter + 1] + " = " + whatwewanttofind);
                }


                counter++;
            }

        }
    }
}
