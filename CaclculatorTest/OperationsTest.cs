using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaclculatorTest 
{
    [TestClass]
    public class OperationsTest
    {
        private Operations op;

        [TestInitialize]
        public void Initialize()
        {
            op = new Operations();
        }

        [TestMethod]
        public void TestAddToCurrent()
        {
            op.AddToCurrent("3", "3");
            Assert.AreEqual("33", op.Current);
        }

        [TestMethod]
        public void TestDeleteLast() 
        {
            op.Current = "100";
            op.DeleteLast();
            Assert.AreEqual("10", op.Current);
        }

        [TestMethod]
        public void TestClear()
        {
            op.Current = "123";
            op.Result = "345";
            op.Clear();
            Assert.AreEqual("", op.Current);
            Assert.AreEqual("0", op.Result);
        }

        [TestMethod]
        public void TestSolveOneNumber()
        {
            op.Current = "3";
            Assert.AreEqual("3", op.Solve());
        }

        [TestMethod]
        public void TestSolveAddTwoNumbers()
        {
            op.Current = "3+3";
            Assert.AreEqual("6", op.Solve());
        }
    }
}
