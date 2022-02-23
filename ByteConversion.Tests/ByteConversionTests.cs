using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rakesh_Gundu_MT;

namespace ByteConversion.Tests
{
    public class ByteConversionTests
    {
        [Test]
        public void ConvertGigabytesToMegabytesTest1()
        {
            var GB = 1;
            double result = Rakesh_Gundu_MT.ByteConversion.GigabytesToMegabytes(GB);
            Assert.AreEqual(1024, result);
        }
        [Test]
        public void ConvertMegabytesToBytesTest1()
        {
            var MB = 2;
            double result = Rakesh_Gundu_MT.ByteConversion.MegabytesToBytes(MB);
            Assert.AreEqual(2097152, result);
        }
        [Test]
        public void ConvertTerabytesToGigabytes()
        {
            var TB = 10;
            double result = Rakesh_Gundu_MT.ByteConversion.GigabytesToMegabytes(TB);
            Assert.AreEqual(10240, result);
        }
    }
}
