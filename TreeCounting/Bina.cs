using System;
namespace calc.TreeCounting
{
    
       public class Bina
        {
            public int value;
           public Bina left;
           public Bina right;
            
            
            public Bina(int[] values) : this(values, 0) { }

            Bina(int[] values, int index)
            {
                Load(this, values, index);
            }

        void Load(Bina tree, int[] values, int index)
        {
            if (index < values.Length)
            {
                this.left = new Bina(values, index + 1);
            }
           
        }
           
        }
    }
   

