using System;
namespace calc.ArrayWalking
{
    public class DoesHaveRepeatingValues
    {
        
        public static void main(string[] args)
        {
            int[] numbers = new int[9]
            {
            -8,
            0,
            4,
            3,
           10,
           23,
           2,
          9,
            8
            };

            int result1 = containsRepeatsByRecursion(numbers, numbers.Length - 1, 0);
            bool result2 = containsRepeatsByHashSet(numbers);
           // bool result3 = containsRepeatsByForLoops(numbers);
            Console.WriteLine(result1);
            
        }

        /**
         * Return true is you find any number more then once.
         * - Two Pointers (two for loops)
         * - Hash Set
         */
        public static int containsRepeatsByRecursion(int[] numbers, int inputlength, int k)
        {
            if(k >= numbers.Length){
                
                return 0;
            }
            if (inputlength <= -1)
            {
                Console.WriteLine(inputlength);
                return containsRepeatsByRecursion(numbers, inputlength = numbers.Length - 1, k + 1);
            }
            if (k != inputlength)
            {
                
                Console.WriteLine(k + "f" + inputlength);
                if (numbers[inputlength] == numbers[k])
                {
                    Console.WriteLine(k + "t" + numbers.Length);
                    return numbers[k];
                }

            }
            else
            {
                return containsRepeatsByRecursion(numbers, inputlength - 1, k);
            }

            

            return containsRepeatsByRecursion(numbers, inputlength - 1, k);
          //  return  containsRepeatsByRecursion(numbers, inputlength--, k);

        }
        /*public static bool containsRepeatsByForLoops(int[] numbers)
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
        */

        public static bool containsRepeatsByHashSet(int[] numbers)
        {
            return false;
        }
    }
}
