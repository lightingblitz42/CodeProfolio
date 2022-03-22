using System;
namespace calc.ArrayWalking
{
    public class DoesHaveRepeatingValues
    {
        
        public static void main(string[] args)
        {
            int[] numbers = new int[9]
            {
            15,
            8,
            4,
            6,
            10,
            23,
            1,
            15,
            -9
            };

            bool result1 = containsRepeatsByForLoops(numbers);
            bool result2 = containsRepeatsByHashSet(numbers);

            
        }

        /**
         * Return true is you find any number more then once.
         * - Two Pointers (two for loops)
         * - Hash Set
         */
        public static bool containsRepeatsByForLoops(int[] numbers)
        {
            return false;
        }

        public static bool containsRepeatsByHashSet(int[] numbers)
        {
            return false;
        }
    }
}
