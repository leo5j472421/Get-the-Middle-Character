using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void GetMiddleTest()
        {
            Assert.AreEqual("es", Kata.GetMiddle2("test"));
            Assert.AreEqual("t", Kata.GetMiddle2("testing"));
            Assert.AreEqual("dd", Kata.GetMiddle2("middle"));
            Assert.AreEqual("A", Kata.GetMiddle2("A"));
        }
    }
}