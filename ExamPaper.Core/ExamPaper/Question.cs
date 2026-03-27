namespace ExamPaper.Core.ExamPaper;

public class Question
{
    public string QuestionValue { get; init; }
    public TypeQuestion Type { get; init; }

    public Question(string questionValue, TypeQuestion type)
    {
        QuestionValue = questionValue;
        Type = type;
    }
}