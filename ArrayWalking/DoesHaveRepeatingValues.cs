using System;
using System.Collections.Generic;
namespace calc.ArrayWalking
{
    public class DoesHaveRepeatingValues
    {
        
        public static void main(string[] args)
        {
            int[] numbers = new int[9]
            {
            8,
            0,
            4,
            3,
           10,
           23,
           2,
          9,
            9
            };

            //int result1 = containsRepeatsByRecursion(numbers, numbers.Length - 1, 0);
            bool result2 = containsRepeatsByHashSet(numbers);
           // bool result3 = containsRepeatsByForLoops(numbers);
          //  Console.WriteLine(result1);
            /**
 * Return true is you find any number more then once.
 * - Two Pointers (two for loops)
 * - Hash Set
 */

        }
        public static int containsRepeatsByRecursion(int[] numbers, int inputlength, int k)
        {
            if(k >= numbers.Length){//this is the thing that closes it off
                return 0;
            }
            if (inputlength <= -1)//if the first thingy is -1
            {
                return containsRepeatsByRecursion(numbers, inputlength = numbers.Length - 1, k + 1);
            }
            if (k != inputlength)
            {    
                if (numbers[inputlength] == numbers[k])
                {
                    return numbers[k];
                }
            }
            return containsRepeatsByRecursion(numbers, inputlength - 1, k);
         

        }
        public static bool containsRepeatsByForLoops(int[] numbers)
        {
                        for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (i == j)
                    {
                        //nothing happen
                    }
                    else
                    {
                        if (numbers[i] == numbers[j])
                        {
                           
                            return true;
                        }
                    }
                }
            }
            return false;
            
        }

        public static bool containsRepeatsByHashSet(int[] numbers)
        {
            foreach (var items in numbers)
            {
                Console.Write(items + ", ");
            }
            Console.WriteLine("");
            HashSet<int> numbs = new HashSet<int>(numbers);
            foreach (var item in numbs)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("");

            if (numbers.Length != numbs.Count)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }
    }
}
