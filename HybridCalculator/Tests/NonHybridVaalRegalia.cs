using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator.Tests
{
    [TestClass]
    public class ChestTests
    {
        [TestMethod]
        public void NonHybridRegaliaFlatES()
        {
            //Arrange
            Regalia item = new Regalia();
            int flatES = 140;
            int expected = 145;
            //Act
            int actual = item.FlatTiers(flatES);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NonHybridRegaliaHasStun()
        {
            //Arrange
            Regalia item = new Regalia();
            int flatES = 140;
            int maxFlatES = item.FlatTiers(flatES);
            string stunChoice = "n";
            bool expected = false;
            //Act
            bool actual = MainMenu.HasStunRecovery(stunChoice);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
