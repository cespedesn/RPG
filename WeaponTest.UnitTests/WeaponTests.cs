using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WeaponTest.UnitTests
{
    [TestClass]
    public class WeaponTests
    {
        [TestMethod]
        public void Constructor_InitializesProperties()
        {

            //Arrange
            int id = 2;
            string name = "Sword";
            string namePlural = "Swords";
            int minDamage = 10;
            int maxDamage = 20;

            //Act
            Weapon weapon = new Weapon(id, name, namePlural, minDamage, maxDamage);

            //Assert
            Assert.AreEqual(id, weapon.ID);
            Assert.AreEqual(name, weapon.Name);
            Assert.AreEqual(namePlural, weapon.NamePlural);
            Assert.AreEqual(minDamage, weapon.MinimumDamage);
            Assert.AreEqual(maxDamage, weapon.MaximumDamage);

        }
    }
}
