using Validation.CoreLib.Core;

namespace Validation.CoreLib.ExamPaperRules;

using System.Text.RegularExpressions;

public class ExamPaperNumberFormatRule : IValidationRule<string>
{
    private static readonly Regex NumberRegex = new(@"^Билет №\d+$", RegexOptions.Compiled);

    public bool IsValid(string number) => !string.IsNullOrEmpty(number) && NumberRegex.IsMatch(number);


    public ValidationResult Validate(string item)
    {
        var result = new ValidationResult();
        if (string.IsNullOrEmpty(item) || !NumberRegex.IsMatch(item))
        {
            result.AddError("Неверный номер билета");
        }

        return result;
    }
}