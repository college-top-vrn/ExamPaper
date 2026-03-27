namespace ExamPaper.Core.ExamPaper;

public class ExamPaperFactory
{
    public ExamPaperFactoryOption Options { get; }
    public List<Question> Questions { get; }

    public ExamPaperFactory(ExamPaperFactoryOption options)
    {
        Options = options;
    }

    public ExamPaper Create()
    {
        return new ExamPaper(Options.QuantityQuestion, Questions);
    }
}