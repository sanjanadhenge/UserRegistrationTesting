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
    }
}