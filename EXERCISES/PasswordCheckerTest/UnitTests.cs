using PasswordCheckerNET6;

namespace PasswordCheckerTest
{
    public class Tests
    {
        private PasswordCheckerValidation _passValidate;

        [SetUp]
        public void Setup()
        {
            _passValidate = new PasswordCheckerValidation();
        }

        [Test]
        public void ValidatePasswordLINQ_PasswordKeyword_ReturnFalse()
        {
            string badPassword__password_keyword = "iAmAvERy!sECure123PAssWord!7";
            bool validationResult = _passValidate.ValidatePasswordLINQ(badPassword__password_keyword);
            Assert.IsFalse(validationResult, "Bad Password: contains password keyword");
        }

        [Test]
        public void ValidatePasswordLINQ_PassesAllCriteria_ReturnTrue()
        {
            string goodPassword = "iAmAvERy!sECure123!7";
            bool validationResult = _passValidate.ValidatePasswordLINQ(goodPassword);
            Assert.IsTrue(validationResult, "Good Password: passes all criteria");
        }
    }
}