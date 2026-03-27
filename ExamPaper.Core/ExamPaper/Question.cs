namespace ExamPaper.Core.ExamPaper;

/// <summary>
/// Класс который используется в экзаменационном билете. Класс описывает сам вопрос
/// </summary>
public record Question
{
    /// <summary>
    /// Вопрос
    /// </summary>
    public string QuestionValue { get; init; }

    /// <summary>
    /// Описывает тип вопроса
    /// </summary>
    public TypeQuestion Type { get; init; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="questionValue">Вопрос</param>
    /// <param name="type">Тип вопроса</param>
    public Question(string questionValue, TypeQuestion type)
    {
        QuestionValue = questionValue;
        Type = type;
    }
}