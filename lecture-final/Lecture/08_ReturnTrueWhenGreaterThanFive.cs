﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {
        /*
          8.This method checks a parameter passed to the method to see if it's
            greater than 5 and returns true if it is.
            TOPIC: Comparison Operators & Conditional Logic
        */
        public bool ReturnTrueWhenGreaterThanFive(int number)
        {
            // result variable
            bool greaterThan5 = false;

            if (number > 5)
            {
                greaterThan5 = true;
            }
            else
            {
                // technically this is not needed, because greaterThan5 is already false
                greaterThan5 = false;
            }
            return greaterThan5;
        }
    }
}
