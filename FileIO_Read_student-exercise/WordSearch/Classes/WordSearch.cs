using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
// /Users/Student/workspace/danmietzner-c/module-1/17_FileIO_Reading_in/student-exercise/alices_adventures_in_wonderland.txt ---- is the full path
namespace WordSearch
{
    public static class WordSearch
    {


        public static void FindAlice()
        {
            Console.WriteLine("Welcome to Alice in Wonderland Word Search");
            Console.WriteLine("Enter the fully qualified path of the file");
            string fullPath = Console.ReadLine();
            int lineNum = 1;
            string line = "";
            Console.WriteLine("Enter search word");
            string search = Console.ReadLine();
            Console.WriteLine("Would you like to make your search case insensitive? (Y/N)");
            string userInput = Console.ReadLine();
            bool caseInsensitive = false;
            if (userInput.Equals("Y"))
            {
                caseInsensitive = true;
                search = search.ToLower();
            }
            
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                
                        line = sr.ReadLine();
                        string searchString = line;
                        if (caseInsensitive)
                        {
                            searchString = searchString.ToLower();
                        }
                        if (searchString.Contains(search))
                        {
                            // "<lineno>) <line>"
                            Console.WriteLine(lineNum.ToString() + ") " + line);
                        }
                        lineNum++;
                    }
              
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Try again");
            }



        }
    }
}
    

