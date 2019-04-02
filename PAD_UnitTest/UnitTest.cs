using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PAD_Solution;

namespace PAD_UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestString()
        {
            Console.WriteLine("This is a simple message test");
            Assert.AreEqual("Message", Program.CreateMessage());
        }
        [TestMethod]
        public void TestInt()
        {
            Console.WriteLine("This is a simple addition test");
            Assert.AreEqual(30, Program.Sum(10,20));
        }
        [TestMethod]
        public void TestBool()
        {
            Console.WriteLine("This is a simple boolean test");
            Assert.IsFalse(Program.IsPrime(1));
            Assert.IsTrue(Program.IsPrime(2));
        }
    }
}
