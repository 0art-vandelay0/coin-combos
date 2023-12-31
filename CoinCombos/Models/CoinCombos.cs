using System;

namespace CoinCombos
{
    public class CoinCombo
    {
        public int Cents { get; set; }
        public int Quarters { get; set; }
        public int Dimes { get; set; }
        public int Nickels { get; set; }
        public int Pennies { get; set; }

        public CoinCombo(int cents)
        {
            Cents = cents;
        }
    }

    public class CalculateCoins
    {
        public static CoinCombo CalculateSmallestCoins(int cents)
        {
            CoinCombo coinCombo = new CoinCombo(cents);

            coinCombo.Quarters = cents / 25;
            cents = cents % 25;

            coinCombo.Dimes = cents / 10;
            cents = cents % 10;

            coinCombo.Nickels = cents / 5;
            cents = cents % 5;

            coinCombo.Pennies = cents;

            return coinCombo;
        }
    }
}