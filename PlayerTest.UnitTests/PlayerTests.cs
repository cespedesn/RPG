using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PlayerTest.UnitTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Constructor_InitializesProperties()
        {

            //Arange. Where we initialize
            int currentHitPoints = 100;
            int maximumHitPoints = 100;
            int gold = 50;
            int experiencePoints = 0;
            int level = 1;


            //Act. Calling a method we are going to test. Dont forget to add reference
            Player player = new Player(currentHitPoints, maximumHitPoints, gold, experiencePoints, level);


            //Assert
            Assert.AreEqual(currentHitPoints, player.CurrentHitPoints);
            Assert.AreEqual(maximumHitPoints, player.MaximumHitPoints);
            Assert.AreEqual(gold, player.Gold);
            Assert.AreEqual(experiencePoints, player.ExperiencePoints);
            Assert.AreEqual(level, player.Level);


        }
    }
}
