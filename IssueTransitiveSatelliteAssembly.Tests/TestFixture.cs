using ICU4N.Impl;
using NUnit.Framework;
using System.Globalization;
using Assert = NUnit.Framework.Assert;

namespace IssueTransitiveSatelliteAssembly.Tests
{
    public class TestFixture
    {
        [Test]
        public void Test()
        {
            var rootCulture = typeof(ICUData).Assembly.GetSatelliteAssembly(CultureInfo.InvariantCulture);
            Assert.IsNotNull(rootCulture);
        }
    }
}
