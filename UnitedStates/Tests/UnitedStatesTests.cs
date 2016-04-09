using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class UnitedStatesTests
    {
        [TestMethod]
        public void Are50States()
        {
            Assert.AreEqual(50, UnitedStates.UnitedStates.Instance.Count());
        }

        [TestMethod]
        public void GetStatesWithSameCapitalAndLargestCity()
        {
            var normalstates = UnitedStates.UnitedStates.Instance.States.Where(s => s.Capital == s.LargestCity).ToList();
            Assert.AreEqual(17, normalstates.Count);
        }
    }
}