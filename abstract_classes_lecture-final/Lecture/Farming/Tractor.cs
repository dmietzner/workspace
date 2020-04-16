using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Sound { get; set; }
        public string Name { get; set; }
        public Tractor()
        {
            Name = "Tractor";
        }
        public string MakeSoundOnce()
        {
            return "VROOM";
        }

        public string MakeSoundTwice()
        {
            return "VROOM VROOM";
        }
    }
}
