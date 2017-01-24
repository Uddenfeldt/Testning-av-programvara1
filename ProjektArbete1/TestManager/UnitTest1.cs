using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class TestManager
    {
        // 1. This is the first unit test. This test will output the first two
        // integers of the list.

        //[TestMethod]
        //public void TestCocaCola_ShouldReturnTwoIntegers()
        //{
        //    //Arrange
        //    var cocaCola = new CocaCola();
        //    var expected = new List<int> { "1", "2" };

        //    //Act
        //    var actual = cocaCola.GetCocaCola();

        //    //Assert
        //    CollectionAssert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void TestCocaCola_ShouldReturnTwoIntegers()
        {
            //Arrange
            var cocaCola = new CocaCola();
            var expected = new List<string> { "1", "2" };

            //Act
            var actual = cocaCola.GetCocaCola(2);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        // 2. This is the second unit test. This test wil output the first two
        // integers and "Coca" instead of 3. This won't compile so the first unit test will not compile now.The TestCocaCola_ShouldReturnTwoIntegers
        // has to be changed. The result of this is shown under this section.

        //[TestMethod]
        //public void TestCocaCola_ShouldReturnFirstThreeITems()
        //{
        //    //Arrange
        //    var cocaCola = new CocaCola();
        //    var expected = new List<string> { "1", "2", "Coca" };

        //    //Act
        //    var actual = cocaCola.GetCocaCola(3);

        //    //Assert
        //    CollectionAssert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void TestCocaCola_ShouldReturnFirstThreeITems()
        {
            //Arrange
            var cocaCola = new CocaCola();
            var expected = new List<string> { "1", "2", "Coca" };

            //Act
            var actual = cocaCola.GetCocaCola(3);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        // 3. The third test testes if the first 5 items are: "1", "2", "Coca", "4", "Cola". The test fails becuase
        // the output was "1", "2", "Coca", "4", "5". Therefor the GetCocaCola method needs to be rewrtitten.

        //[TestMethod]
        //public void TestCocaCola_ShouldReturnFirstFiveItems()
        //{
        //    //Arrange
        //    var cocaCola = new CocaCola();
        //    var expected = new List<string> { "1", "2", "Coca", "4", "Cola" };

        //    //Act
        //    var actual = cocaCola.GetCocaCola(5);

        //    //Assert
        //    CollectionAssert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void TestCocaCola_ShouldReturnFirstFiveItems()
        {
            //Arrange
            var cocaCola = new CocaCola();
            var expected = new List<string> { "1", "2", "Coca", "4", "Cola" };

            //Act
            var actual = cocaCola.GetCocaCola(5);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        // 4. The next test sees if we get "CocaCola" on 15, 30, 45, 60, 75 and 90. The test failed because
        // we got "Coca" instead of "CocaCola" on position 15. Therefore we had to change our 
        // GetNextCocaCola method. 

        [TestMethod]
        public void TestCocaCola_15thPosition_ShouldReturnCocaCola()
        {
            //Arrange
            var cocaCola = new CocaCola();
            var position = 15;
            var expected = "CocaCola";

            //Act
            var actualCocaColaList = cocaCola.GetCocaCola(position);
            var actual = actualCocaColaList.ElementAt(position - 1);
            // As list are 0 index based we need to acces the 14th item to get the correct

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // 5. This test checks if the output is "CocaCola" instead of 60.
        [TestMethod]
        public void TestCocaCola_60thPosition_ShouldReturnCocaCola()
        {
            //Arrange
            var cocaCola = new CocaCola();
            var position = 60;
            var expected = "CocaCola";

            //Act
            var actualCocaColaList = cocaCola.GetCocaCola(position);
            var actual = actualCocaColaList.ElementAt(position - 1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // 6. This test checks if the output is "CocaCola" instead of 75.
        [TestMethod]
        public void TestCocaCola_75thPosition_ShouldReturnCocaCola()
        {
            //Arrange
            var cocaCola = new CocaCola();
            var position = 75;
            var expected = "CocaCola";

            //Act
            var actualCocaColaList = cocaCola.GetCocaCola(position);
            var actual = actualCocaColaList.ElementAt(position - 1);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        // 7. This test checks if the final output is "Cola" instead of 100.

        [TestMethod]
        public void TestCocaCola_100thPosition_ShouldReturnCola()
        {
            //Arrange
            var cocaCola = new CocaCola();
            var position = 100;
            var expected = "Cola";

            //Act
            var actualCocaColaList = cocaCola.GetCocaCola(position);
            var actual = actualCocaColaList.ElementAt(position - 1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
    

