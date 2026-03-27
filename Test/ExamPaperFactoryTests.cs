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
    public void Create_WhenNoQuestions_ReturnsExamPaperWithEmptyQuestionsList()
    {
        var options = new ExamPaperFactoryOptions(3);
        var factory = new ExamPaperFactory(options);

        var examPaper = factory.Create();

        Assert.NotNull(examPaper.Questions());
        Assert.NotEmpty(examPaper.Number());
    }

    [Fact]
    public void Factory_Create_ExamPaper()
    {
        var options = new ExamPaperFactoryOptions(2);

        var multipleChoiceType = new TypeQuestion("Multiple Choice", "Select one answer");
        var essayType = new TypeQuestion("Essay", "Write detailed answer");

        var question1 = new Question("What is 2+2?", multipleChoiceType);
        var question2 = new Question("Explain dependency injection", essayType);
        var question3 = new Question("What is SOLID?", essayType);

        var questions = new List<Question> { question1, question2, question3 };

        string expectedNumber = "EXAM-001";
        var expectedExamPaper = new ExamPaper(expectedNumber, questions);

        var actualNumber = expectedExamPaper.Number();
        var actualQuestions = expectedExamPaper.Questions();

        Assert.Equal(expectedNumber, actualNumber);
        Assert.NotNull(actualQuestions);
        Assert.Equal(3, actualQuestions.Count);

        Assert.Equal(question1.Question(), actualQuestions[0].Question());
        Assert.Equal(question2.Question(), actualQuestions[1].Question());
        Assert.Equal(question3.Question(), actualQuestions[2].Question());

        Assert.Equal("Multiple Choice", actualQuestions[0].Type().Name());
        Assert.Equal("Essay", actualQuestions[1].Type().Name());
        Assert.Equal("Essay", actualQuestions[2].Type().Name());
    }
}