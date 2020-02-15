using System;
using static System.Console;

namespace Chapter5
{

    class Program
    {
        static void SumFiveInts()
        {
            const int LIMIT = 5;  //constant for loop limit
            int x,  //counting variable
                newNumber,  //variable to be collected from the user
                sum = 0;  //running

            for (x = 0; x < LIMIT; ++x)
            {
                Write("Enter a number to be added to the total >> ");
                newNumber = int.Parse(ReadLine());
                sum += newNumber;
                WriteLine($"The new total is {sum}.");
            }
        }

        static void SumInts()
        {
            const int BREAK_NUMBER = 999;
            int newNumber,  //variable that user enters for summing
                sum = 0;  //variable for the sum of numbers

            do
            {
                WriteLine($"Sum is {sum}");
                Write("Enter a number to be added or enter 999 to quit >> ");
                newNumber = int.Parse(ReadLine());
                sum += newNumber;
            } while (newNumber != BREAK_NUMBER);
        }

        static void EnterUppercaseLetters()
        {
            char letter;  //char variable the user will enter

            do
            {
                //get a letter from the user
                Write("Enter an uppercase letter or ! to quit >> ");
                letter = char.Parse(ReadLine());

                //determine if letter is uppercase or lowercase
                if (letter >= 65 && letter <= 90)
                    WriteLine("OK");
                else if (letter >= 97 && letter <= 122)
                    WriteLine("That is not an uppercase letter.");
            } while (letter != 33);
        }

        static void DailyTemps()
        {
            const int LOW_TEMP = -20,  //constant for the min valid temp
                      HIGH_TEMP = 130;  //constant for the max valid temp
            int highTemp,  //variable for the entered temp
                count = 0,  //variable to count how many temperatures are entered
                sum = 0,  //variable for the sum of the temperatures entered
                average;  //variable for the average temperature entered

            do
            {
                //get temeratures from user until a sentinel value is entered
                Write("Enter a daily high temperature >> ");
                highTemp = int.Parse(ReadLine());

                //sum the highTemps
                sum += highTemp;

                //increment the number of temperatures entered
                count++;
            } while (highTemp >= LOW_TEMP && highTemp <= HIGH_TEMP);

            //compute the average taking out the sentinel value
            average = (sum - highTemp) / (count - 1);

            //Show the user how many temperatures they entered and the sum
            WriteLine($"You entered {count - 1} temperatures for an average of {average}.");
        }

        static void HomeSales()
        {
            char initial;  //variable for salesperson initial
            decimal danielleSales = 0m,  //variable for Danielle sales
                    edwardSales = 0m,  //variable for Edward sales
                    francisSales = 0m,  //variable for Francis sales
                    totalSales;  //variable for total sales

            do
            {
                //get initial from the user
                Write("Enter 'D' for Danielle, 'E' for Edward, 'F' for Francis or 'Z' to get sales totals >> ");
                initial = char.Parse(ReadLine());

                //keep running sales totals for each salesperson
                //break out of the loop if Z is selected and take user
                //back to the top of the loop if an invalid initial is entered
                if (initial == 'D' || initial == 'd')
                {
                    Write("Enter the sale amount >> ");
                    danielleSales += decimal.Parse(ReadLine());
                }
                else if (initial == 'E' || initial == 'e')
                {
                    Write("Enter the sale amount >> ");
                    edwardSales += decimal.Parse(ReadLine());
                }
                else if (initial == 'F' || initial == 'f')
                {
                    Write("Enter the sale amount >> ");
                    francisSales += decimal.Parse(ReadLine());
                }
                else if (initial == 'Z' || initial == 'z')
                    break;
                else
                    WriteLine("That is an invalid selection.  Please try again.");
            } while (initial != 'Z' || initial != 'z');

            //display the totals for each salesperson
            WriteLine($"Danielle sold {danielleSales:c}.");
            WriteLine($"Edward sold {edwardSales:c}.");
            WriteLine($"Francis sold {francisSales:c}.");

            //display the grand total of sales
            totalSales = danielleSales + edwardSales + francisSales;
            WriteLine($"The grand total of all sales is {totalSales:c}.");

            //determine the highest salesperson and display to the user
            if (danielleSales > edwardSales && danielleSales > francisSales)
                WriteLine("Danielle has the highest sales total!");
            else if (edwardSales > danielleSales && edwardSales > francisSales)
                WriteLine("Edward has the highest sales total!");
            else if (francisSales > danielleSales && francisSales > edwardSales)
                WriteLine("Francis has the highest sales total!");
        }

        static void DisplayMultiplicationTable()
        {
            const int MAX = 10;  //max count for loops
            int x,  //counting variable
                y,  //counting variable
                product;  //product of x and y

            //outside loop that will remain on one number
            for (x = 1; x <= MAX; ++x)
            {
                Write("\n");
                //inner loop to go through 10 to calculate products for one number
                //and display on one line
                for (y = 1; y <= MAX; ++y)
                {
                    product = x * y;
                    Write($"{product}\t");
                }
            }
        }

