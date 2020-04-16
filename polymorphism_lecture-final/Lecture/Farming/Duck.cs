﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Duck : FarmAnimal
    {
        public Duck() : base("DUCK")
        {

        }

        public override string MakeSoundOnce()
        {
            return "QUACK";
        }

        public override string MakeSoundTwice()
        {
            return "QUACK QUACK";
        }
    }
}