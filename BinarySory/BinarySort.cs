using System;
namespace calc
{
    public static class BinarySort
    {
        public static int thing, DX, max;
        public static int[] numbers = new int[9]
        {
            15,
            8,
            4,
            6,
            10,
            23,
            1,
            -1,
            -9
        };

        public static void binarySortm()
        {
            foreach (int item in numbers)
            {
                Console.Write(numbers[thing] + ", ");
                thing++;
            }
            Console.WriteLine("");
            thing = 0;
            Action();
        }


        public static void rightitout()
        {
            thing = 0;
            foreach (int item in numbers)
            {
                Console.Write(numbers[thing] + ", ");
                thing++;
            }
            Console.WriteLine("");
        }



        public static void Action()
        {

            thing = 0;
            foreach (int item in numbers)
            {
                Console.Write(numbers[thing] + ", ");
                thing++;
            }
            Console.WriteLine("");
            if (numbers[DX] <= numbers[DX + 1])
            {
                //this thing makes it not change
                DX++;
                
            }
            else
            {
                //this thing is when it changes

                int dif = numbers[DX] - numbers[DX + 1];
                numbers[DX] -= dif;
                numbers[DX + 1] += dif;
                j();
                
               



            }
            d();
        }
        public static void d()
        {
            if (DX >= numbers.Length - 1)
            {
                DX = 0;
            }
            rep();
        }
        
        public static void rep()
        {
            max++;
            if (max >= numbers.Length * 5)
            {
                rightitout();
            }
            else
            {
                Action();
            }
        }
        public static void j()
        {
            if (DX >= numbers.Length - 2 || DX <= 0)
            {
                DX = 0;
            }
            else
            {
                if (numbers[DX] <= numbers[DX - 1])
                {
                    int hif = numbers[DX - 1] - numbers[DX];
                    numbers[DX] += hif;
                    numbers[DX - 1] -= hif;
                    thing = 0;
                    foreach (int item in numbers)
                    {
                        Console.Write(numbers[thing] + ", ");
                        thing++;
                    }
                    Console.WriteLine("");
                    if (DX > 1)
                    {
                        if ( numbers[DX - 1] <= numbers[DX - 2])
                        {
                            DX--;
                            j();

                        }
                        else
                        {
                            DX++;
                            d();
                        }
                    }
                    else
                    {
                        DX++;
                        d();
                    }



                }
            }
        }

        

    }
}
