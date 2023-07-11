using System;
using CoinCombos;

namespace CoinCombos
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Coin Change Calculator");

            Console.WriteLine("Enter the amount of cents: ");
            int cents = Convert.ToInt32(Console.ReadLine());

            CoinCombo coinChange = new CoinCombo(cents);

            // Console.WriteLine("Smallest number of coins needed:");
            // Console.WriteLine($"Quarters: {coinChange.Quarters}");
            // Console.WriteLine($"Dimes: {coinChange.Dimes}");
            // Console.WriteLine($"Nickels: {coinChange.Nickels}");
            // Console.WriteLine($"Pennies: {coinChange.Pennies}");

            // Console.ReadLine();
        }
    }
}