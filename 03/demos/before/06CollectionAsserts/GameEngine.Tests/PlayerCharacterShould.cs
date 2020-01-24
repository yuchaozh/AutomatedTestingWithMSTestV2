using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace GameEngine.Tests
{
    [TestClass]
    public class PlayerCharacterShould
    {
        [TestMethod]
        public void BeInexperiencedWhenNew()
        {
            var sut = new PlayerCharacter();

            Assert.IsTrue(sut.IsNoob);
        }

        [TestMethod]
        public void NotHaveNickNameByDefault()
        {
            var sut = new PlayerCharacter();

            Assert.IsNull(sut.Nickname);            
        }

        [TestMethod]
        public void StartWithDefaultHealth()
        {
            var sut = new PlayerCharacter();

            Assert.AreEqual(100, sut.Health);
        }

        [TestMethod]
        public void TakeDamage()
        {
            var sut = new PlayerCharacter();

            sut.TakeDamage(1);

            Assert.AreEqual(99, sut.Health);
        }

        [TestMethod]
        public void TakeDamage_NotEqual()
        {
            var sut = new PlayerCharacter();

            sut.TakeDamage(1);

            Assert.AreNotEqual(100, sut.Health);
        }

        [TestMethod]
        public void IncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter();

            sut.Sleep(); // Expect increase between 1 to 100 inclusive

            Assert.IsTrue(sut.Health >= 101 && sut.Health <= 200);
        }


        [TestMethod]
        public void CalculateFullName()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.AreEqual("SARAH SMITH", sut.FullName, true);
        }

        [TestMethod]
        public void HaveFullNameStartingWithFirstName()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            //Assert.IsTrue(sut.FullName.StartsWith("Sarah"));

            StringAssert.StartsWith(sut.FullName, "Sarah");
        }

        [TestMethod]
        public void HaveFullNameEndingWithLastName()
        {
            var sut = new PlayerCharacter();

            sut.LastName = "Smith";

            StringAssert.EndsWith(sut.FullName, "Smith");
        }

        [TestMethod]
        public void CalculateFullName_SubstringAssertExample()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            StringAssert.Contains(sut.FullName, "ah Sm");
        }

        [TestMethod]
        public void CalculateFullNameWithTitleCase()
        {
            var sut = new PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            StringAssert.Matches(sut.FullName, new Regex("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
            //StringAssert.DoesNotMatch(sut.FullName, new Regex("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }

    }
}
