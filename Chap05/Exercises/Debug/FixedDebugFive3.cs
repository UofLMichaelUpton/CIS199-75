// Program displays every possible ID number for a company
// ID number is a letter, followed by a two-digit number
// For example -- A00 or Z99
// Go to a new display line after every 20 IDs
using static System.Console;
class DebugFive3
{
   static void Main()
   {
      char letter;
      int number;
      const int LOW = 0;
      const int NUMINROW = 20;
      for(letter = 'A'; letter <= 'Z'; ++letter)
      {
        for(number = LOW; number <= NUMINROW; ++number)
        {
           Write($"{letter}{number:d2} ");
        }
        WriteLine();
      }
   }
}
