using NUnit.Framework;
using Calculate;

namespace App.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddition()
        {
            var cal=new DoCalculate();
            var result=cal.DoOperation(2,5,"+");
            Assert.AreEqual(7,result);
        }
        [Test]
        public void TestSubtraction()
        {
            var cal=new DoCalculate();
            var result=cal.DoOperation(5,2,"-");
            Assert.AreEqual(3,result);
        }
        [Test]
        public void TestMultiplication()
        {
            var cal=new DoCalculate();
            var result=cal.DoOperation(2,5,"*");
            Assert.AreEqual(10,result);
        }
        [Test]
        public void TestDivision()
        {
            var cal=new DoCalculate();
            var result=cal.DoOperation(5,2,"/");
            Assert.AreEqual(2.5d,result);
        }
    }
}