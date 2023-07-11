using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombos;
using System;

namespace CoinCombos.Tests
{
    [TestClass]
    public class CoinComboTests
    {
        [TestMethod]
        public void CoinComboConstructor_CreatesInstanceOfCoinCombo_CoinCombo()
        {
            CoinCombo newCoinCombo = new CoinCombo(55);
            Assert.AreEqual(typeof(CoinCombo), newCoinCombo.GetType());
        }

        [TestMethod]
        public void CoinComboConstructor_CreatesInstanceOfCoinComboWithCentsProperty_Int55()
        {
            CoinCombo newCoinCombo = new CoinCombo(55);
            Assert.AreEqual(55, newCoinCombo.Cents);
        }

        [TestMethod]
        public void CalculateSmallestCoins_ReturnsCoinComboWithQuarters_Int2()
        {
            CoinCombo newCoinCombo = new CoinCombo(55);
            CoinCombo result = CalculateCoins.CalculateSmallestCoins(newCoinCombo.Cents);
            Assert.AreEqual(2, result.Quarters);
        }

        [TestMethod]
        public void CalculateSmallestCoins_ReturnsCoinComboWithDimes_Int0()
        {
            CoinCombo newCoinCombo = new CoinCombo(56);
            CoinCombo result = CalculateCoins.CalculateSmallestCoins(newCoinCombo.Cents);
            Assert.AreEqual(0, result.Dimes);
        }

        [TestMethod]
        public void CalculateSmallestCoins_ReturnsCoinComboWithPennies_Int1()
        {
            CoinCombo newCoinCombo = new CoinCombo(56);
            CoinCombo result = CalculateCoins.CalculateSmallestCoins(newCoinCombo.Cents);
            Assert.AreEqual(1, result.Pennies);
        }

        [TestMethod]
        public void CalculateSmallestCoins_ReturnsCoinComboWithQuarters_Int3()
        {
            CoinCombo newCoinCombo = new CoinCombo(77);
            CoinCombo result = CalculateCoins.CalculateSmallestCoins(newCoinCombo.Cents);
            Assert.AreEqual(3, result.Quarters);
        }

        [TestMethod]
        public void CalculateSmallestCoins_ReturnsCoinComboWithNickels_Int1()
        {
            CoinCombo newCoinCombo = new CoinCombo(59);
            CoinCombo result = CalculateCoins.CalculateSmallestCoins(newCoinCombo.Cents);
            Assert.AreEqual(1, result.Nickels);
        }

        [TestMethod]
        public void CalculateSmallestCoins_ReturnsCoinComboWithAnyCoins_Int()
        {
            CoinCombo newCoinCombo = new CoinCombo(67);
            CoinCombo result = CalculateCoins.CalculateSmallestCoins(newCoinCombo.Cents);
            Assert.AreEqual(2, result.Quarters);
            Assert.AreEqual(1, result.Dimes);
            Assert.AreEqual(1, result.Nickels);
            Assert.AreEqual(2, result.Pennies);
        }
    }
}