using System;
using static System.Console;

namespace Chapter4
{
    enum Month
    {
        January = 1, February, March, April, May, June, July, August, September, October, November, December
    }

    class Program
    {
        //Chapter 4 Exercise 1
        public static void CheckCredit()
        {
            const double CREDIT_LIMIT = 8000;  //constant for the specified credit limit
            double purchasePrice;  //variable for the user-entered purchase price

            //prompt the user for purchasePrice and convert it to a double
            Write("Enter the purchase price of the item >> ");
            purchasePrice = Convert.ToDouble(ReadLine());

            //determine if the purchase is denied or approved based on CREDIT_LIMIT
            if (purchasePrice > CREDIT_LIMIT)
                WriteLine("This purchase has been denied");
            else
                WriteLine("Approved");
        }

        //Chapter 4 Exercise 2
        public static void Twitter()
        {
            const byte ACCEPTED_LENGTH = 140;  //constant for the accepted length of the message
            string userMessage;  //variable for the message the user inputs

            //prompt the user to enter a message as userMessage
            Write("Enter a message to post to your friends >> ");
            userMessage = ReadLine();

            //determine if the length of the message is acceptable and display a message to the user if it is or isn't
            if (userMessage.Length < ACCEPTED_LENGTH)
                WriteLine("This message is {0} characters and acceptable to post.", userMessage.Length);
            else
                WriteLine("This message is {0} characters and too long to post.", userMessage.Length);
        }

        //Chapter 4 Exercise 3
        public static void Admission()
        {
            const double GPA = 3.0;  //constant for GPA comparison
            const byte TEST_SCORE_LOW = 60,  //constant for lower test score comparison
                       TEST_SCORE_HIGH = 80;  //constant for higher test score comparison
            double studentGPA;  //variable for GPA entered by student
            int studentTestScore;  //variable for admissions test score entered by student

            //prompt the user for their GPA and admission test score
            //then convert them to double and int, respectively
            Write("Enter your High School GPA >> ");
            studentGPA = Convert.ToDouble(ReadLine());
            Write("Enter your admission test score >> ");
            studentTestScore = Convert.ToInt32(ReadLine());

            //compare the GPA and test score to criteria and display either Accept or Reject
            if ((studentGPA > GPA) && (studentTestScore >= TEST_SCORE_LOW) || ((studentGPA < GPA) && (studentTestScore >= TEST_SCORE_HIGH)))
                WriteLine("Accept");
            else
                WriteLine("Reject");
        }

        //Chapter 4 Exercise 4
        public static void Hurricane()
        {
            const byte CAT5_MIN = 157,  //constant for minimum wind speed of a category 5 hurricane
                       CAT4_MIN = 130,  //constant for minimum wind speed of a category 4 hurricane
                       CAT3_MIN = 111,  //constant for minimum wind speed of a category 3 hurricane
                       CAT2_MIN = 96,  //constant for minimum wind speed of a category 2 hurricane
                       CAT1_MIN = 74;  //constant for minimum wind speed of a category 1 hurricane

            int windSpeed;  //variable for user-entered wind speed

            //prompt the user for the wind speed and convert it to an integer
            Write("Enter the wind speed of the storm >> ");
            windSpeed = Convert.ToInt32(ReadLine());

            //in nested if-else, determine the category of the hurricane and display it to the user
            if (windSpeed >= CAT5_MIN)
                WriteLine("Category 5");
            else if (windSpeed >= CAT4_MIN)
                WriteLine("Category 4");
            else if (windSpeed >= CAT3_MIN)
                WriteLine("Category 3");
            else if (windSpeed >= CAT2_MIN)
                WriteLine("Category 2");
            else if (windSpeed >= CAT1_MIN)
                WriteLine("Category 1");
            else
                WriteLine("This storm is not a hurricane");
        }

        //Chapter 4 Exercise 5b
        public static void CheckMonth()
        {
            byte month,  //variable for the month entered by the user
                 day;  //variable for the day entered by the user

            //get month and convert it to a byte
            Write("Enter your month of birth >> ");
            month = Convert.ToByte(ReadLine());

            //get month from user and then day if it is valid
            if (month > 1 || month < 12)
            {
                Write("Enter you day of birth >> ");
                day = Convert.ToByte(ReadLine());

                //if day is invalid then display an error
                if ((day > 31 || day < 1) ||
                   (day > 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)) ||
                   (day > 30 && (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)) ||
                   (day > 29 && month == 2))
                    WriteLine("The day you have entered is invalid.");
                //else day is valid and display the user's birthday
                else
                    WriteLine("Your birthday is {0} {1}", (Month)month, day);
            }
            //else display an error
            else
                WriteLine("The month you have entered is invalid.");
        }

