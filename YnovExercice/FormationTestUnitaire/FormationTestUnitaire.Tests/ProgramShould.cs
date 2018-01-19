using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormationTestUnitaire.Tests
{


    [TestClass]
    public class ProgramShould
    {
        private FlipFlop _program;
        private WindowsTest _windowsTest;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            _windowsTest = new WindowsTest();

            _program = new FlipFlop(_windowsTest);
        }

        [TestMethod]
        public void ReturnEmptyIfValueIsZero()
        {
            // Act
            _program.Process(0);

            // Assert
            Assert.AreEqual(string.Empty, _windowsTest.Message);
        }

        [TestMethod]
        public void ReturnFlipIfModulo3()
        {
            // Act
            _program.Process(3);

            // Assert
            Assert.AreEqual("Flip", _windowsTest.Message);
        }

        [TestMethod]
        public void ReturnFlopIfModulo5()
        {
            // Act
            _program.Process(5);

            // Assert
            Assert.AreEqual("Flop", _windowsTest.Message);
        }

        [TestMethod]
        public void ReturnFlipFlopIfModulo3And5()
        {
            // Act
            _program.Process(15);

            // Assert
            Assert.AreEqual("FlipFlop", _windowsTest.Message);
        }

        [TestMethod]
        public void ReturnNumber()
        {
            // Act
            _program.Process(4);

            // Assert
            Assert.AreEqual("4", _windowsTest.Message);
        }
    }
}
