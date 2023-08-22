using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HealingPotionTest.UnitTests
{
    [TestClass]
    public class HealingPotionTests
    {
        [TestMethod]
        public void Constructor_InitializerProperties()
        {

            //Arrange
            int id = 1;
            string name = "Health Potion";
            string namePlural = "Health Potions";
            int amountToHeal = 25;

            //Act
            HealingPotion potion = new HealingPotion(id, name, namePlural, amountToHeal);

            //Assert
            Assert.AreEqual(id, potion.ID);
            Assert.AreEqual(name, potion.Name);
            Assert.AreEqual(namePlural, potion.NamePlural);
            Assert.AreEqual(amountToHeal, potion.AmountToHeal);

        }
    }
}
