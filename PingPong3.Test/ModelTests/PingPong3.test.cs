using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Tests 
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void Count_ReturnGivenNumberAsString_string()
    {
      Assert.AreEqual("1", PingPong.Count(1));
    }
    [TestMethod]
    public void Count_NumberDividedby3_Ping()
    {
      Assert.AreEqual("Ping", PingPong.Count(6));
    }
    [TestMethod]
    public void Count_NumberDividedby5_Pong()
    {
      Assert.AreEqual("Pong", PingPong.Count(10));
    }
    [TestMethod]
    public void Count_NumberDividedby5and3_PingPong()
    {
      Assert.AreEqual("Ping-Pong", PingPong.Count(15));
    }
  }
}