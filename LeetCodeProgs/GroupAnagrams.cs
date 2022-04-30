using System;
using System.Collections.Generic;
namespace calc
{
    public class GroupAnagrams
    {
        public static IList<IList<string>> myList;
        public static string[] strs = new string[] {"Ana", "nAa", "Kos" };

        public static void groupAnagrams()
        {
            if (strs.Length == 0)
            {
                Console.WriteLine("None");
            }

            for(int i = 0; i < strs.Length; i++)
            {
                bool yesone = false;
                for (int j = 0; j < myList.Count; j++)
                {
                    
                    char[] charry = strs[i].ToCharArray();
                    var currentlist =  myList[j];
                    char[] larry  = currentlist[0].ToCharArray();
                    int charrylength = charry.Length;
                    if (charry.Length != larry.Length)
                    {
                        yesone = true;
                    }
                    else
                    {
                        for (int l = 0; l < charrylength; l++)
                        {
                            int count = 0;
                            for (int k = 0; k < charrylength; k++)
                            {
                                if (charry[l] == larry[k])
                                {
                                    count += 1;

                                }
                            }
                            if (count == charrylength)
                            {
                                yesone = true;

                                break;
                            }
                        }
                    }

                }
                if (yesone == false)
                {
                    myList.Add(new List<string>());
                    IList<string> currentList = myList[myList.Count];
                    Type d = List<int>();
                }
            }
        }
       
    }
}
