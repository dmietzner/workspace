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
        10.This method will take a number and do the following things to it:
            If addThree is true, we'll add three to that number
            If addFive is true, we'll add five to that number
            We'll then return the result
            TOPIC: Stacking Conditional Logic
        */
        public int ReturnNumberAfterAddThreeAndAddFive(int number, bool addThree, bool addFive)
        {
            // create result variable
            int result = number;

            if (addThree == true)
            {
                result = result + 3;
            }

            // Why can't we use an else here?

            //addFive is evaluated to true or false
            if (addFive)
            {
                result += 5;
            }

            return result;
        }
    }
}