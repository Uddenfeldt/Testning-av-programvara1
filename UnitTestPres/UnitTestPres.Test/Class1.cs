using System;
using NUnit.Framework;
using ClassLibrary;

namespace UnitTestPres.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Converter_From_Int_1_To_String1()
        {
            // Arrange (prepare test case with the attributes required)
            int input = 1;
            string expectedOutput = "1";

            // Act(perform the test case and get the actualOutput)
            Converter convert = new Converter();
            string actualOutput = convert.converter(input);

            //assert(check output
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
