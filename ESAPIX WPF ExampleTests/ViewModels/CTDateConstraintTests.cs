using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void ConstraintCTDateFailsTest()
        {
            //ARRANGE
            var oldDate = DateTime.Now.AddDays(-61);
            //ACT
            var actual = new CTDateConstraint().ConstraintCTDate(oldDate).ResultType;
            //ASSERT
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConstraintCTDatePassedTest()
        {
            //ARRANGE
            var newDate = DateTime.Now.AddDays(-59);
            //ACT
            var actual = new CTDateConstraint().ConstraintCTDate(newDate).ResultType;
            //ASSERT
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, actual);
        }
    }
}