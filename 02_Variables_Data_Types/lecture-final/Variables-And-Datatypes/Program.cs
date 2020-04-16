using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
            int numberOfExercises;
            numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
            double half;
            half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
            string name;
            // using escape character \ to print quote to console.
            name = "Tech \"Elevator\"";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly;
            seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage;
            myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            //use single quotes for single characters
            char myCharFavoriteLanguage;
            myCharFavoriteLanguage = 'C';
            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            float pi;
            pi = 3.1416F;

            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */
            string myName = "Henry Edwards";
            Console.WriteLine(myName);
            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numberOfButtons = 5;
            Console.Write(numberOfButtons);
            Console.Write(myName);
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            int percentBatteryRemaining = 75;
            Console.WriteLine(percentBatteryRemaining);
            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int difference = 121 - 27;
            Console.WriteLine(difference);
            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double sum;
            sum = 12.3 + 32.1;
            Console.WriteLine(sum);
            /*
            12. Create a string that holds your full name.
            */
            string fullName = "Henry Edwards";
            Console.WriteLine(fullName);
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string greeting = "Hello " + fullName;
            Console.WriteLine(greeting);
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            fullName = fullName + " Esquire";
            Console.WriteLine(fullName);
            Console.WriteLine(greeting);
            greeting = "Hello " + fullName;
            Console.WriteLine(greeting);

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            fullName += " the third";
            Console.WriteLine(fullName);
            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string word = "Saw";
            word += 2;
            Console.WriteLine(word);
            int sequalNumber = 5;
            Console.WriteLine(word + sequalNumber);
            Console.WriteLine(word);
            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            word += 0;
            Console.WriteLine(word);
            /*
            18. What is 4.4 divided by 2.2?
            */
            double result = 4.4 / 2.2;
            Console.WriteLine(result);
            /*
            19. What is 5.4 divided by 2?
            */
            Console.WriteLine(5.4 / 2);
            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            Console.WriteLine(5 / 2);
            /*
            21. What is 5.0 divided by 2?
            */
            Console.WriteLine(5.0 / 2);
            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            decimal balance = 1234.56M;
            Console.WriteLine(0.1 + 0.2);
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            int remainder = 42 % 2;
            Console.WriteLine(remainder);
            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int first = 3;
            int second = 1000000000;
            double multiplied = Convert.ToDouble(first) * second;
            Console.WriteLine(multiplied);
            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;
            Console.WriteLine(doneWithExercises);
            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;
            Console.WriteLine(doneWithExercises);


            Console.ReadLine();
        }
    }
}
