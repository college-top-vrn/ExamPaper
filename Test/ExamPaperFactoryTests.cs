namespace Test;

public class ExamPaperFactoryTests
{
    [Fact]
    public void Constructor_Stores_Options_Correctly()
    {
        var options = new ExamPaperFactoryOption(10);
        
        var factory = new ExamPaperFactory(options);
        
        Assert.Same(options, factory.Options);
    }

    [Fact]
    public void Create_Returns_ExamPaper_With_Correct_Number()
    {
        var options = new ExamPaperFactoryOption(5);
        var factory = new ExamPaperFactory(options);
        
        var examPaper = factory.Create();
        
        Assert.Equal(5, examPaper.Number);
    }
    
    [Fact]
    public void Create_Returns_ExamPaper_With_Empty_Questions_List()
    {
        // Arrange
        var options = new ExamPaperFactoryOption(3);
        var factory = new ExamPaperFactory(options);
        
        // Act
        var examPaper = factory.Create();
        
        // Assert
        Assert.NotNull(examPaper.Questions);
        Assert.Empty(examPaper.Questions);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    [InlineData(50)]
    public void Create_Uses_Options_QuantityQuestion(int quantity)
    {
        var options = new ExamPaperFactoryOption(quantity);
        var factory = new ExamPaperFactory(options);
        
        var examPaper = factory.Create();
        
        Assert.Equal(quantity, examPaper.Number);
    }
}