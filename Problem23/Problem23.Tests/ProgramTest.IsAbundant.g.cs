using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="ProgramTest.IsAbundant.g.cs">Copyright �  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Problem23
{
    public partial class ProgramTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(ProgramTest))]
        public void IsAbundant11()
        {
            bool b;
            b = this.IsAbundant(11);
            Assert.AreEqual<bool>(false, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(ProgramTest))]
        public void IsAbundant12()
        {
            bool b;
            b = this.IsAbundant(12);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(ProgramTest))]
        public void IsAbundant28()
        {
            bool b;
            b = this.IsAbundant(28);
            Assert.AreEqual<bool>(false, b);
        }
    }
}
