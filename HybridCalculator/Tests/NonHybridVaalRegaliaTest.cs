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
        public void NonHybridRegaliaFlatESTier1()
        {
            //Arrange
            Regalia item = new Regalia();
            int flatES = 140;
            int expected = 145;
            //Act
            //int actual = item.FlatTiers(flatES);
            //Assert
            //Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NonHybridRegaliaHasStun()
        {
            //Arrange

            var item = new Regalia();
            var menu = new MainMenu();
            //int flatES = 140;
            //int maxFlatES = item.FlatTiers(flatES);
            string stunChoice = "n";
            menu.HasStunRecovery(stunChoice);
            bool expected = false;
            //Act
            bool actual = item.Hybrid;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
