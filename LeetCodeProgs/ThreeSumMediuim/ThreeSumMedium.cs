using System;
namespace calc.LeetCodeProgs
{
    public class ThreeSumMedium
    {
        public static int[] numbers = new int[] {1, -1, 0, 3, 800, 10, 2, 100};
        public static int sum;
        public static void threeSumMedium()
        {
            Code();
        }
        public static void Code()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        int othersum = numbers[i] + numbers[j] + numbers[k];
                        if (othersum == sum)
                        {
                            if (i != j || i != k || j != k )
                            {
                                Console.WriteLine(numbers[i] + " " + numbers[j] + " " + numbers[k] + " = " + sum);
                                Console.WriteLine(i + " " + j + " " + k);
                            }
                           
                        }
                        else
                        {
                           // Console.WriteLine(numbers[i] + " " + numbers[j] + " " + numbers[k]);
                        }
                    }
                }
            }
        }
    }
}
