using System;
using NUnit.Framework;

namespace TopologicalSorting.Test
{
    [TestFixture]
    public class TopologicalTest
    {
        [Test]
        public void BoolPraseTest()
        {
            bool actived = true;
            bool.TryParse(string.Empty, out actived);
            Assert.AreEqual(false,actived);
            bool.TryParse(null, out actived);
            Assert.AreEqual(false, actived);
        }
    }
}
