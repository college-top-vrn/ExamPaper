namespace Validation.CoreLib.QuestionRules;

public class QuestionHasTypeRule
{
    public object Type { get; set; }
}

public class QuestionHasTypeRule
{
    public bool IsValid(Question question)
    {
        if (question is null)
            return;
        return question.Type is not null;
    }
}