        //Chapter 4 Exercise 6
        public static void CheckDigit()
        {
            const byte DIVISOR_7 = 7;  //constant for dividing the account number
            int s1AccountNumber;  //variable to convert the parsed string to an int
            string accountNumber,  //variable for user-entered account number
                   string1;  //variable to parse out the first three digits of the account number

            Write("Enter a 4-dgit account number >> ");
            accountNumber = ReadLine();

            //parse out the first three digits of the account number
            string1 = accountNumber.Substring(0, 3);

            //convert the parsed string into an integer
            s1AccountNumber = Convert.ToInt32(string1);

            //determine if the account number is valid
            //and let the user know if it is or isn't
            if (s1AccountNumber % DIVISOR_7 == 0)
                WriteLine("You have entered a valid account number.");
            else
                WriteLine("You have entered an invalid account number.");
        }

        //Chapter 4 Exercise 7
        public static void GuessingGame()
        {
            byte numberGuess;  //variable for the user to enter a number

            //generate a random number
            Random ranNumberGenerator = new Random();
            int randomNumber = ranNumberGenerator.Next(1, 11);

            //ask user to enter a number between 1 and 10
            Write("Enter a number between 1 and 10 >> ");
            numberGuess = Convert.ToByte(ReadLine());

            //determine if user's number is too low, too high or correct and display
            if (numberGuess < randomNumber)
                WriteLine("Sorry, that number is too low!  The correct number is {0}.", randomNumber);
            else if (numberGuess > randomNumber)
                WriteLine("Sorry, that number is too high! The correct number is {0}.", randomNumber);
            else
                WriteLine("That is correct!");
        }

        //Chapter 4 Exercise 8
        public static void RockPaperScissors()
        {
            char rpsChar;  //char to enter r, p or s for the user

            //generate a random number between 1 and 3
            //1 will be rock
            //2 will be paper
            //3 will be scissors
            Random ranNumberGenerator = new Random();
            int randomNumber = ranNumberGenerator.Next(1, 4);

            //prompt the user to enter r, p or s
            Write("Enter r for rock, p for paper or s for scissors >> ");
            rpsChar = Convert.ToChar(ReadLine());

            //create a switch that will compare user input to enum integer value for result
            switch (rpsChar)
            {
                case 'r':
                    if (randomNumber == 1)
                        WriteLine("You both chose rock so it is a draw.");
                    else if (randomNumber == 3)
                        WriteLine("You chose rock and the computer chose scissors." +
                                  "\nRock beats scissors.  You win!");
                    else
                        WriteLine("You chose rock and the computer chose paper." +
                                  "\nPaper beats rock.  Sorry, you lose.");
                    break;
                case 'p':
                    if (randomNumber == 2)
                        WriteLine("You both chose paper so it is a draw.");
                    else if (randomNumber == 1)
                        WriteLine("You chose paper and the computer chose rock." +
                                  "\nPaper beats rock.  You win!");
                    else
                        WriteLine("You chose paper and the computer chose scissors." +
                                  "\nScissors beats rock.  Sorry, you lose.");
                    break;
                case 's':
                    if (randomNumber == 3)
                        WriteLine("You both chose scissors so it is a draw.");
                    else if (randomNumber == 2)
                        WriteLine("You chose scissors and the computer chose paper." +
                                  "\nScissors beats paper.  You win!");
                    else
                        WriteLine("You chose scissors and the computer chose rock." +
                                  "\nRock beats scissors.  Sorry, you lose.");
                    break;
            }
        }

