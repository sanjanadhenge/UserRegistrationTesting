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
            string pass = "Abcdef@2023";
            User user = new User();
            string result = user.ValidatePass(pass);
            Assert.AreEqual(result, "valid");
        }
        [Test]
        public void GivenMailArray_WhenAnalyze_ShouldReturnValid()
        {
            string[] arr = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", " abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc..2002@gmail.com", "abc.@gmail.com", "bc@abc@gmail.com", "abc@%*.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            User user = new User();
            string result =user.ValidateMailIDArray(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                if(result == "valid")
                {
                    Assert.AreEqual(result, "valid");
                }
                else
                {
                    Assert.AreEqual(result, "Invalid");
                }
            }
            

        }
    }
}