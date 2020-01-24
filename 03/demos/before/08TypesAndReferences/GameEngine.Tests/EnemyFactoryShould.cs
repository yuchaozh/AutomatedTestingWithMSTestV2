using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameEngine.Tests
{
    [TestClass]
    public class EnemyFactoryShould
    {
        [TestMethod]
        public void NotAllowNullName()
        {
            EnemyFactory sut = new EnemyFactory();

            Assert.ThrowsException<ArgumentNullException>(
                () => sut.Create(null)
                );
        }

        [TestMethod]
        public void OnlyAllowKingOrQueenBossEnemies()
        {
            EnemyFactory sut = new EnemyFactory();

            EnemyCreationException ex = Assert.ThrowsException<EnemyCreationException>(
                () => sut.Create("Zombie", true));

            Assert.AreEqual("Zombie", ex.RequestedEnemyName);
        }
    }
}
