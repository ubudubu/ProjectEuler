// <copyright file="ProgramTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem26;

namespace Problem26
{
    [TestClass]
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProgramTest
    {
        [PexMethod]
        public string GetRecurringCycle(int a, int b)
        {
            string result = Program.GetRecurringCycle(a, b);
            return result;
            // TODO: add assertions to method ProgramTest.GetRecurringCycle(Int32, Int32)
        }
    }
}