        //Chapter 4 Exercise 9
        public static void Lottery()
        {
            const int ONE_MATCH = 10,  //constant for one matching number award
                      TWO_MATCH = 100,  //constant for two matching number award
                      THREE_MATCH_RANDOM = 1000,  //constant for three matching numbers in any order
                      THREE_MATCH_ORDER = 10000,  //constant for three matching numbers in exact order
                      NO_MATCH = 0;  //constant for no matching numbers
            int userNum1,  //variable for the first user number
                userNum2,  //variable for the second user number
                userNum3;  //variable for the third user number

            //generate three random numbers between 1 and 4
            Random ranNumberGenerator = new Random();
            int cpuNum1 = ranNumberGenerator.Next(1, 5), //variable for the first random number
                cpuNum2 = ranNumberGenerator.Next(1, 5), //variable for the second random number
                cpuNum3 = ranNumberGenerator.Next(1, 5); //variable for the third random number
            WriteLine("{0}{1}{2}", cpuNum1, cpuNum2, cpuNum3);
            //prompt the user to enter in three numbers (one at a time)
            Write("Enter the first number between 1 and 4 >> ");
            userNum1 = Convert.ToInt32(ReadLine());
            Write("Enter the second number between 1 and 4 >> ");
            userNum2 = Convert.ToInt32(ReadLine());
            Write("Enter the third number between 1 and 4 >> ");
            userNum3 = Convert.ToInt32(ReadLine());

            //show the user the random numbers and the numbers they chose
            WriteLine("The winning numbers are {0}{1}{2}." +
                      "\nYou chose {3}{4}{5}.", cpuNum1, cpuNum2, cpuNum3, userNum1, userNum2, userNum3);

            //compare the numbers based on awards and display message to user what they won
            if (userNum1 == cpuNum1 && userNum2 == cpuNum2 && userNum3 == cpuNum3)
                WriteLine("Congratulations, you won {0}!", THREE_MATCH_ORDER.ToString("C"));
            else if ((userNum1 == cpuNum1 || userNum1 == cpuNum2 || userNum1 == cpuNum3) &&
                     (userNum2 == cpuNum1 || userNum2 == cpuNum2 || userNum2 == cpuNum3) &&
                     (userNum3 == cpuNum1 || userNum3 == cpuNum2 || userNum3 == cpuNum3))
                WriteLine("Congratulations, you won {0}!", THREE_MATCH_RANDOM.ToString("C"));
            else if (((userNum1 == cpuNum1 || userNum1 == cpuNum2 || userNum1 == cpuNum3) &&
                     (userNum2 == cpuNum1 || userNum2 == cpuNum2 || userNum2 == cpuNum3)) ||
                     ((userNum1 == cpuNum1 || userNum1 == cpuNum2 || userNum1 == cpuNum3) &&
                     (userNum3 == cpuNum1 || userNum3 == cpuNum2 || userNum3 == cpuNum3)) ||
                     ((userNum2 == cpuNum1 || userNum2 == cpuNum2 || userNum2 == cpuNum3) &&
                     (userNum3 == cpuNum1 || userNum3 == cpuNum2 || userNum3 == cpuNum3)))
                WriteLine("Congratulations, you won {0}!", TWO_MATCH.ToString("C"));
            else if ((userNum1 == cpuNum1 || userNum1 == cpuNum2 || userNum1 == cpuNum3) ||
                     (userNum2 == cpuNum1 || userNum2 == cpuNum2 || userNum2 == cpuNum3) ||
                     (userNum3 == cpuNum1 || userNum3 == cpuNum2 || userNum3 == cpuNum3))
                WriteLine("Congratulations, you won {0}!", ONE_MATCH.ToString("C"));
            else
                WriteLine("Sorry.  You won {0}.  Better luck next time.", NO_MATCH.ToString("C"));
        }

        static void Main(string[] args)
        {
            byte userSelection;  //variable for the user to enter a menu selection

            //create a menu for the user to select a program to run
            WriteLine("Chapter 4 Menu");
            WriteLine("1:\tCheckCredit()");
            WriteLine("2:\tTwitter()");
            WriteLine("3:\tAdmission()");
            WriteLine("4:\tHurricane()");
            WriteLine("5:\tCheckMonth()");
            WriteLine("6:\tCheckDigit()");
            WriteLine("7:\tGuessingGame()");
            WriteLine("8:\tRockPaperScissors()");
            WriteLine("9:\tLottery()");
            Write("Make a selection >> ");

            //accept user selection and convert to a byte
            userSelection = Convert.ToByte(ReadLine());

            //switch structure to determine which method to run based on userSelection
            switch (userSelection)
            {
                case 1:
                    CheckCredit();
                    break;
                case 2:
                    Twitter();
                    break;
                case 3:
                    Admission();
                    break;
                case 4:
                    Hurricane();
                    break;
                case 5:
                    CheckMonth();
                    break;
                case 6:
                    CheckDigit();
                    break;
                case 7:
                    GuessingGame();
                    break;
                case 8:
                    RockPaperScissors();
                    break;
                case 9:
                    Lottery();
                    break;
            }
        }
    }
}