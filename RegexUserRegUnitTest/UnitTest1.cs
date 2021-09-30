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
            try
            {
                bool result =ToCheckRegexPattern.validFirstName(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid First name of the user", ex.Message);
            }
        }
        [TestMethod]
        public void LastNameTest()
        {
            try
            {
                bool result = ToCheckRegexPattern.validLastName(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid Last name of the user", ex.Message);
            }
        }
        [TestMethod]
        public void validEmailIdTest()
        {
            try
            {
                bool result = ToCheckRegexPattern.validEmailID(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid Email-Id of the user", ex.Message);
            }
        }
        [TestMethod]
        public void MobileTest()
        {
            try
            {
                bool result = ToCheckRegexPattern.validMobileNumber(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid Mobile Nummber of the user", ex.Message);
            }
        }
        [TestMethod]
        public void PasswordTest()
        {
            try
            {
                bool result = ToCheckRegexPattern.validPassword(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Password of the user is : Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void EmailTest()
        {
            try
            {
                bool result = ToCheckRegexPattern.ValidateEmailAllRules(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Email Id of user is : invalid", ex.Message);
            }
        }
    }
}