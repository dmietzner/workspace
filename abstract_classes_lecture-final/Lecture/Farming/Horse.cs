using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Horse : FarmAnimal
    {
        /// <summary>
        /// Creates a new horse.
        /// </summary>
        /// <param name="name">The name which the horse goes by.</param>
        public Horse() : base("HORSE")
        {
            Sound = "NEIGH";
        }

        public override string Eat()
        {
            return "Munch munch";
        }
    }
}
