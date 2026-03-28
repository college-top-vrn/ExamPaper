using System.Collections.Generic;

namespace ExamPaper.Core.ExamPaper;

/// <summary>
/// Класс экзаменационный лист
/// </summary>
public class ExamPaper
{
    /// <summary>
    /// Номер билета
    /// </summary>
    public string Number { get; }

    /// <summary>
    /// Список вопросов (неизменяемая коллекция)
    /// </summary>
    public IReadOnlyList<Question> Questions { get; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="number">Номер</param>
    /// <param name="questions">Список вопросов</param>
    public ExamPaper(string number, List<Question> questions)
    {
        Number = number;
        Questions = questions?.ToList().AsReadOnly()
                    ?? throw new ArgumentNullException(nameof(questions), "Список вопросов не может быть null");
    }
}