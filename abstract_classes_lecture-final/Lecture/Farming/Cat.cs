using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public sealed class Cat : FarmAnimal
    {
        public Cat() : base("CAT")
        {
            Sound = "Meow";
            IsSleeping = true;
        }

        public override string Eat()
        {
            return "Toss food on floor";
        }
    }
}
