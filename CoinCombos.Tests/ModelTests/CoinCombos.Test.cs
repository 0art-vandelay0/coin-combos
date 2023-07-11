using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombos;

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
    }
}