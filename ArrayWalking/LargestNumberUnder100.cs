using System;
namespace calc.ArrayWalking
{
    public class LargestNumberUnder100
    {
        public static void main(string[] args)
        {
            
            int[] numbers = new int[11]
            {
            15,
            28,
            34,
            46,
            10,
            23,
            31,
            15,
            -39,
            40,
            20
            };

            int result = findLargestNumberUnder100(numbers);
            Console.WriteLine(result);


        }

        /**
         * Add up numbers that are next to each other, but don't cross 100.
         * So you answer is the highest number (sum of numbers next to each other)
         */
        public static int findLargestNumberUnder100(int[] numbers)
        {
            int counting = 0;
            int resultingNumber = 0;
            while (resultingNumber <= 90)
            {


                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    resultingNumber += numbers[i] + numbers[i + 1];
                    counting++;
                    while (resultingNumber >= 100)
                    {
                        if (counting > numbers.Length - 3)
                        {
                            counting -= 2;
                        }
                        if (numbers[counting] <= 0)
                        {
                            resultingNumber += numbers[counting];
                        }
                        else
                        {
                            resultingNumber -= numbers[counting];

                        }

                       
                        counting += 1;
                        Console.WriteLine(counting + ", " + resultingNumber);
                        

                    }
                    Console.WriteLine("Looping again!");
                }
            }

            return resultingNumber;//return the ending number
        }
    }
}
