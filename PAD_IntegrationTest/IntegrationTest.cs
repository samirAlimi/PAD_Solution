using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PAD_Solution;

namespace PAD_IntegrationTest
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void TestMysql1()
        {
            Console.WriteLine("This is a simple mysql's reading test");
            string sql = "SELECT `name` FROM `candidates` WHERE `id`=1";
            string column = "name";
            Assert.AreEqual("AMEGAN Laureen", Program.FirstId(column, sql));
        }
        [TestMethod]
        public void TestMysql2()
        {
            Console.WriteLine("This is a simple mysql's reading test");
            string sql = "SELECT `vote` FROM `candidates` WHERE `id`=2";
            string column = "vote";
            Assert.AreEqual("0", Program.FirstId(column, sql));
        }
    }
}
