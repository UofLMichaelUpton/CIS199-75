using System;
using static System.Console;

namespace Chapter2
{
    enum Month
    {
        JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
    }

    enum Planets
    {
        MERCURY = 1, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE
    }

    class MainClass
    {
        public static void InchesToCentimetersInteractive()
        {
            const double CENTIMETERS = 2.54;  //constant for centimeters in an inch
            double inches;  //variable for user-specified inches

            //get inches from user
            Write("Enter the number of inches to convert to centimeters: ");
            inches = Convert.ToDouble(ReadLine());

            //display the results to the user
            WriteLine("{0} inches is {1} centimeters.", inches, inches * CENTIMETERS);
        }

        public static void ProjectedRaisesInteractive()
        {
            const double PROJECTED_RAISE = .04;  //constant for projected 4% raise
            double salary1,  //variable for the salary of employee1
                   salary2,  //variable for the salary of employee2
                   salary3;  //variable for the salary of employee3

            //get the current salary for each employee
            Write("Enter the current numeric salary for Employee 1: ");
            salary1 = Convert.ToDouble(ReadLine());
            Write("Enter the current numeric salary for Employee 2: ");
            salary2 = Convert.ToDouble(ReadLine());
            Write("Enter the current numeric salary for Employee 3: ");
            salary3 = Convert.ToDouble(ReadLine());

            //calculate the new salary for each employee
            salary1 += salary1 * PROJECTED_RAISE;
            salary2 += salary2 * PROJECTED_RAISE;
            salary3 += salary3 * PROJECTED_RAISE;

            //disaply the projected salary for each employee
            WriteLine("The projected salary of Employee 1 next year with a {0} increase is {1}", PROJECTED_RAISE.ToString("P0"), salary1.ToString("C2"));
            WriteLine("The projected salary of Employee 2 next year with a {0} increase is {1}", PROJECTED_RAISE.ToString("P0"), salary2.ToString("C2"));
            WriteLine("The projected salary of Employee 3 next year with a {0} increase is {1}", PROJECTED_RAISE.ToString("P0"), salary3.ToString("C2"));
        }

        public static void MoveEstimator()
        {
            const byte BASE_RATE = 200,  //constant for base rate
                       HOURLY_RATE = 150,  //constant for hourly rate
                       MILEAGE_RATE = 2;  //constant for mileage rate
            int miles,  //variable for user estimated miles
                hours,  //variable for user estimated hours
                total;  //variable for total move estimate

            //get the estimated miles and hours from the user
            Write("Enter the total estimated mileage of the move rounded to the nearest mile: ");
            miles = Convert.ToInt32(ReadLine());
            Write("Enter the total estimated hours of the move rounded to the nearest hour: ");
            hours = Convert.ToInt32(ReadLine());

            //calculate the total move estimate
            total = BASE_RATE + ((HOURLY_RATE * hours) + (MILEAGE_RATE * miles));

            //display the total estimate to the user
            WriteLine("The total estimate for the move is {0}", total.ToString("C0"));

        }

        public static void HoursAndMinutes()
        {
            const int MINUTES_TO_HOUR = 60;  //constant for number of minutes in an hour
            int minutes; //variable for number of minutes worked

            //prompt the user for the nuber of minutes worked
            Write("Enter the number of minutes worked rounded to the nearest minute: ");
            minutes = Convert.ToInt32(ReadLine());

            //show the number of hours and minutes worked to the user
            WriteLine("You worked {0} hours and {1} minutes.", minutes / MINUTES_TO_HOUR, minutes % MINUTES_TO_HOUR);
        }

        public static void EggsInteractive()
        {
            const byte DOZEN = 12;
            int hen1,  //variable for eggs produced by Hen 1
                hen2,  //variable for eggs produced by Hen 2
                hen3,  //variable for eggs produced by Hen 3
                hen4,  //variable for eggs produced by Hen 4
                sum;  //variable to sum all of the eggs

            //prompt the user for the number of eggs laid by each hen
            Write("Enter the number of eggs laid by Hen 1 for the month: ");
            hen1 = Convert.ToInt32(ReadLine());
            Write("Enter the number of eggs laid by Hen 2 for the month: ");
            hen2 = Convert.ToInt32(ReadLine());
            Write("Enter the number of eggs laid by Hen 3 for the month: ");
            hen3 = Convert.ToInt32(ReadLine());
            Write("Enter the number of eggs laid by Hen 4 for the month: ");
            hen4 = Convert.ToInt32(ReadLine());

            //sum all of the eggs
            sum = hen1 + hen2 + hen3 + hen4;

            //display the number of eggs in dozens to the user
            WriteLine("You have {0} dozen and {1} eggs.", sum / DOZEN, sum % DOZEN);
        }

        public static void MakeChange()
        {
            int amount,  //variable for amount entered by user
                newAmount,  //variable for a new amount after bills are calculated
                twenties,  //variable for the number of twenties
                tens,  //variable for the number of tens
                fives,  //variable for the number of fives
                ones;  //variable for the number of ones

            //prompt the user for an amount
            Write("Enter a whole dollar amount to make change for: $");
            amount = Convert.ToInt32(ReadLine());

            //calculate the change
            twenties = amount / 20;
            newAmount = amount % 20;
            tens = newAmount / 10;
            newAmount %= 10;
            fives = newAmount / 5;
            newAmount %= 5;
            ones = newAmount / 1;

            //display the numbers of bills to the user
            WriteLine("In ${0} there are {1} $20 bills, {2} $10 bills, {3} $5 bills and {4} $1 bills.", amount,
                      twenties, tens, fives, ones);
        }

