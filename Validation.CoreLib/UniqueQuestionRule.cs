// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;

using Validation.CoreLib.Core;

public class Question
{
    public string Text { get; set; }
}

public class UniqueQuestionRule : IValidationRule<Question[]>
{
    public ValidationResult Validate(Question[] questions)
    {
        var result = new ValidationResult();
        if (questions == null || questions.Length == 0)
        {
            result.AddError("Список вопрос пуст или равен null");
            return result;
        }


        var allUniqueQuestions = questions
            .Where(q => q != null && !string.IsNullOrWhiteSpace(q.Text))
            .Select(q => q.Text.Trim())
            .GroupBy(t => t)
            .All(g => g.Count() == 1);
        if (!allUniqueQuestions)
        {
            result.AddError("в билете присутсвуют уже использованные вопросы");
        }

        return result;
    }
}
