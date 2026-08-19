using Email_Campaign_Engagement_Analyzer;
namespace Email_Analyzer_Testing
{
    [TestFixture]
    public class EmailValidatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsValid_PlusTaggedEmail_ReturnsTrue()
        {
            string email =
                "sarah.jones+promo@mail-example.co.uk";

            bool result = EmailValidator.IsValid(email);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_MultiLevelDomain_ReturnsTrue()
        {
            string email = "user@company.co.in";

            bool result = EmailValidator.IsValid(email);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsValid_EmailMissingAt_ReturnsFalse()
        {
            string email =
                "sarah.jonesmail-example.co.uk";

            bool result = EmailValidator.IsValid(email);

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsValid_TrailingDotDomain_ReturnsFalse()
        {
            string email = "user@example.com.";

            bool result = EmailValidator.IsValid(email);

            Assert.That(result, Is.False);
        }
    }
}
