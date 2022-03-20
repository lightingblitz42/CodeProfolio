using System;

namespace calc
{
    public class CheckifAnogram
    {

        private static string[] str = new string[5]
            {
                "ana",
                "adsdh",
                "asdbobffe",
                "lool",
                "bob",
            };

        public static void startGram()
        {
            for (int i = 0; i < str.Length; i++)
            {
                anoGram(str[i]);
            }

        }
        public static void anoGram(string inputString)
        {


            char[] letters = inputString.ToCharArray();
            if (letters.Length < 3)
            {
                return;
            }
            foreach (var item in letters)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("");

            
            if (CheckOgram(letters))
            {
                Console.WriteLine("yay  " + inputString + "  is an anogram");
            } else
            {
                Console.WriteLine("sadly  " + inputString + "  isent an anogram");
            }

        }
        public static bool CheckOgram(char[] letters)
        {
            int j = 0;
            int r = 0;
            int k = letters.Length - 1;
            while (k - r > j)
            {
                //Console.WriteLine(r + " " + j + " " + k);
                if (letters[j] != letters[k - r])
                {

                    //Console.WriteLine(letters[j] + " " + letters[k - r]);
                    return false;
                }

                r++;
                j++;

            }

            return true;

        }

    }
}
//var s = "foo bar";

//char[] c = s.ToCharArray();

//c[0]