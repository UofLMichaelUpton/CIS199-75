// Program asks user to enter a stock number
// If the stock number is not 209, 312, or 414 the user must reneter the number
// The program displays the correct price
using static System.Console;
class DebugFive2
{
   static void Main()
   {
      const int ITEM209 = 209,
                ITEM312 = 312,
                ITEM414 = 414;
      const double PRICE209 = 12.99, 
                   PRICE312 = 16.77, 
                   PRICE414 = 109.07;
      double price = 0.0;
      int stockNum;
      Write("Please enter the stock number of the item you want ");
      stockNum = int.Parse(ReadLine());
      while ((stockNum != ITEM209) && (stockNum != ITEM312) && (stockNum != ITEM414))
      {
         WriteLine("Invalid stock number. Please enter again. ");
         stockNum = int.Parse(ReadLine());
      }
      if(stockNum == ITEM209)
         price = PRICE209;
      else if(stockNum == ITEM312)
         price = PRICE312;
      else if(stockNum == ITEM414)
         price = PRICE414;
      WriteLine($"The price for item #{stockNum} is {price:c}.");
   }
}
