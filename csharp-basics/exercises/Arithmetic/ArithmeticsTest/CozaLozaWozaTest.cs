using System;
using CozaLozaWoza;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArithmeticsTest
{
    [TestClass]
    public class CozaLozaWozaTest
    {
        private CozaLoza _target = new CozaLoza();

        [TestMethod]
        public void DetermineCozaLozaWoza_3_Coza()
        {
            Assert.AreEqual("Coza", _target.DetermineCozaLozaWoza(3));
        }

        [TestMethod]
        public void DetermineCozaLozaWoza_5_Loza()
        {
            Assert.AreEqual("Loza", _target.DetermineCozaLozaWoza(5));
        }

        [TestMethod]
        public void DetermineCozaLozaWoza_7_Woza()
        {
            Assert.AreEqual("Woza", _target.DetermineCozaLozaWoza(7));
        }

        [TestMethod]
        public void DetermineCozaLozaWoza_3_5_CozaLoza()
        {
            Assert.AreEqual("CozaLoza", _target.DetermineCozaLozaWoza(15));
        }

        [TestMethod]
        public void DetermineCozaLozaWoza_3_7_CozaWoza()
        {
            Assert.AreEqual("CozaWoza", _target.DetermineCozaLozaWoza(21));
        }

        [TestMethod]
        public void DetermineCozaLozaWoza_5_7_LozaWoza()
        {
            Assert.AreEqual("LozaWoza", _target.DetermineCozaLozaWoza(35));
        }

        [TestMethod]
        public void DetermineCozaLozaWoza_4_Returns4()
        {
            Assert.AreEqual("4", _target.DetermineCozaLozaWoza(4));
        }

        [TestMethod]
        public void DetermineCozaLozaWoza_34_Returns34()
        {
            Assert.AreEqual("34", _target.DetermineCozaLozaWoza(34));
        }
    }
}