        public static void TestsInteractive()
        {
            decimal testOne,  //variable for first test
                    testTwo,  //variable for second test
                    testThree,  //variable for third test
                    testFour,  //variable for fourth test
                    testFive,  //variable for fifth test
                    testSix,  //variable for sixth test
                    testSeven,  //variable for seventh test
                    testEight,  //variable for eigth test
                    testSum,  //variable for test sum
                    testAverage;  //variable for the average

            //prompt the user to enter 8 test scores
            Write("Enter in the first test score: ");
            testOne = Convert.ToDecimal(ReadLine());
            Write("Enter in the second test score: ");
            testTwo = Convert.ToDecimal(ReadLine());
            Write("Enter in the third test score: ");
            testThree = Convert.ToDecimal(ReadLine());
            Write("Enter in the fourth test score: ");
            testFour = Convert.ToDecimal(ReadLine());
            Write("Enter in the fifth test score: ");
            testFive = Convert.ToDecimal(ReadLine());
            Write("Enter in the sixth test score: ");
            testSix = Convert.ToDecimal(ReadLine());
            Write("Enter in the seventh test score: ");
            testSeven = Convert.ToDecimal(ReadLine());
            Write("Enter in the eighth test score: ");
            testEight = Convert.ToDecimal(ReadLine());

            //calculate the test average
            testSum = testOne + testTwo + testThree + testFour + testFive + testSix + testSeven + testEight;
            testAverage = (testSum / 8) / 100;

            //display the average to the user
            WriteLine("The average test score is {0}", testAverage.ToString("P2"));

        }

        public static void FahrenheitToCelcius()
        {
            const double MULTIPLIER = 5.0 / 9.0;  //constant for the multiplier
            double fahrenheit,  //user input for fahrenheit to be converted
                   celcius;  //variable for calculated celcius temperature

            //prompt the user for the fahrenheit value to be converted
            Write("Enter a fahrenheit temperature value: ");
            fahrenheit = Convert.ToDouble(ReadLine());

            //convert the fahrenheit temperature to celcius
            celcius = (fahrenheit - 32) * MULTIPLIER;

            //display the conversion to the user
            WriteLine("{0} degrees fahrenheit is {1} degrees celcius.", fahrenheit.ToString("f1"), celcius.ToString("f1"));
        }

        public static void MonthNames()
        {
            byte monthSelection;  //variable for the user's month selection

            //prompt the user for a month number
            Write("Enter a number between 1 and 12 for a month of the year: ");
            monthSelection = Convert.ToByte(ReadLine());

            //display the month to the user
            WriteLine("The month you entered is {0}.", (Month)monthSelection);
        }

        public static void Planets()
        {
            byte planetPosition;  //variable to get the planet number from the user

            //prompt the user for a planet number
            Write("Enter a planet number between 1 and 8: ");
            planetPosition = Convert.ToByte(ReadLine());

            //display the planet name to the user
            WriteLine("The planet that you've chosen is {0}", (Planets)planetPosition);
        }

        public static void PigLatin()
        {
            string userString,  //string that user will enter
                   string1,  //substring 1
                   string2;  //substring 2

            //prompt the user to enter a word
            Write("Enter a word to be translated to Pig Latin: ");
            userString = ReadLine();

            //convert the word into two substrings
            string1 = userString.Substring(0, 1);
            string2 = userString.Substring(1, userString.Length - 1);

            //display the strings to the user in a new order
            WriteLine(string2 + string1 + "ay");
        }

        public static void Main(string[] args)
        {
            byte userChoice;  //variable for user menu selection

            //display a menu for the user to choose which method to run
            //based on exercises from Chapter 2
            WriteLine("1: InchesToCentimetersInteractive");
            WriteLine("2: ProjectedRaisesInteractive");
            WriteLine("3: MoveEstimator");
            WriteLine("4: HoursAndMinutes");
            WriteLine("5: EggsInteractive");
            WriteLine("6: MakeChange");
            WriteLine("7: TestsInteractive");
            WriteLine("8: FahrenheitToCelsius");
            WriteLine("9: MonthNames");
            WriteLine("10: Planets");
            WriteLine("11: PigLatin");

            //prompt the user to select an option from the list
            Write("Please enter the number of your selection: ");

            //retrieve input from user
            userChoice = Convert.ToByte(ReadLine());

            //use switch to run the appropriate method based on user input
            switch (userChoice)
            {
                case 1:
                    InchesToCentimetersInteractive();
                    break;

                case 2:
                    ProjectedRaisesInteractive();
                    break;

                case 3:
                    MoveEstimator();
                    break;

                case 4:
                    HoursAndMinutes();
                    break;

                case 5:
                    EggsInteractive();
                    break;

                case 6:
                    MakeChange();
                    break;

                case 7:
                    TestsInteractive();
                    break;

                case 8:
                    FahrenheitToCelcius();
                    break;

                case 9:
                    MonthNames();
                    break;

                case 10:
                    Planets();
                    break;

                case 11:
                    PigLatin();
                    break;
            }
        }
    }
}
