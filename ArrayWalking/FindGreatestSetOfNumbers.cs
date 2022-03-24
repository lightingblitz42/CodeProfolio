using System;
using System.Collections.Generic;
namespace calc
{
    public class FindGreatestSetOfNumbers
    {

        public static void findGreatestSetOfNumbers()
        {

            List<int> nums = new List<int>();
            List<int> Values = new List<int>();
            List<int> Others = new List<int>();

            int[] numbers = new int[9]
            {
                10,
                -9,
                4,
                7,
                -12,
                9,
                -10,
                3,
                -1
            };

            int result = greatestSumOfNumbers(numbers, nums, Values, Others);
            Console.WriteLine(result);
        }

        public static int greatestSumOfNumbers(int[] numbers, List<int> goAround, List<int> Values,List<int> Others)
        {
            int inputlength = numbers.Length;
            int point = 1;
            
            int[] numb = new int[point];
            int inputnumb = numb.Length;

            for (int l = 0; l < inputlength; l++)
            {
                point = 2;
                Console.WriteLine("d");
                //add another layer so it can go threw everysingle matchup


                for (int i = 0; i < inputnumb; i++)//forloop to check how long input num is
                {
                    //int[] Left = new int[middle];
                    //int[] Right = new int[inputLength - middle];
                    numb = new int[point];
                    inputnumb = numb.Length;
                    point++;
                    int val = 0;
                   
                   


                    if (point < inputlength)
                    {
                        for (int j = 0; j < inputnumb - 1; j++)
                        {
                            if (j < l)
                            {

                            }
                            else
                            {
                                numb[j] = numbers[j];// writes out all of array in line formate
                            }

                           
                            Console.Write(numb[j]);
                        }
                        Console.WriteLine("");

                       

                    }
                    else
                    {
                        break;//breaks if done
                    }
                    goAround.AddRange(numb);//puts things into lists
                    Others.Add(numb.Length);


                    for (int p = 0; p < inputnumb - 2; p++)//adds them all up to put into value
                    {

                        val += numb[p] + numb[p];


                    }
                    Values.Add(val);



                    Console.WriteLine(goAround[i] + "  <- was goAround  " + Others[i] + "   <- that was Others   " + Values[i] + "  <- that was Value  ");

                }
                
               
                
                
            }
           
             for (int k = 0; k < Values.Count - 1; k++)
            {
                if (Values[k] >= Values[k + 1])
                {
                    Values[k + 1] = Values[k];
                    Console.WriteLine(Values[k]);//gives biggest
                }
                else
                {
                    Values[k] = Values[k + 1];
                }
            }

            
            return Values[Values.Count - 1];
            //return goAround[goAround.Count - 1];



        }
    }
}

