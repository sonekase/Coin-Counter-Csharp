using System;

namespace Coin
{
  public class CoinCounter
  {
    public string CoinTest(int amount)
    {
      int counter = amount;
      int quarters = 0;
      int dimes = 0;
      int nickels = 0;
      int pennys = 0;

      if (counter / 25 > 0)
      {
        quarters += 1;
        counter -= 25;
      }
      else
      {
        counter -= 0;
      }
      /////
      if (counter / 25 > 0)
      {
        quarters += 1;
        counter -= 25;
      }
      else
      {
        counter -= 0;
      }
      ////
      if (counter / 25 > 0)
      {
        quarters += 1;
        counter -= 25;;
      }
      else
      {
        counter -= 0;
      }
      ////
      if (counter / 25 > 0)
      {
        quarters += 1;
        counter -= 25;
      }
      else
      {
        counter -= 0;
      }
      /////
      /////
      ////
      if (counter / 10 > 0)
      {
        dimes += 1;
        counter -= 10;
      }
      else
      {
        counter -= 0;
      }
      ///
      if (counter / 10 > 0)
      {
        dimes += 1;
        counter -= 10;
      }
      else
      {
        counter -= 0;
      }
      ///

      /////
      ////
      ////
      if (counter / 5 > 0)
      {
        nickels += 1;
        counter -= 5;
      }
      else
      {
        counter -= 0;
      }
      ///
      ///
      ///

      if (counter / 1 > 0)
      {
        pennys += 1;
        counter -= 1;
      }
      else
      {
        counter -= 0;
      }
      //
      if (counter / 1 > 0)
      {
        pennys += 1;
        counter -= 1;
      }
      else
      {
        counter -= 0;
      }
      //
      if (counter / 1 > 0)
      {
        pennys += 1;
        counter -= 1;
      }
      else
      {
        counter -= 0;
      }
      ///
      if (counter / 1 > 0)
      {
        pennys += 1;
        counter -= 1;
      }
      else
      {
        counter -= 0;
      }
      ///
      if (counter / 1 > 0)
      {
        pennys += 1;
        counter -= 1;
      }
      else
      {
        counter -= 0;
      }

      string quarterOut = quarters.ToString();
      string dimeOut = dimes.ToString();
      string nickelOut = nickels.ToString();
      string pennyOut = pennys.ToString();

      return "Quarters: " + quarterOut + ", Dimes: " + dimeOut + ", Nickels: " + nickelOut + ", Pennies: " + pennyOut;

    }
  }

  class CoinCounterApp
    {
      static void Main()
      {
        CoinCounter TestCounter = new CoinCounter();
        Console.WriteLine (" Please Enter Amount");
        string amountString = Console.ReadLine();
        int amountInt = int.Parse(amountString);
        Console.WriteLine(TestCounter.CoinTest(amountInt));
        Console.WriteLine(" Would you like to enter another number? Y/N");
        string newEntry = Console.ReadLine();
        if(newEntry == "Y" || newEntry == "y")
        {
          Main();
        }
      }
    }



}
