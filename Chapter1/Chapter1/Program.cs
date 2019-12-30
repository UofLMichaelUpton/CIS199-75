/* Michael Upton
 * CIS199-75
 * Spring 2020 */

using System;
using static System.Console;

namespace MainSolution
{
    class Chapter1
    {
        //interchapter exercise
        public static void HelloWorld()
        {
            WriteLine("Hello World!");
        }

        //Exercise 4
        public static void PersonalInfo()
        {
            WriteLine("Name: John Doe");
            WriteLine("DOB: 6 April 1957");
            WriteLine("Work Phone: 502-734-6375");
            WriteLine("Cell Phone: 502-648-2854");
        }

        //Exercise 5
        public static void Lyrics()
        {
            WriteLine("All the years combine");
            WriteLine("They melt into a dream");
            WriteLine("A broken angel sings");
            WriteLine("From a guitar");
        }

        //Exercise 6
        public static void Comments()
        {
            //this is a single line comment
            /* this is a
               block
               comment */
            WriteLine("A single line comment begins with // and there is no ending.");
            WriteLine("A block comment begins with /* and ends with */.");
        }

        //Exercise 7
        public static void StopSign()
        {
            WriteLine("   XXXXXX   ");
            WriteLine(" X        X ");
            WriteLine("X   STOP   X");
            WriteLine(" X        X ");
            WriteLine("   XXXXXX   ");
            WriteLine("      X     ");
            WriteLine("      X     ");
            WriteLine("      X     ");

        }

        //Exercise 8
        public static void BigLetter()
        {
            WriteLine("M          M");
            WriteLine("MM        MM");
            WriteLine("M M      M M");
            WriteLine("M  M    M  M");
            WriteLine("M   M  M   M");
            WriteLine("M    MM    M");
            WriteLine("M          M");
            WriteLine("M          M");
            WriteLine("M          M");
        }

        //Exercise 9
        public static void BurmaShave()
        {
            WriteLine("Drinking drivers--");
            WriteLine("Nothing worse");
            WriteLine("They put");
            WriteLine("The quart");
            WriteLine("Before the hearse");
            WriteLine("Burma Shave");

        }

        //Main method that will use a switch to execute all other methods
        public static void Main(string[] args)
        {
            int userChoice;  //variable for user's menu choice

            //display a menu to the user to make a selection
            WriteLine("1: HelloWorld");
            WriteLine("2: PersonalInfo");
            WriteLine("3: Lyrics");
            WriteLine("4: Comments");
            WriteLine("5: StopSign");
            WriteLine("6: BigLetter");
            WriteLine("7: BurmaShave");

            //ask the user to make a selection
            WriteLine("Make a selection on which program to view:");

            //Read the user's selection as userChoice
            userChoice = Convert.ToInt32(ReadLine());

            //switch structure for user choice
            switch (userChoice)
            {
                case 1:
                    HelloWorld();
                    break;

                case 2:
                    PersonalInfo();
                    break;

                case 3:
                    Lyrics();
                    break;

                case 4:
                    Comments();
                    break;

                case 5:
                    StopSign();
                    break;

                case 6:
                    BigLetter();
                    break;

                case 7:
                    BurmaShave();
                    break;
            }
        }
    }
}