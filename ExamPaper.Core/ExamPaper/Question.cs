namespace ExamPaper.Core.ExamPaper;

public class Question
{
    public string _Question { get; init; }
    public TypeQuestion _type { get; init; }

    public Question(string question, TypeQuestion type)
    {
        _Question = question;
        _type = type;
    }
}