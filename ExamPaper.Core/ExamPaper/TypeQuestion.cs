namespace ExamPaper.Core.ExamPaper;

/// <summary>
/// Класс отвечающий за тип вопроса
/// </summary>
public record TypeQuestion
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Описывает тип вопроса
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Конструктор инициализирующий объекты
    /// </summary>
    /// <param name="name">Имя</param>
    /// <param name="description">Описывает тип вопроса</param>
    public TypeQuestion(string name, string? description)
    {
        Name = name;
        Description = description;
    }
}