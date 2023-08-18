using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ItemTest.UnitTests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void Constructor_InitializesProperties()
        {

            //Arange
            int id = 1;
            string name = "Sword";
            string namePlural = "Swords";

            //Act
            Item item = new Item(id, name, namePlural);

            //Assert
            Assert.AreEqual(id, item.ID);
            Assert.AreEqual(name, item.Name);
            Assert.AreEqual(namePlural, item.NamePlural);

        }
    }
}
