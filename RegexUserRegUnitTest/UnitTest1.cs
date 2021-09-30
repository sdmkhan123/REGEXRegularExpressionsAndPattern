using Microsoft.VisualStudio.TestTools.UnitTesting;
using REGEXRegularExpressionsAndPattern;

namespace RegexUserRegUnitTest.REGEXRegularExpressionsAndPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Saddam";
            bool result = ToCheckRegexPattern.validFirstName(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Khan";
            bool result = ToCheckRegexPattern.validLastName(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void MobileTest()
        {
            string mobile = "91 8965265302";
            bool result = ToCheckRegexPattern.validMobileNumber(mobile);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PasswordTest()
        {
            string password = "Sdmkha12@";
            bool result = ToCheckRegexPattern.validPassword(password);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailTest()
        {
            string email1 = "ahmadiqbal.a786@gmail.com";
            string email2 = "iqbal143@yahoo.com";
            string email3 = "abc.200@yahoo.com";
            string email4 = "abc-567@abc.com";
            string email5 = "abc200@abc.co.in";
            bool result = ToCheckRegexPattern.ValidateEmailAllRules(email1);
            bool result3 = ToCheckRegexPattern.ValidateEmailAllRules(email2);
            bool result4 = ToCheckRegexPattern.ValidateEmailAllRules(email3);
            bool result5 = ToCheckRegexPattern.ValidateEmailAllRules(email4);
            bool result2 = ToCheckRegexPattern.ValidateEmailAllRules(email5);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
        }
    }
}
