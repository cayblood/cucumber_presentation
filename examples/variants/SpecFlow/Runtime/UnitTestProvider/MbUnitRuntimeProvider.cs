using System;

namespace TechTalk.SpecFlow.UnitTestProvider
{
    public class MbUnitRuntimeProvider : IUnitTestRuntimeProvider
    {
        private const string MSTEST_ASSEMBLY = "MbUnit";
        private const string ASSERT_TYPE = "MbUnit.Framework.Assert";

        private Action<string, object[]> assertInconclusive;

        #region IUnitTestRuntimeProvider Members

        public void TestInconclusive(string message)
        {
            if (assertInconclusive == null)
            {
                assertInconclusive = UnitTestRuntimeProviderHelper
                    .GetAssertMethodWithFormattedMessage(MSTEST_ASSEMBLY, ASSERT_TYPE, "Inconclusive");
            }

            assertInconclusive("{0}", new object[] { message });
        }

        public void TestIgnore(string message)
        {
            TestInconclusive(message); // there is no dynamic "Ignore" in mstest
        }

        public bool DelayedFixtureTearDown
        {
            get { return true; }
        }

        #endregion
    }
}