namespace Test;

public class QuestionTests
{
    [Fact]
    public void Constructor_ShouldSet_QuestionValue()
    {
        var questionValue = "What is your name?";
        var type = new TypeQuestion("Open question", "Answer in free form");
        
        var question = new Question(questionValue, type);
        
        Assert.Equal(questionValue, question.QuestionValue);
    }
    
    [Fact]
    public void Constructor_ShouldSet_TypeReference()
    {
        var questionValue = "How old are you?";
        var type = new TypeQuestion("Numeric", "Number is expected");
        
        var question = new Question(questionValue, type);
        
        Assert.Same(type, question.Type);
    }
    
    [Fact]
    public void Properties_ShouldBeAccessible_AfterInitialization()
    {
        var type = new TypeQuestion("Text", null);

        var question = new Question("Question text", type);

        Assert.Equal("Question text", question.QuestionValue);
        Assert.Same(type, question.Type);
    }
}