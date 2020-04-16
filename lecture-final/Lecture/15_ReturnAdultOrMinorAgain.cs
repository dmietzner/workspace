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
        15. Now, do it again with a different bool opeation.
        TOPIC: Logical Not
        */
        public string ReturnAdultOrMinorAgain(int number)
        {
            string status = "Minor";
            if (number >= 18)
            {
                status =  "Adult";
            }

            return status;

            //return (number >= 18) ? "Adult" : "Minor";
        }
    }
}
