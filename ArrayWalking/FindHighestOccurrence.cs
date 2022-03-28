using System;
using System.Collections.Generic;
namespace calc.ArrayWalking
{
    public class FindHighestOccurrence
    {
        public static void main()
        {

            int[] numbers = new int[12]
            {
            15,
            28,
            34,
            15,
            10,
            10,
            31,
            15,
            -39,
            20,
            20,
            4
            };
           
            int result = ffindHighestOccurrence(numbers);
              Console.WriteLine("The most repeated number is:" + result);
           

        }

        public static int ffindHighestOccurrence(int[] numbers)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (values.ContainsKey(numbers[i]))
                {
                    Console.WriteLine(values[numbers[i]]);
                    values[numbers[i]] += 1;
                }
                else
                {
                    Console.WriteLine(0);
                    values.Add(numbers[i], 1);
                }
            }
            int temp = 0;
            foreach (var item in numbers)
            {
                if (values[item] >= temp)
                temp = item;
            }

            return temp;
        }
    }
}
