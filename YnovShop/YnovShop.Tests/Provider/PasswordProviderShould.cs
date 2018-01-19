using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YnovShop.Provider;

namespace YnovShop.Tests.Provider
{
    [TestClass]
    public class PasswordProviderShould
    {
        private string aSalt = "e9JSJlNC59pZqTkaeutJQ4Bd91DUQdCi";
        private string aPassword = "Azerty123_";
        private string aPasswordHash = "G/sRJetRHql+HbzlKCHUh26R6n+++l72";

        [TestMethod]
        public void ReturnEvenHash()
        {
            // Arrange
            var provider = new PasswordProvider();
            var salt = Convert.FromBase64String(aSalt);

            // Act
            var passwordHashResult = provider.PasswordHash(aPassword, salt);

            // Assert
            Assert.AreEqual(aPasswordHash, Convert.ToBase64String(passwordHashResult));
        }

    }
}
