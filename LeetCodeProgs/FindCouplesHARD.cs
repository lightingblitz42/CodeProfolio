using System;
using System.Collections.Generic;
namespace calc.LeetCodeProgs
{
    public class FindCouplesHARD
    {
        public static int[] row = new int[] {3 ,1,0,2};
        public static void findCouplesHARD()
        {
           

            int countswiches = 0;
            for (int i = 0; i < row.Length; i += 2)//person1 is always even
            {
                int person1 = 0;
                int person2 = 0;
                if (row[i] % 2 == 0)
                {
                    person1 = row[i];
                    person2 = row[i] + 1;
   

                }
                else
                {
                    person1 = row[i];
                    person2 = row[i] - 1;
                }
                int pos = 0;
                for (int j = 0; j < row.Length; j++)
                {
                    pos = j;
                    if(row[pos] == person2)
                    {
                        break;
                    }
                }
              if(pos != i+1 && pos != i - 1)
                {
                    countswiches++;
                    
                    if (row[i + 1] > row[pos])
                    {
                        int dif = row[i + 1] - row[pos];
                        row[pos] += dif;
                        row[i + 1] -= dif;
                    }
                    else
                    {
                        int dif = row[pos] - row[i + 1];
                        row[pos] -= dif;
                        row[i + 1] += dif;
                    }
                }
            }
            Console.WriteLine(countswiches);
            


        }
    }
}
