using System;
namespace calc.TreeCounting
{
    
       public class Bina
        {
            public int value { get; set; }
        public Bina left { get; set; }
           public Bina right { get; set; }
       // public int rightitmes = 0;
    //    public int lefttimes = 0;

        public Bina(int[] values) : this(values, 1) { }

            Bina(int[] values, int index)
            {
            left = null;
            right = null;
            //index = 1;
                Load(this, values, index);
            }

        void Load(Bina tree, int[] values, int index)
        {
            value = values[index];
            if (index < values.Length - 1)
            {


                if (value <= values[index - 1])
                {
                    if (left == null )
                    {
                        Console.WriteLine(value + " k " + values[index - 1]);
                        this.left = new Bina(values, index + 1);
                    }
                    else
                    {
                        Load(tree, values, index );
                    }

                }

                if (value >= values[index - 1])
                {
                    Console.WriteLine(value + " x " + values[index - 1]);
                    this.right = new Bina(values, index + 1);
                }
                else
                {
             //      right.Load(tree, values, index + 1);
                }
            }

        }
           
        }
    }
   

