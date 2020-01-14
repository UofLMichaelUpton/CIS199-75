/* Grading ID: S6889
   Assignment: Lab 1
   Due Date: 19 Jan 2020
   CIS199-75
   Description: Simple console program to display 4 lines of text */


using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* I have a background in C and C++ so I still find
               it more efficient and cleaner to use a single console
               output expression using escape characters.  I'm using a 
               single WriteLine expression then concactenating each line 
               to the next line which does represent the next line of the
               console output.  Each line begins with the \n escape
               character.  I then use the \t escape character after the
               : to keep the spacing the same on each line without the 
               need for counting out spaces.  Again, I feel it's cleaner
               this way */
            WriteLine("Grading ID:\tS6889" +
                      "\nHobbies:\tRunning and playing music" +
                      "\nFavorite Book:\tInfinite Jest" +
                      "\nFavorite Movie:\tToo many to choose just one");
        }
    }
}
