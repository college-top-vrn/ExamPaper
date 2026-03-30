namespace Test;

public class ExamPaperFactoryOptionsTest
{
    [Fact]
    public void Constructor_ShouldSet_QuantityQuestion()
    {
        int quantity = 10;

        var option = new ExamPaperFactoryOption(quantity);

        Assert.Equal(quantity, option.QuantityQuestion);
    }
}