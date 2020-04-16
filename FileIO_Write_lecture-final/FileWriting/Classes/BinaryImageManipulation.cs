using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;

namespace FileWriting.Classes
{
    public static class BinaryImageManipulation
    {
        public static void ReadFileIn()
        {
            string folder = Directory.GetCurrentDirectory();
            string filename = "rick.jpg";
            string fullpath = Path.Combine(folder, filename);

            byte[] bytes = File.ReadAllBytes(fullpath);

            using(MemoryStream ms = new MemoryStream(bytes))
            {
               using(Image img = Image.FromStream(ms))
                {
                    Bitmap bmp = new Bitmap(img);
                    for(int x = 0; x < bmp.Width;x++)
                    {
                        for(int y=0;y < bmp.Height;y++)
                        {
                            Color oldPixel = bmp.GetPixel(x, y);
                            bmp.SetPixel(x, y, Color.FromArgb(oldPixel.R, Color.FromKnownColor(KnownColor.Gray)));

                        }
                    }
                    bmp.Save(Path.Combine(folder, "output.jpg"));
                }
            }
        }
    }
}
