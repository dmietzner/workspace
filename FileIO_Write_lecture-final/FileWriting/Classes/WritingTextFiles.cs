using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileWriting.Classes
{
    public class WritingTextFiles
    {
        public bool WritingAFile()
        {
            // Get the current directory
            string directory = Directory.GetCurrentDirectory();
            // name a file for output
            string filename = "output.txt";
            // generate the fully qualified path
            string fullPath = Path.Combine(directory, filename);

            try
            {
                // Create writer
                // if the second parameter is true, append to the file
                // without the second parameter, the file will be created/overwritten
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    // Write out the current time
                    sw.WriteLine(DateTime.UtcNow);

                    // Print Hello World
                    sw.Write("Hello ");
                    sw.WriteLine("World");

                    // print a blank line
                    sw.WriteLine();

                    // Print where you are
                    sw.WriteLine("Tech");
                    sw.WriteLine("Elevator");

                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
