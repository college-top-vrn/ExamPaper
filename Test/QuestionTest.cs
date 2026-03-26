namespace Test;

public class QuestionTest
{
    private readonly TypeQuestion _typeExample;

    public QuestionTests()
    {
        _typeExample = new TypeQuestion("MultipleChoice", "Вопрос с выбором ответа");
    }

    [Fact]
    public void Constructor_WhenValidDataPassed_ShouldSetQuestion()
    {
        // Arrange
        var expectedQuestionText = "Какой тип данных используется в C# для хранения целых чисел?";

        // Act
        var question = new Question(expectedQuestionText, _typeExample);

        // Assert
        Assert.Equal(expectedQuestionText, question.Question());
    }
    [Fact]
    public void Constructor_WhenValidDataPassed_ShouldSetQuestionType()
    {
        // Arrange
        var expectedQuestionText = "Какой тип данных используется в C# для хранения целых чисел?";

        // Act
        var question = new Question(expectedQuestionText, _typeExample);

        // Assert
        Assert.Same(_typeExample, question.Type());
    }

}