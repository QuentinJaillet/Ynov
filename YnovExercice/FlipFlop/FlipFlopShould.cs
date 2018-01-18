using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormationTestUnitaire.Tests
{
    [TestClass]
    public class FlipFlopShould
    {
        private FlipFlop _program;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            _program = new FlipFlop();
        }

        [TestMethod]
        public void ReturnEmptyIfValueIsZero()
        {
            // Act
            var result = _program.Process(0);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ReturnFlipIfModulo3()
        {
            // Act
            var result = _program.Process(3);

            // Assert
            Assert.AreEqual("Flip", result);
        }

        [TestMethod]
        public void ReturnFlopIfModulo5()
        {
            // Act
            var result = _program.Process(5);

            // Assert
            Assert.AreEqual("Flop", result);
        }

        [TestMethod]
        public void ReturnFlipFlopIfModulo3And5()
        {
            // Act
            var result = _program.Process(15);

            // Assert
            Assert.AreEqual("FlipFlop", result);
        }

        [TestMethod]
        public void ReturnNumber()
        {
            // Act
            var result = _program.Process(4);

            // Assert
            Assert.AreEqual("4", result);
        }
    }
}
