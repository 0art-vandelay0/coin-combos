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
        public void CoinComboConstructor_CreatesInstanceOfCoinComboWithCentsProperty_55()
        {
            CoinCombo newCoinCombo = new CoinCombo(55);
            Assert.AreEqual(55, newCoinCombo.Cents);
        }

        [TestMethod]
        public void CalculateSmallestCoins_ReturnsCoinComboWithQuarters_2()
        {
            CoinCombo newCoinCombo = new CoinCombo(55);
            CoinCombo result = CalculateCoins.CalculateSmallestCoins(newCoinCombo.Cents);
            Assert.AreEqual(2, result.Quarters);
        }
    }
}