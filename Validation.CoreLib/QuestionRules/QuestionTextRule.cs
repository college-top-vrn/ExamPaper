namespace Validation.CoreLib.QuestionRules;

public class QuestionTextRule
{
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