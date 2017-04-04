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
            item.IncEsRoll = 125;
            AffixTier.RetrieveIncEs(item);
            var expected = 1;
            //Act
            var actual = item.AltIncEsTier;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FlatEsTierTest()
        {
            //Arrange
            var item = new Regalia();
            item.FlatEsRoll = 125;
            AffixTier.RetrieveFlatEs(item);
            var expected = 2;
            //Act
            var actual = item.FlatEsTier;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateHybridMaxMinIncEsTest()
        {
            //Arrange
            var item = new Regalia();
            item.IncEsRoll = 180;
            item.IsHybrid = true;
            item.MinFlatEs = 136;
            item.MaxFlatEs = 145;
            item.MinHybridEs = 51;
            item.MaxHybridEs = 56;
            item.IncEsFromHybrid();
            var expectedMax = 132;
            var expectedMin = 121;

            //Act
            var actualMax = item.MaxIncEs;
            var actualMin = item.MinIncEs;

            //Assert
            Assert.AreEqual(expectedMax, actualMax);
            Assert.AreEqual(expectedMin, actualMin);
        }
    }
}

