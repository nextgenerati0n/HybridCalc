using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator.Tests
{
    [TestClass]
    public class SetPropertyTests
    {
        [TestMethod]
        public void FlatESTooLow()
        {
            //Arrange
            Regalia item = new Regalia();
            item.FlatES = 10;
            string expected = "It's garbage, go get some new armour";
            //Act
            string actual = ValidationHelpers.ValidationMessage;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FlatESTooHigh()
        {
            //Arrange
            Regalia item = new Regalia();
            item.FlatES = 160;
            string expected = "It's garbage, go get some new armour";
            //Act
            string actual = ValidationHelpers.ValidationMessage;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /*
        [TestMethod]
        public void FlatESTooLow()
        {
            //Arrange
            Regalia item = new Regalia();
            //Act
            try
            {
                item.FlatES = 10;
                Assert.Fail("This shouldn't be shown, because the above should have thrown an exception ! !");
            }
            //Assert
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentOutOfRangeException);
            }
        }
        [TestMethod]
        public void FlatESTooHigh()
        {
            //Arrange
            Regalia item = new Regalia();
            //Act
            try
            {
                item.FlatES = 160;
                Assert.Fail("This shouldn't be shown, because the above should have thrown an exception ! !");
            }
            //Assert
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentOutOfRangeException);
            }
        }
    */
    }
}
