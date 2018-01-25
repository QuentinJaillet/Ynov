using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YnovTdd.Tests
{
    [TestClass]
    public class FlipFlopShould
    {
        private FlipFlop _flipFlop;

        [TestInitialize]
        public void Init()
        {
            _flipFlop = new FlipFlop();
        }

        [TestMethod]
        public void Return1IfNumberIs1()
        {
            var result = _flipFlop.Show(1, 1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void Return2IfNumberIs2()
        {
            var result = _flipFlop.Show(2, 2);

            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void ReturnFlipIfNumberIs3()
        {
            var result = _flipFlop.Show(3, 3);

            Assert.AreEqual("Flip", result);
        }

        [TestMethod]
        public void ReturnFlipIfNumberIs6()
        {
            var result = _flipFlop.Show(6, 6);

            Assert.AreEqual("Flip", result);
        }

        [TestMethod]
        public void RetuneFlopIfNumberIs5()
        {
            var result = _flipFlop.Show(5, 5);

            Assert.AreEqual("Flop", result);
        }

        [TestMethod]
        public void ReturnFlopIFNumberIs10()
        {
            var result = _flipFlop.Show(10, 10);

            Assert.AreEqual("Flop", result);
        }

        [TestMethod]
        public void ReturnFlipFlopIfNumberIs15()
        {
            var result = _flipFlop.Show(15, 15);

            Assert.AreEqual("FlipFlop", result);
        }

        [TestMethod]
        public void ReturnFlipFlopIfNumberIs30()
        {
            var result = _flipFlop.Show(30, 30);

            Assert.AreEqual("FlipFlop", result);
        }

        [TestMethod]
        public void Return12IfNumbersIs1To2()
        {
            var result = _flipFlop.Show(1, 2);

            Assert.AreEqual("12", result);
        }

        [TestMethod]
        public void Return12FlipIfNumberIs1To3()
        {
            var result = _flipFlop.Show(1, 3);

            Assert.AreEqual("12Flip", result);
        }

        [TestMethod]
        public void Return12Flip4FlopIfNumberIs1To5()
        {
            var result = _flipFlop.Show(1, 5);

            Assert.AreEqual("12Flip4Flop", result);
        }
    }
}
