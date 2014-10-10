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
            Assert.AreEqual("3", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolverNegativeNumber()
        {
            op.Current = "-3";
            Assert.AreEqual("-3", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveAddTwoNumbers()
        {
            op.Current = "3+3";
            Assert.AreEqual("6", op.SolveBasic());
        } 

        [TestMethod]
        public void TestSolveAddThreeNumbers()
        {
            op.Current = "3+3+3";
            Assert.AreEqual("9", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveReductionTwoNumbers()
        {
            op.Current = "10-5";
            Assert.AreEqual("5", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveMultiplyTwoNumbers()
        {
            op.Current = "5x5";
            Assert.AreEqual("25", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveMultiplyMoreNumbers()
        {
            op.Current = "5x5x2x2";
            Assert.AreEqual("100", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveDevideTwoNumbers()
        {
            op.Current = "5/5";
            Assert.AreEqual("1", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolverDevideMoreNumbers()
        {
            op.Current = "25/5/5";
            Assert.AreEqual("1", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveReductionMoreNumbers()
        {
            op.Current = "20-5-5";
            Assert.AreEqual("10", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveThreeNumbersAndMulti()
        {
            op.Current = "3+3x3";
            Assert.AreEqual("12", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveThreeNumbersAndDiv()
        {
            op.Current = "3+3/3";
            Assert.AreEqual("4", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveThreeNumbersAndReduction()
        {
            op.Current = "3+3-3";
            Assert.AreEqual("3", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveThreeNumbersRedAndMulti()
        {
            op.Current = "4-3x3";
            Assert.AreEqual("3", op.SolveBasic());
        }

        [TestMethod]
        public void TestSolveThreeNumbersMultiAndAdd()
        {
            op.Current = "4*4+2";
            Assert.AreEqual("18", op.SolveBasic());
        }
    }
}
