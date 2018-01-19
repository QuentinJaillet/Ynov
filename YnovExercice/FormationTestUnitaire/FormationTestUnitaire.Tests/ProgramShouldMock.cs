using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FormationTestUnitaire.Tests
{
    [TestClass]
    public class ProgramShouldMock
    {
        private FlipFlop _program;
        private Mock<IWindows> _windowsTest;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            _windowsTest = new Mock<IWindows>(MockBehavior.Strict);
            _windowsTest.Setup(s => s.Show(It.IsAny<string>()));

            _program = new FlipFlop(_windowsTest.Object);
        }

        [TestMethod]
        public void ReturnEmptyIfValueIsZero()
        {
            // Act
            _program.Process(0);

            // Assert
            _windowsTest.Verify(s => s.Show(string.Empty));


        }
        
        [TestMethod]
        public void ReturnFlipIfModulo3()
        {

            // Act
            _program.Process(3);

            // Assert
            _windowsTest.Verify(s => s.Show("Flip"));
        }
        /*
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
        }*/
    }
}
