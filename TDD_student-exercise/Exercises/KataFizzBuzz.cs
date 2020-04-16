using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int num)
        {
            
            string convert = num.ToString();
            if (!(num >= 1 && num <= 100))
            {
                return "";
            }
            else if ((num % 3 == 0 && num % 5 == 0) || (convert.Contains("3") && convert.Contains("5")))
            {
                return "FizzBuzz";
            }
            else if ((num % 5 == 0) || (convert.Contains("5")))
            {
                return "Buzz";
            }
            else if ((num % 3 == 0) || (convert.Contains("3")))
            {
                return "Fizz";
            }
            else
            {
                return convert;
            }
            }  
    }
}
