namespace Test;

public class ExamPaperTests
{
    [Fact]
    public void Constructor_WithNumberAndQuestions_CreatesExamPaper()
    {
        var number = "EXAM-001";
        var questions = new List<Question>
        {
            new Question("Question 1", new TypeQuestion("Multiple Choice")),
            new Question("Question 2", new TypeQuestion("Essay"))
        };
        
        var examPaper = new ExamPaper(number, questions);

        Assert.Equal(number, examPaper.Number);
        Assert.Equal(questions, examPaper.Questions);
    }
    
    [Fact]
    public void GetNumber_ReturnsExamNumber()
    {

        var examPaper = new ExamPaper("EXAM-2024-001", new List<Question>());
        
        var number = examPaper.Number();
        
        Assert.Equal("EXAM-2024-001", number);
    }
    
    [Fact]
    public void GetQuestions_ReturnsQuestionsList()
    {

        var questions = new List<Question>
        {
            new Question("Q1", new TypeQuestion("Multiple Choice")),
            new Question("Q2", new TypeQuestion("True/False"))
        };
        var examPaper = new ExamPaper("EXAM-001", questions);
        
        var returnedQuestions = examPaper.Questions();
        
        Assert.Equal(questions, returnedQuestions);
        Assert.Equal(2, returnedQuestions.Count);
    }
    
}