
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortudoFeliz;

namespace NumeroSortudoFelizTest
{
    [TestClass]
    public class TestFelizSortudo
    {

        [TestMethod]
        public void CompararNumeroFelizTest()
        {
            Assert.AreEqual(true, NumeroFeliz.CompararNumeroFeliz(7));
            Assert.AreEqual(false, NumeroFeliz.CompararNumeroFeliz(21));
            Assert.AreEqual(true, NumeroFeliz.CompararNumeroFeliz(28));
            Assert.AreEqual(false, NumeroFeliz.CompararNumeroFeliz(142));
            Assert.AreEqual(false, NumeroFeliz.CompararNumeroFeliz(37));
            Assert.AreEqual(true, NumeroFeliz.CompararNumeroFeliz(100));
        }
        [TestMethod]
        public void CompararNumeroSortudoTest()
        {
            Assert.AreEqual(true, NumeroSortudo.Sortudo(7));
            Assert.AreEqual(true, NumeroSortudo.Sortudo(21));
            Assert.AreEqual(false, NumeroSortudo.Sortudo(28));
            Assert.AreEqual(false, NumeroSortudo.Sortudo(142));
            Assert.AreEqual(true, NumeroSortudo.Sortudo(37));
            Assert.AreEqual(false, NumeroSortudo.Sortudo(100));
        }
    }
}
