using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Cow : FarmAnimal
    {
        public Cow() : base("COW")
        {
            Sound = "MOO";
        }

        public override string Eat()
        {
            return "Chew chew";
        }
    }
}
