using System;
using System.IO;

namespace calc
{
    public class ReadCSV
    {
        public static string d = "dwdwdasdw";
        public static void readCSV()
        {
            using (StreamReader sr = new StreamReader("/Users/karenmalaska/Projects/CodeProfolio/IMDBDataset3.csv"))
            {
                int i = 0;
                string line;
                
                while ((line = sr.ReadLine()) != null && i <= 7)
                {
                    int cookieMan = line.Length - 8;
                    string[] good = line.Split(',');
                  //  string[] bad =  line.Split("negitive");
                    Console.WriteLine(line + cookieMan );
                    Console.WriteLine(good[good.Length - 1]);
                    i += 1;
                    
                }
            }
        }
    }
}
