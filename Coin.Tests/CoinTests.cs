
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin;
namespace Coin.Tests
{
  [TestClass]
  public class CoinTest
  {
    [TestMethod]
    public void CoinOutputQuarters()
    {
      CoinCounter TestCounter = new CoinCounter();
      Assert.AreEqual("HELLO", TestCounter.CoinTest(99));
    // }
    // [TestMethod]
    // public void CoinOutputDimes()
    // {
    //   CoinCounter TestCounter = new CoinCounter();
    //   Assert.AreEqual(13, TestCounter.CoinTest(12));
    // }
    // [TestMethod]
    // public void CoinOutputNickels()
    // {
    //   CoinCounter TestCounter = new CoinCounter();
    //   Assert.AreEqual(13, TestCounter.CoinTest(12));
    // }
    // [TestMethod]
    // public voiinOutputPennys()
    // {
    //   CoinCounter TestCounter = new CoinCounter();
    //   Assert.AreEqual(13, TestCounter.CoinTest(12));
    // }

  }
}
}
