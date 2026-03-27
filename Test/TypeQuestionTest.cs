namespace Test;

public class TypeQuestionTest
{
    [Fact]
    public void Constructor_WithOnlyName_CreatesTypeQuestion()
    {
        var typeQuestion = new TypeQuestion("Multiple Choice");

        Assert.Equal("Multiple Choice", typeQuestion.Name);
    }

    [Fact]
    public void Constructor_WithOnlyDecsprition_CreatesTypeQuestion()
    {
        var typeQuestion = new TypeQuestion("Multiple Choice", "No Comments");

        Assert.Equal("No Comments", typeQuestion.Descprition);
    }

    [Fact]
    public void Constructor_WithOnlyDecspritionNull_CreatesTypeQuestion()
    {
        var typeQuestion = new TypeQuestion("Multiple Choice");

        Assert.Null(typeQuestion.Descprition);
    }
}