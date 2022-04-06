using System;


namespace calc
{
    public static class Programd
    
    {

        public static  int othernum, max, limit, othermax, startingthing;
        
       public static int[] numbers = new int[10]
        {
                1,
            42,69,
                8,
                20,
                3,
                -1,
                101,
                6,
                1
        };
        public static string str1, str2, str3, str4, str5;

        public static void Main(string[] args)
        {
            calc.LeetCodeProgs.ThreeSumMedium.threeSumMedium();
            //calc.LeetCodeProgs.Combination1.combination1();
            //calc.LeetCodeProgs.ALLSum.allSum();
            //calc.TreeCounting.BinaryTree.main(args);
            // calc.TreeCounting.Node.boni();
            // calc.EX.eX();

            //calc.ArrayWalking.ValidPalindromeII.validPalindromeII();
            //  calc.TreeCounting.BinaryTree.binaryTree();
            // calc.LinkedList.DoublyLinkedlistsort.doublyLinkedlistsort();
            // calc.LinkedList.PrintLinkedList.main(args);
            //calc.Graph.ContainesLoop.main(args);
            //ArrayWalking.FindHighestOccurrence.main();
            // Factorials.factorials();
            // FindGreatestSetOfNumbers.findGreatestSetOfNumbers();
            // ArrayWalking.LargestNumberUnder100.main(args);
            // ArrayWalking.DoesHaveRepeatingValues.main(args);


            //      othermax = numbers.Length;
            //calc.Quicksort.sortQuick();
            //calc.BinarySort.binarySortm();
            //calc.MergeSort.sortMerge();
            //calc.Bogosort.bogoSort();
            //      calc.CheckifAnogram.startGram();


        }

        }
        /*
        static void startsort()
        {
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                
                    Console.Write(numbers[0 + i] + " ");
                    
                
            }
            Console.WriteLine("");
            /*   foreach (int thing in numbers)
               {
                   Console.WriteLine(numbers[0 + startingthing]);
                   startingthing++;
             } 


            startingthing = 0;
                Sort();
            
        }
        static void Sort()
        {
           
            max = numbers.Length - 1;
           
           
            if (limit <= numbers.Length * 6)
            {

                if (numbers[0 + othernum] >= numbers[1 + othernum])
                {
                    int Execute1 = numbers[1 + othernum] - numbers[0 + othernum];
                    numbers[0 + othernum] += Execute1;
                    numbers[1 + othernum] -= Execute1;

                    othernum++;
                    limit++;
                    if (othernum >= max)
                    {
                        othernum = 0;
                    }
                    startsort();
                }
                else
                {
                    othernum++;
                    limit++;
                    if (othernum >= max)
                    {
                        othernum = 0;
                    }
                    startsort();
                }

            }
            else
            {
                Console.WriteLine("Done!");
            }
          
            
        }








        /*
  string AAA = "Andrew   is the Coolest";


  Console.WriteLine(AAA.ToLower());
  Console.WriteLine(AAA.ToUpper());

  Console.WriteLine(AAA.Trim());


  Console.WriteLine("put in - + * /");
  string um = Console.ReadLine();
  int number1;
  int number2;
  int anser;
  //  int number2;
  string stop = "start";
  // string ey = "stop";
  //This tells me what I write in console using ReadLine method
  string[] names = new string[4] { "+", "-", "*", "/" };
  //This is an array of strings!




  if (um == names[0])
  {
      Console.WriteLine("Write Your first Number");
      string number1Str = Console.ReadLine();

      if (int.TryParse(number1Str,out number1))
      {
          Console.WriteLine("You wrote:" + number1);
          Console.WriteLine("write the 2nd num");
          string number2Str = Console.ReadLine();

          if(int.TryParse(number2Str, out number2))
          {
              anser = number1 + number2;
              Console.WriteLine("You Wrote number2:" + number2);
              Console.WriteLine("The Awnser is:" + anser);
          }
          //WriteLine is method btw
      }
  }
  else if (um == names[1])
  {
      Console.WriteLine("Write your first num");
      string numbernstr1 = Console.ReadLine();
      if (int.TryParse(numbernstr1, out number1))
      {
          string numbernstr2 = Console.ReadLine();
          //methd
          if (int.TryParse(numbernstr2, out number2))
          {
              anser = number1 - number2;
              Console.WriteLine("Your awnser is:" + anser);
          }
      }
  }
  else if (um == names[2])
  {
      Console.WriteLine("Write your first num");
      string num1str = Console.ReadLine();
      if (int.TryParse(num1str, out number1))
      {
          Console.WriteLine("write number 2");
          string num2str = Console.ReadLine();
          if (int.TryParse(num2str, out number2))
          {
              anser = number1 * number2;
              Console.WriteLine("Your anser is:" + anser);
          }
      }
  }
  else if (um == names[3])
  {
      Console.WriteLine("Write your first num");
      string num11str = Console.ReadLine();
      if (int.TryParse(num11str, out number1))
      {
          Console.WriteLine("write number 2");
          string num22str = Console.ReadLine();
          if (int.TryParse(num22str, out number2))
          {
              anser = number1/number2;
              Console.WriteLine("Your anser is:" + anser);
          }
      }
  }
  else
  {
      Console.WriteLine("go back and do it again");
      Main(args);

      um = null;
  }
  */

    }
    
