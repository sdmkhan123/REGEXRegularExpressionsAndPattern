using Microsoft.VisualStudio.TestTools.UnitTesting;
using REGEXRegularExpressionsAndPattern;
namespace RegexUserRegUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        ToCheckRegexPattern user = new ToCheckRegexPattern();
        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Saddam";
            bool result = user.validFirstName();
            Assert.AreEqual(true, result);

        }
    }
}
