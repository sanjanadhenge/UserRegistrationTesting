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
        public void GivenName_WhenAnalyze_ShouldReturnValid()
        {
            string name = "Sanjana";
            User user = new User();
            string result = user.ValidateFirstName(name);
            Assert.AreEqual(result,"valid");
        }
    }
}