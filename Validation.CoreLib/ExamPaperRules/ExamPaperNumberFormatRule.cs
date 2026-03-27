namespace Validation.CoreLib.ExamPaperRules;

using System.Text.RegularExpressions;

public class ExamPaperNumberFormatRule
{
    private static readonly Regex NumberRegex = new(@"^Билет №\d+$", RegexOptions.Compiled);

    public bool IsValid(string number) => !string.IsNullOrEmpty(number) && NumberRegex.IsMatch(number);
}