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

        public override string MakeSoundOnce()
        {
            return Sound;
        }

        public override string MakeSoundTwice()
        {
            return MakeSoundOnce() + " " + MakeSoundOnce();
        }
    }
}
