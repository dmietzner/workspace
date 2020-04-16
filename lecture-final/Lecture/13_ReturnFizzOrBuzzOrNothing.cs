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
         13. Write an if/else statement that returns 
            "Fizz" if the parameter is 3, 
            "Buzz" if the parameter is 5 
            and an empty string "" for anything else.
            TOPIC: Conditional Logic
         */
        public string ReturnFizzOrBuzzOrNothing(int number)
        {
            // otherwise empty string
            string output = "";

            // check is the paramerer 3
            if(number == 3)
            {
                // if yes, Fizz
                output = "Fizz";
            }
            // else check if it is 5
            else if (number == 5)
            {
                // if yes, Buzz
                output = "Buzz";
            }


            return output;
        }
    }
}
