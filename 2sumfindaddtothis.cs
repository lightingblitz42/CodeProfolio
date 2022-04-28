using System;
namespace calc
{
    public class _sumfindaddtothis
    {
        public static void find()
        {
            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;
            bool firstOneDone = false;
            int hi = 0;
            int count1 = 0;
            for (int i = numbers.Length - 1; i > 0 - 1; i--)
            {



                if (firstOneDone == true)
                {

                    if (hi + numbers[i] == target)
                    {
                        int[] coolarr = new int[] { i + 1, count1 + 1 };
                        Console.WriteLine(numbers[i] + "yes");

                    }
                    else
                    {
                        Console.WriteLine(numbers[i] + "no");
                    }

                }
                else
                {
                    if (numbers[i] <= target)
                    {

                        hi = numbers[i];
                        count1 = i;
                        firstOneDone = true;
                        Console.WriteLine(hi);
                    }
                    else
                    {
                        Console.WriteLine(numbers[i] + ", " + target);
                    }

                }
            }
        }
    }
}
