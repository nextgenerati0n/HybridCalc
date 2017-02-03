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
        public void IncreasedEsTierTest()
        {
            //Arrange
            var item = new Regalia();
            item.IncEs = 125;
            ArmourRepository.RetrieveIncEs(item);
            var expected = 1;
            //Act
            var actual = item.IncEsTier;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FlatEsTierTest()
        {
            //Arrange
            var item = new Regalia();
            item.FlatEs = 125;
            ArmourRepository.RetrieveFlatEs(item);
            var expected = 2;
            //Act
            var actual = item.FlatEsTier;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

