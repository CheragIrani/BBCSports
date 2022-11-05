using System;
using BBCWebsite.Tests.TestData;
using NUnit.Framework;

namespace BBCWebsite.Tests.TestCase
{
    public class TottenhamFixturesTestCase : TestSetup
    {
        [Test, TestCaseSource(typeof(TestData.TottenhamFixturesTestData), "testData") ]
        public void RunTestcase()
        {

        }

        [TearDown]
        public void TeardowTestcase()
        {
            _driver.Close();
        }
    }
}
