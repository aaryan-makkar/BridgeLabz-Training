using Email_Campaign_Engagement_Analyzer;
namespace Email_Analyzer_Testing;

[TestFixture]
public class EventParserTests
{
    private EventParser parser;
    [SetUp]
    public void Setup()
    {
        parser = new EventParser();
    }

    [Test]
    public void Parse_ExtractsCorrectEventType()
    {
        string record =
            "EVENT:open|" +
            "CAMPAIGN:summer-sale-2026|" +
            "USER:sarah.jones+promo@mail-example.co.uk|" +
            "TS:2026-08-11T09:03:00|" +
            "DEVICE:mobile";

        Event result = parser.Parse(record);

        Assert.That(result.EventType, Is.EqualTo("open"));
    }
    [Test]
    public void Parse_ExtractsCorrectCampaign()
    {
        string record =
            "EVENT:open|" +
            "CAMPAIGN:summer-sale-2026|" +
            "USER:sarah.jones+promo@mail-example.co.uk|" +
            "TS:2026-08-11T09:03:00|" +
            "DEVICE:mobile";

        Event result = parser.Parse(record);

        Assert.That(result.Campaign, Is.EqualTo("summer-sale-2026"));
    }
    [Test]
    public void Parse_ExtractsCorrectEmail()
    {
        string record =
            "EVENT:open|" +
            "CAMPAIGN:summer-sale-2026|" +
            "USER:sarah.jones+promo@mail-example.co.uk|" +
            "TS:2026-08-11T09:03:00|" +
            "DEVICE:mobile";

        Event result = parser.Parse(record);

        Assert.That(result.UserEmail, Is.EqualTo("sarah.jones+promo@mail-example.co.uk"));
    }

    [Test]
    public void Parse_ExtractsCorrectDevice()
    {
        string record =
            "EVENT:open|" +
            "CAMPAIGN:summer-sale-2026|" +
            "USER:sarah.jones+promo@mail-example.co.uk|" +
            "TS:2026-08-11T09:03:00|" +
            "DEVICE:mobile";

        Event result = parser.Parse(record);

        Assert.That(result.Device, Is.EqualTo("mobile"));
    }

    [Test]
    public void Parse_ExtractsCorrectTimestamp()
    {
        string record =
            "EVENT:open|" +
            "CAMPAIGN:summer-sale-2026|" +
            "USER:sarah.jones+promo@mail-example.co.uk|" +
            "TS:2026-08-11T09:03:00|" +
            "DEVICE:mobile";

        Event result = parser.Parse(record);

        DateTime expected =
            new DateTime(2026, 8, 11, 9, 3, 0);

        Assert.That(result.Timestamp, Is.EqualTo(expected));
    }
}