        static void MultiplicationTable()
        {
            const int MAX = 10;  //max loop count
            int x,  //counting variable
                userOperand,  //operand entered by user
                product;  //product of operands

            //prompt the user to enter an integer
            Write("Enter an integer to multiply >> ");
            userOperand = int.Parse(ReadLine());

            for (x = 1; x <= MAX; ++x)
            {
                product = x * userOperand;
                WriteLine($"{x} X {userOperand} = {product}");
            }
        }

        static void OddNums()
        {
            const int MAX = 100;  //max loop count
            int x;  //counting variable

            for (x = 1; x < MAX; ++x)
            {
                if (x % 2 != 0)
                    Write($"{x}");
                else
                    Write(" ");
            }
        }

        static void Sum200()
        {
            const int MAX = 200,  //constant for max loop iterations
                      HALFWAY = MAX / 2;  //constant for the halfway point to display
            int x,  //counting variable
                sum = 0;  //variable to hold sum

            for (x = 1; x <= MAX; ++x)
            {
                sum += x;

                if (x == HALFWAY)
                    WriteLine($"Sum of 1 through {HALFWAY} is {sum}.");
            }
            WriteLine($"Sum of 1 through {MAX} is {sum}.");
        }

        static void Perfect()
        {
            const int MAX = 10000;  //constant for max number of loop iterations
            int x,  //counting variable
                y,  //counting variable
                sum;  //variable to hold a sum

            //outer loop brings up the number for perfect number determination
            for (x = 1; x <= MAX; ++x)
            {
                //initialize sum to zero for each outer loop iteration
                sum = 0;
                //inner loop that will sum up any number that divide evenly into the number
                for (y = 1; y < x; ++y)
                {
                    if (x % y == 0)
                        sum += y;
                }
                //if sum equals the number then it is perfect
                //print the perfect numbers in the console
                if (sum == x)
                    Write($"{x} ");
            }
        }

        static void TippingTable3()
        {
            const double TIPSTEP = .05,  //tipstep interval
                          DINNERSTEP = 10.00;  //dinnerstep interval
            double lowRate,  //user-entered low tip rate
                    highRate,  //user-entered high tip rate
                    lowBill,  //user-entered low bill
                    highBill,  //user-entered high bill
                    tipRate,  //tip rate variable
                    dinnerPrice,  //dinner price variable
                    tipAmount;  //calculated tip amount
            int x;  //counting variable

            //get the tip rates and bill amounts from the user
            Write("What is the minimum tip rate? ");
            lowRate = double.Parse(ReadLine());
            Write("What is the maximum tip rate? ");
            highRate = double.Parse(ReadLine());
            Write("What is the low dinner bill amount? ");
            lowBill = double.Parse(ReadLine());
            Write("What is the high dinner bill amount? ");
            highBill = double.Parse(ReadLine());

            //make the header
            Write("Price  |");
            for (tipRate = lowRate; tipRate <= highRate; tipRate += TIPSTEP)
                Write($"{tipRate,-7:p0}|");
            WriteLine();
            for (x = 0; x <= ((highRate - lowRate) / TIPSTEP) + 2; x++)
                Write("-------");
            WriteLine();

            //fill in the table
            for (dinnerPrice = lowBill; dinnerPrice <= highBill; dinnerPrice += DINNERSTEP)
            {
                Write($"{dinnerPrice,-7:c}|");
                //inner loop to fill in the tip amounts
                for (tipRate = lowRate; tipRate <= highRate; tipRate += TIPSTEP)
                {
                    tipAmount = dinnerPrice * tipRate;
                    Write($"{tipAmount,-7:c}|");
                }
                tipRate = lowRate;
                WriteLine();
            }
        }

        static void WebAddress()
        {
            const string prefix = "www.",  //constant for the www.
                         postfix = ".com";  //constant for the .com
            string businessName,  //variable for the business name
                   noSpaces = "";  //variable for the business name with no spaces
            int x;  //counting variable

            //prompt user to enter a business name
            Write("Enter your business name >> ");
            businessName = ReadLine();

            //remove the spaces from the business name
            for (x = 0; x < businessName.Length; ++x)
            {
                if (businessName.Substring(x, 1) != " ")
                    noSpaces += businessName.Substring(x, 1);
            }

            //create the web address
            WriteLine("Suggested web address is " + prefix + noSpaces + postfix);

        }

