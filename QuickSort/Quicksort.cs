using System;

namespace calc
{

    public static class Quicksort
    {
        
        public static int[] numbers = new int[]
            {
                24,
                39,
                93,
                3,
                7,
                2,
                1
            };
        static int pivot = numbers[numbers.Length - 1];
        public static void othr()
        {
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + ",");
            }
            Console.WriteLine("");
        }
        public static void sortQuick()
        {
          


            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + ",");
            }
            Console.WriteLine("");
            Sortt();

           
            

        }
        public static void Sortt()
        {
            for (int i = 0; i < numbers.Length * .5 - 1; i++)
            {
                Console.WriteLine(numbers[i] + ",  ");
                for (int j = numbers.Length -2; j > numbers.Length * .5 - 1; j--)
                {

                    Console.WriteLine(numbers[j]);
                    if (numbers[j] > numbers[i])
                    {

                    }
                    else
                    {

                        int dif = numbers[j] - numbers[i];
                        numbers[j] -= dif;
                        numbers[i] += dif;
                        //dostufffffffffffffffff
                    }
                }
                
            }
            if (numbers[numbers.Length - 1] >= numbers[numbers.Length / 2 - 1])
            {
                int fif = numbers[numbers.Length - 1] - numbers[numbers.Length / 2];
                numbers[numbers.Length - 1] += fif;
                numbers[numbers.Length / 2 - 1] -= fif;
            }
            else
            {
                int rif = numbers[numbers.Length / 2 - 1] - numbers[numbers.Length - 1];
                numbers[numbers.Length - 1] += rif;
                numbers[numbers.Length / 2 - 1] -= rif;
            }
            
            othr();
            
        }
       
      
    }
}
