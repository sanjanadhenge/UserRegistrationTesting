using UserRegistration;

namespace UserTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFirstName_WhenAnalyze_ShouldReturnValid()
        {
            string name = "Sanjana";
            User user = new User();
            string result = user.ValidateFirstName(name);
            Assert.AreEqual(result,"valid");
        }
        [Test]
        public void GivenLastName_WhenAnalyze_ShouldReturnValid()
        {
            string name = "Dhenge";
            User user = new User();
            string result = user.ValidateLastName(name);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenMail_WhenAnalyze_ShouldReturnValid()
        {
            string mail = "abc.xyz@brizdgelabz.co.in";
            User user = new User();
            string result = user.ValidateMailID(mail);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenMobileNumber_WhenAnalyze_ShouldReturnValid()
        {
            string mobile = "9135624879";
            User user = new User();
            string result = user.ValidateMobile(mobile);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenPassword_WhenAnalyze_ShouldReturnValid()
        {
            string pass = "Abcdefg2023";
            User user = new User();
            string result = user.ValidatePass(pass);
            Assert.AreEqual(result, "valid");
        }
    }
}