namespace DataRowTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class tests
    {
        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = true;

            Assert.IsFalse(result, "1 should not be prime");
        }

    }
}
