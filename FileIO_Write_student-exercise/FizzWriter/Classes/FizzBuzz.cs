using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FizzWriter
{
    public class FizzBuzz
    {
        public static void MakeFizzBuzz()
        {
            string directory = Directory.GetCurrentDirectory();
            string fileName = "FizzBuzz.txt";
            string fullpath = Path.Combine(directory, fileName);

            

            using (StreamWriter sw = new StreamWriter(fullpath))
            {
                for (int i = 1; i <= 300;  i++)
                {
                    if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        sw.WriteLine("FizzBuzz");
                    }
                    else if(i % 5 == 0)
                    {
                        sw.WriteLine("Buzz");
                    }
                    else if(i % 3 == 0)
                    {
                        sw.WriteLine("Fizz");
                    }
                    else
                    {
                        sw.WriteLine(i.ToString());
                    }
                }
               

            }

        }

    }
}
