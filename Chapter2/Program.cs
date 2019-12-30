using System;
using static System.Console;

namespace Chapter2
{
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
            }
        }
    }
}
