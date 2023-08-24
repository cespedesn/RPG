using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PlayerQuestTest.UnitTests
{
    [TestClass]
    public class PlayerQuestTest
    {
        [TestMethod]
        public void Constructor_InitializesProperties()
        {

            //Arrange
            //Create instance of Quest to be used as an argument in PlayerQuest constructor
            Quest questDetails = new Quest(1, "Clear the alchemist's garden", "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);
            bool isCompleted = false;

            //Act
            PlayerQuest playerQuest = new PlayerQuest(questDetails, isCompleted);

            //Assert
            Assert.AreEqual(questDetails, playerQuest.Details);
            Assert.AreEqual(isCompleted, playerQuest.IsCompleted);

        }
    }
}
