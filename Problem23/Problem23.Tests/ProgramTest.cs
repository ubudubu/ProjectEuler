// <copyright file="ProgramTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem23;

namespace Problem23
{
    [TestClass]
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProgramTest
    {
        [PexMethod]
        public bool IsAbundant(int number)
        {
            bool result = Program.IsAbundant(number);
            return result;
            // TODO: add assertions to method ProgramTest.IsAbundant(Int32)
        }
    }
}
