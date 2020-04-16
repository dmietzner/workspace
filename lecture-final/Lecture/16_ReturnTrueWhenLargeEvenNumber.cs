using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" when number is even, larger than 100, and a multiple of 5.
            Return "Big Number" if the number is just larger than 100.
            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            // our return variable
            string result = "";
            // if the number larger than 100, even and multiple of  5?
            if(number > 100 && number % 5 == 0 && number % 2 == 0)
            {
                // if it is, then I want Big Even Number
                result = "Big Even Number";
            }
            // else if larger than 100
            else if (number > 100)
            {
                // yes? return Big number
                result = "Big Number";
            }


            //Not either? return empty
            return result;
        }
        


    }
}
