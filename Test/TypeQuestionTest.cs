using ExamPaper;

namespace Test;

public class TypeQuestionTest
{
    [Fact]
    public void Constructor_WithOnlyName_CreatesTypeQuestion()
    {
        var typeQuestion = new TypeQuestion("Multiple Choice", null);

        Assert.Equal("Multiple Choice", typeQuestion.Name);
    }

    [Fact]
    public void Constructor_WithOnlyDecsprition_CreatesTypeQuestion()
    {
        var typeQuestion = new TypeQuestion("Multiple Choice", "No Comments");

        Assert.Equal("No Comments", typeQuestion.Description);
    }

    [Fact]
    public void Constructor_WithOnlyDecspritionNull_CreatesTypeQuestion()
    {
        var typeQuestion = new TypeQuestion("Multiple Choice", null);

        Assert.Null(typeQuestion.Description);
    }

    [Theory]
    [InlineData("Single Choice", "Single answer question")]
    [InlineData("True/False", null)]
    [InlineData("Matching", "Match items from two columns")]
    [InlineData("Essay", "Long form answer")]
    [InlineData("Rating", "Rate on a scale")]
    public void Constructor_VariousValidInputs_SetsPropertiesCorrectly(string name, string? description)
    {
        var typeQuestion = new TypeQuestion(name, description);

        Assert.Equal(name, typeQuestion.Name);
        Assert.Equal(description, typeQuestion.Description);
    }
}