        static void CountVowels()
        {
            string phrase,  //variable for the user phrase
                   compareChar = "";  //variable to create a string to determine if it's a vowel
            int noOfVowels = 0,  //variable to count the number of vowels
                x;  //counting variable

            //get phrase from the user
            Write("Enter a phrase to count the vowels >> ");
            phrase = ReadLine();

            for (x = 0; x < phrase.Length; ++x)
            {
                compareChar = phrase.Substring(x, 1);

                if (compareChar.Equals("a") || compareChar.Equals("A") ||
                    compareChar.Equals("e") || compareChar.Equals("E") ||
                    compareChar.Equals("i") || compareChar.Equals("I") ||
                    compareChar.Equals("o") || compareChar.Equals("O") ||
                    compareChar.Equals("u") || compareChar.Equals("U"))
                    noOfVowels++;
            }

            WriteLine($"There are {noOfVowels} vowels in the phrase.");
        }

        static void GuessingGame2()
        {
            Random ranNumber = new Random();  //create instance of Random() to make a random number
            int randomNumber = ranNumber.Next(1, 11),  //generate a ramdom number between 1 and 10
                userGuess;  //variable for the guess entered by the user

            //get guess from user
            Write("Guess a number between 1 and 10 >> ");
            userGuess = int.Parse(ReadLine());

            //get guess from user until the number matches the randomNumber
            while (userGuess != randomNumber)
            {
                if (userGuess < randomNumber)
                    WriteLine("The guess is too low.");
                else if (userGuess > randomNumber)
                    WriteLine("The guess is too high.");
                Write("Guess a number between 1 and 10 >> ");
                userGuess = int.Parse(ReadLine());
            }

            //let the user know they're right when the guess is correct
            WriteLine($"That's right!  The number is {randomNumber}.");
        }

        static void GuessingGame3()
        {
            Random ranNumber = new Random();  //create instance of Random() to make a random number
            int randomNumber = ranNumber.Next(1, 11),  //generate a ramdom number between 1 and 10
                userGuess,  //variable for the guess entered by the user
                lowGuess = 0,  //variable for a guess that was too low
                highGuess = 0;  //variable for a guess that was too high

            //get guess from user
            Write("Guess a number between 1 and 10 >> ");
            userGuess = int.Parse(ReadLine());

            if (userGuess < randomNumber)
                lowGuess = userGuess;
            else if (userGuess > randomNumber)
                highGuess = userGuess;

            //get guess from user until the number matches the randomNumber
            //if they guess higher or lower than a number that was already
            //high or low then it lets the user know that they should know better
            while (userGuess != randomNumber)
            {
                if (userGuess < randomNumber && userGuess < lowGuess)
                {
                    WriteLine("You should know that that number is too low!");
                }
                else if (userGuess < randomNumber)
                    WriteLine("The guess is too low.");
                else if (userGuess > randomNumber && userGuess > highGuess)
                {
                    WriteLine("You should know that that number is too high!");
                    highGuess = userGuess;
                }
                else if (userGuess > randomNumber)
                    WriteLine("The guess is too high.");
                Write("Guess a number between 1 and 10 >> ");
                userGuess = int.Parse(ReadLine());
            }

            //let the user know they're right when the guess is correct
            WriteLine($"That's right!  The number is {randomNumber}.");
        }

        static void Main(string[] args)
        {
            int menuChoice;  //variable for a menu selection

            WriteLine("1: SumFiveInts()");
            WriteLine("2: SumInts()");
            WriteLine("3: EnterUppercaseLetters()");
            WriteLine("4: DailyTemps()");
            WriteLine("5: HomeSales()");
            WriteLine("6: DisplayMultiplicationTable()");
            WriteLine("7: MultiplicationTable()");
            WriteLine("8: OddNums()");
            WriteLine("9: Sum200()");
            WriteLine("10: Perfect()");
            WriteLine("11: TippingTable3()");
            WriteLine("12: WebAddress()");
            WriteLine("13: CountVowels()");
            WriteLine("14: GuessingGame2()");
            WriteLine("15: GuessingGame3()");
            Write("Enter a selection >> ");
            menuChoice = int.Parse(ReadLine());

            //switch structure for running selected method
            switch (menuChoice)
            {
                case 1:
                    SumFiveInts();
                    break;

                case 2:
                    SumInts();
                    break;

                case 3:
                    EnterUppercaseLetters();
                    break;

                case 4:
                    DailyTemps();
                    break;

                case 5:
                    HomeSales();
                    break;

                case 6:
                    DisplayMultiplicationTable();
                    break;

                case 7:
                    MultiplicationTable();
                    break;

                case 8:
                    OddNums();
                    break;

                case 9:
                    Sum200();
                    break;

                case 10:
                    Perfect();
                    break;

                case 11:
                    TippingTable3();
                    break;

                case 12:
                    WebAddress();
                    break;

                case 13:
                    CountVowels();
                    break;

                case 14:
                    GuessingGame2();
                    break;

                case 15:
                    GuessingGame3();
                    break;
            }
        }
    }
}
