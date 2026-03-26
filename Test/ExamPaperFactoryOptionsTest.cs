namespace Test;

public class ExamPaperFactoryOptionsTest
{
    [Fact]
    public void Constructor_SetsQuantityQuestionsCorrectly()
    {
        // Arrange
        const int expectedQuantity = 10;

        // Act
        var options = new ExamPaperFactoryOptions(expectedQuantity);

        // Assert
        Assert.Equal(expectedQuantity, options.QuantityQuestions);
    }

}