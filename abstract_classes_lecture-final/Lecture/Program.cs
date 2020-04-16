using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // OLD MACDONALD
            //
            Console.WriteLine("Farm Animals");
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            // Let's try singing about a Farm Animal
            Horse horse = new Horse();
            Duck duck = new Duck();
            Chicken tyson = new Chicken();
            horse.IsSleeping = true;
            List<FarmAnimal> animals = new List<FarmAnimal>();
            animals.Add(horse);
            animals.Add(duck);
            animals.Add(new Chicken());
            animals.Add(new Horse());
            Cat felix = new Cat();
            animals.Add(felix);

            // Can we swap out any animal in place here?
            // Polymorphis through inheritance

            foreach (FarmAnimal animal in animals)
            {
                Console.WriteLine("And on his farm there was a " + animal.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + animal.MakeSoundTwice() + " here and a " + animal.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + animal.MakeSoundOnce() + ", there a " + animal.MakeSoundOnce() + " everywhere a " + animal.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine(animal.Eat());
                Console.WriteLine();

            }


            // What if we wanted to sing about other things on the farm that were 
            // singable but not farm animals?
            // Can it be done? 
            // Polymorphism through interface

            List<ISingable> singables = new List<ISingable>();
            singables.Add(horse);
            singables.Add(duck);

            Tractor tractor = new Tractor();
            singables.Add(tractor);
            Cow bessie = new Cow();
            singables.Add(bessie);
            singables.Add(tyson);
            Pitchfork pitchfork = new Pitchfork();
            singables.Add(pitchfork);

            Console.WriteLine();
            Console.WriteLine("Singables");
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            foreach (ISingable singable in singables)
            {
                Console.WriteLine("And on his farm there was a " + singable.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + singable.MakeSoundTwice() + " here and a " + singable.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + singable.MakeSoundOnce() + ", there a " + singable.MakeSoundOnce() + " everywhere a " + singable.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();

            }

            List<ISellable> sellables = new List<ISellable>();
            sellables.Add(tyson);
            sellables.Add(pitchfork);
            foreach(ISellable sellable in sellables)
            {
                Console.WriteLine(sellable);
            }


            Console.ReadLine();
        }
    }
}