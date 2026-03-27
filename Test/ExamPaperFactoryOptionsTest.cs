namespace Test;

public class ExamPaperFactoryOptionsTest
{
    [Fact]
    public void Constructor_SetsQuantityQuestionsCorrectly()
    {
        const int expectedQuantity = 10;

        var options = new ExamPaperFactoryOptions(expectedQuantity);

        Assert.Equal(expectedQuantity, options.QuantityQuestions);
    }
}