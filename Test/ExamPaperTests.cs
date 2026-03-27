namespace Test;

public class ExamPaperTests
{
   
    [Fact]
    public void Constructor_Sets_Number_Correctly()
    {
        int expectedNumber = 42;
        var questions = new List<Question>();
        
        var examPaper = new ExamPaper(expectedNumber, questions);
        
        Assert.Equal(expectedNumber, examPaper.Number);
    }
    [Fact]
    public void Constructor_Sets_Questions_Correctly()
    {
        var question = new Question("What is 2+2?", TypeQuestion.Math);
        var expectedQuestions = new List<Question> { question };
        
        var examPaper = new ExamPaper(1, expectedQuestions);
        
        Assert.Equal(expectedQuestions.Count, examPaper.Questions.Count);
        Assert.Equal(expectedQuestions[0].QuestionValue, examPaper.Questions[0].QuestionValue);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(42)]
    [InlineData(100)]
    public void Constructor_Stores_Valid_Number(int number)
    {
        var examPaper = new ExamPaper(number, new List<Question>());
        
        Assert.Equal(number, examPaper.Number);
    }

    [Fact]
    public void Questions_List_Is_ReadOnly_After_Construction()
    {
        var questions = new List<Question> 
        { 
            new Question("Solve for x: 2x = 4", TypeQuestion.Math) 
        };
        var examPaper = new ExamPaper(1, questions);
        
        Assert.Same(questions, examPaper.Questions);
        Assert.Equal(1, examPaper.Questions.Count);
    }
}