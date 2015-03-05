// <copyright file="ProgramTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem24;

namespace Problem24
{
    [TestClass]
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProgramTest
    {
        [PexMethod]
        public int[] GetNextPermutation(int[] array)
        {
            int[] result = Program.GetNextPermutation(array);
            return result;
            // TODO: add assertions to method ProgramTest.GetNextPermutation(Int32[])
        }
    }
}
