using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassroomManagement.Domain.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagement.Domain.Tools.Tests
{
    [TestClass()]
    public class ValidationToolsTests
    {
        [TestMethod()]
        public void ShouldReturnErroWhenStringIsInvalid()
        {
            Action act = () => "".ThrowIfNullOrEmpty("");

            Assert.ThrowsException<ArgumentNullException>(act);
        }

        [TestMethod()]
        public void ThrowIfNullOrEmpty_ShouldReturnErrorWhenStringIsNull()
        {
            Action act = () => ValidationTools.ThrowIfNullOrEmpty(null, "paramName");
            Assert.ThrowsException<ArgumentNullException>(act);
        }

        [TestMethod()]
        public void ThrowIfNullOrEmpty_ShouldReturnErrorWhenStringIsWhiteSpace()
        {
            Action act = () => "   ".ThrowIfNullOrEmpty("paramName");
            Assert.ThrowsException<ArgumentNullException>(act);
        }

        [TestMethod()]
        public void ThrowIfNullOrEmpty_ShouldReturnErrorWithCorrectParameterName()
        {
            Action act = () => ValidationTools.ThrowIfNullOrEmpty("", "differentParamName");
            var exception = Assert.ThrowsException<ArgumentNullException>(act);
            Assert.AreEqual("differentParamName", exception.ParamName);
        }

        [TestMethod()]
        public void ThrowIfNullOrEmpty_ShouldReturnSuccessWhenStringIsValid()
        {
            Assert.AreEqual("A", "A".ThrowIfNullOrEmpty("nameof"));
        }
    }
}