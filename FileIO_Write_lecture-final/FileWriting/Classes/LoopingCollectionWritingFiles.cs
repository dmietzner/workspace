using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileWriting.Classes
{
    public class LoopingCollectionWritingFiles
    {
        public bool LoopingADictionary()
        {
            Dictionary<string, double> programmingLanguages = new Dictionary<string, double>()
            {
                {"Java", 100.0 },
                {"C", 99.9 },
                {"C++", 99.4 },
                {"Python", 96.5 },
                {"C#", 91.3 },
                {"R", 84.8 },
                {"PHP", 84.5 },
                {"JavaScript", 83.0 },
                {"Ruby", 76.2 },
                {"Matlab", 72.4 }
            };

            string directory = Directory.GetCurrentDirectory();
            string filename = "programminglanguages.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    foreach (KeyValuePair<string, double> kvp in programmingLanguages)
                    {
                        Console.WriteLine($"{kvp.Key} has a favorite rating of {kvp.Value}");
                        sw.WriteLine($"{kvp.Key} has a favorite rating of {kvp.Value}");
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public void GoodPerformance()
        {
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "gperformance.txt");

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        sw.WriteLine($"The number is {i}");
                        sw.Flush();
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        public void BadPerformance()
        {
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "bperformance.txt");

            try
            {
                for (int i = 0; i < 100000; i++)
                {
                    using (StreamWriter sw = new StreamWriter(fullPath))
                    {
                        sw.WriteLine($"The number is {i}");
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
