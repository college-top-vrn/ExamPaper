using Validation.CoreLib.Core;

namespace Validation.CoreLib.QuestionRules;

public class Quiestion
{
    public string Text { get; set; }
    public object Type { get; set; }
   
}


public class QuestionHasTypeRule : IValidationRule<Question>
{
    public ValidationResult Validate(Question item)
    {
        var result = new ValidationResult();
        if (item is null)
        {
            result.AddError("Вопрос пустой");
        }
        if (item. is null)
    }
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