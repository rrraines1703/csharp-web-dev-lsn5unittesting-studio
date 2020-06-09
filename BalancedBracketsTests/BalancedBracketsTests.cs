using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        //Test 1
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //Test 2
        [TestMethod]
        public void EmptyStingReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //Test 3
        [TestMethod]
        public void OnlyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        //Test 4
        [TestMethod]
        public void NonBalancedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        //Test 5
        [TestMethod]
        public void missingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        //Test 6
        [TestMethod]
        public void singleOpenBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        //Test 7
        [TestMethod]
        public void singleClosedBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        //Test 8
        [TestMethod]
        public void reversedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        //Test 9
        [TestMethod]
        public void bracketsInMiddleReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        //Test 10
        [TestMethod]
        public void bracketsAtBegginingReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        //Test 11
        [TestMethod]
        public void bracketsAtEndReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode[]"));
        }

        //Test 12
        [TestMethod]
        public void balancedBracketsInBracketsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        //Test 13
        [TestMethod]
        public void nonbalancedBracketsInBracketsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][]["));
        }

    }
}
