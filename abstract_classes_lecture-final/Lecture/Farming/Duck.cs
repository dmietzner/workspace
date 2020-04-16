using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Duck : FarmAnimal
    {
        public Duck() : base("DUCK")
        {
            Sound = "Quack";
        }

        public override string Eat()
        {
            return "Sip sip";
        }
    }
}
