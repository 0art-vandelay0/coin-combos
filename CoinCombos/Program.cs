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
            Console.WriteLine(coinChange.Cents);

            CoinCombo result = CalculateCoins.CalculateSmallestCoins(coinChange.Cents);

            Console.WriteLine("Quarters: " + result.Quarters);
            Console.WriteLine("Dimes: " + result.Dimes);
            Console.WriteLine("Nickels: " + result.Nickels);
            Console.WriteLine("Pennies: " + result.Pennies);
        }
    }
}