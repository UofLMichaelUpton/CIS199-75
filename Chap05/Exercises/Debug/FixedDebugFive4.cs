// How much money will you have
// after 30 days if you get a penny on the
// first day and it doubles every day?
using System;
using static System.Console;
class DebugFive4
{
   static void Main()
   {
      const double LIMIT = 1000000.00,
                   START = 0.01;
      double total = START;
      int howMany,
          count = 0;

      WriteLine("How many days do you think it will take you to reach");
      WriteLine($"{LIMIT:c} starting with {START:c}");
      WriteLine("and doubling it every day?");
      howMany = int.Parse(ReadLine());

      while(total < LIMIT)
      {
         total *= 2;
         count++; 
      }

      if(howMany >= count)
         WriteLine("Your guess was too high.");
      else if(howMany <= count)
         WriteLine("Your guess was too low.");
      else
         WriteLine("Your guess was correct.");

      WriteLine($"It takes {count} days to reach {LIMIT:c}");
      WriteLine($"when you double {START:c} every day");
   }
}

