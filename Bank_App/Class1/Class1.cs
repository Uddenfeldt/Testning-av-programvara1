using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ClassLibrary;

namespace UnitTestPres.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void CheckIfDebitWorks()
        {
            int balance = 500;
            int expectedBalance = 250;
            Converter converter = new Converter();
            int actualBalance = converter.Debit(balance);

            Assert.AreEqual(expectedBalance, actualBalance);
        }
        [Test]
        public void CheckIfCreditWorks()
        {
            int balance = 500;
            int expectedBalance = 1000;

            Converter converter = new Converter();
            int actualBalance = converter.Credit(balance);

            Assert.AreEqual(expectedBalance, actualBalance);
        }
        [Test]
        public void CheckSaldo()
        {
            int balance = 500;
            int expectedBalance = 500;

            Converter converter = new Converter();
            int actualBalance = converter.CheckSaldo(balance);

            Assert.AreEqual(expectedBalance, actualBalance);
        }
    }
}
