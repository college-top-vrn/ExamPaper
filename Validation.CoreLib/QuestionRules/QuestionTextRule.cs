using Validation.CoreLib.Core;

namespace Validation.CoreLib.QuestionRules;

public class QuestionTextRule : IValidationRule<string>
{
    public ValidationResult Validate(string item)
    {
        var result = new ValidationResult();
        if (string.IsNullOrWhiteSpace(item))
        {
            result.AddError("Текст Вопроса не может быть пустым");

            return result;
        }

        if (item.Trim().Length < _minLength)
        {
            result.AddError($"Текст вопроса не соотвествует минимальной длине (минимум символов {_minLength})");
        }

        return result;
    }

    private readonly int _minLength;

    public QuestionTextRule(int minLength = 10)
    {
        _minLength = minLength;
    }

    public bool IsValid(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return false;

        text = text.Trim();
        return text.Length >= _minLength;
    }
}