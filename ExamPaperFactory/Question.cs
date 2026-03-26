namespace ExamPaperFactory;

public class Question
{
    public string _question { get; init; }
    public TypeQuestion _type { get; init; }

    public Question(string question, TypeQuestion type)
    {
        _question = question;
        _type = type;
    }
}