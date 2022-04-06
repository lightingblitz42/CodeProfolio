using System;
namespace calc.LeetCodeProgs
{
    public class ALLSum
    {
        public static void allSum()
        {
            int[] Numbers = new int[] {1,5,3,2,10,4,12,53,0,1,3,6,8};
            int Sum = 77;
            Code(Numbers,Sum);
        }
        public static void Code(int[] Numbers, int Sum)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                int count = 0;
                for (int j = i; j < Numbers.Length; j++)
                {
                    count += j;
                    Console.Write(count + ", ");
                    if (count == Sum)
                    {
                        Console.WriteLine(" = " + Sum);
                    }
                }
                Console.WriteLine("");
            
            }
        }
    }
}
