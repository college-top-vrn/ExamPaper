namespace Test;

public class ExamPaperFactoryTests
{
    [Fact]
    public void Constructor_WithValidOptions_CreatesFactory()
    {
        var options = new ExamPaperFactoryOptions(3);
        
        var factory = new ExamPaperFactory(options);
        
        Assert.NotNull(factory);
    }
    
    [Fact]
    public void AddQuestion_AddsQuestionToFactory()
    {
        var options = new ExamPaperFactoryOptions(5);
        var factory = new ExamPaperFactory(options);
        var question = new Question("Test question", new TypeQuestion("Multiple Choice"));
        
        factory.AddQuestion(question);
        var examPaper = factory.Create();
        
        Assert.Equal("Test question", examPaper.Questions()[0].Question());
    }
    
    [Fact]
    public void AddQuestions_AddsMultipleQuestionsToFactory()
    {
        var options = new ExamPaperFactoryOptions(5);
        var factory = new ExamPaperFactory(options);
        var questions = new List<Question>
        {
            new Question("Question 1", new TypeQuestion("Multiple Choice")),
            new Question("Question 2", new TypeQuestion("Essay")),
            new Question("Question 3", new TypeQuestion("True/False"))
        };
        
        factory.AddQuestions(questions);
        var examPaper = factory.Create();
        
        Assert.Equal(3, examPaper.Questions().Count);
    }
    
    [Fact]
    public void Create_WhenNoQuestions_ReturnsExamPaperWithEmptyQuestionsList()
    {
        var options = new ExamPaperFactoryOptions(3);
        var factory = new ExamPaperFactory(options);
        
        var examPaper = factory.Create();
        
        Assert.NotNull(examPaper.Questions());
        Assert.StartsWith("EXAM-", examPaper.Number());
    }
}