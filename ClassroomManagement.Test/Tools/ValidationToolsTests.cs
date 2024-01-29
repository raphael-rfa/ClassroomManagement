using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassroomManagement.Domain.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomManagement.Domain.Exceptions;

namespace ClassroomManagement.Domain.Tools.Tests
{
    [TestClass()]
    public class ValidationToolsTests
    {
        [TestMethod()]
        public void ShouldReturnErroWhenStringIsInvalid()
        {
            Action act = () => "".ThrowIfNullOrEmpty("");

            Assert.ThrowsException<IsNullOrEmptyException>(act);
        }

        [TestMethod()]
        public void ThrowIfNullOrEmpty_ShouldReturnErrorWhenStringIsNull()
        {
            Action act = () => ValidationTools.ThrowIfNullOrEmpty(null, "paramName");
            Assert.ThrowsException<IsNullOrEmptyException>(act);
        }

        [TestMethod()]
        public void ThrowIfNullOrEmpty_ShouldReturnErrorWhenStringIsWhiteSpace()
        {
            Action act = () => "   ".ThrowIfNullOrEmpty("paramName");
            Assert.ThrowsException<IsNullOrEmptyException>(act);
        }

        [TestMethod()]
        public void ThrowIfNullOrEmpty_ShouldReturnErrorWithCorrectParameterName()
        {
            Action act = () => ValidationTools.ThrowIfNullOrEmpty("", "differentParamName");
            var exception = Assert.ThrowsException<IsNullOrEmptyException>(act);
            Assert.AreEqual("differentParamName", exception.ParamName);
        }

        [TestMethod()]
        public void ThrowIfNullOrEmpty_ShouldReturnSuccessWhenStringIsValid()
        {
            Assert.AreEqual("A", "A".ThrowIfNullOrEmpty("nameof"));
        }

        [TestMethod()]
        public void ThrowIfEqualZero_ShouldReturnErrorWhenValueIsZero()
        {
            Action act = () => ValidationTools.ThrowIfEqualZero(0,"Valor é zero");
            Assert.ThrowsException<EqualZeroException>(act);
        }

        [TestMethod()]
        public void ThrowIfEqualZero_ShouldReturnSucessWhenValueIsNotEqualZero()
        {
            Assert.AreEqual(1,ValidationTools.ThrowIfEqualZero(1, "Valor é zero"));
        }
    }
}