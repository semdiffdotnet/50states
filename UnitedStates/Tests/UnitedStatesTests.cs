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

        [TestMethod]
        public void VerifyAllHaveNomenclature()
        {
            foreach (var bird in UnitedStates.UnitedStates.Instance.States.Select(s => s.Bird))
            {
                Assert.IsFalse(string.IsNullOrWhiteSpace(bird.BinomialNomenclature));
            }

            foreach (var flower in UnitedStates.UnitedStates.Instance.States.Select(s => s.Flower))
            {
                Assert.IsFalse(string.IsNullOrWhiteSpace(flower.BinomialNomenclature));
            }
        }
    }
}