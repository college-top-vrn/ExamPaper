namespace ExamPaper.Core.ExamPaper;

/// <summary>
/// Класс параметров для фабрики экзаменационных билетов
/// Определяет настройки генерации такие как количество вопросов
/// </summary>
public class ExamPaperFactoryOption
{
    /// <summary>
    /// Количество вопросов
    /// </summary>
    public int QuantityQuestion { get; }

    /// <summary>
    /// Конструктор инициализирующий объекты
    /// </summary>
    /// <param name="quantityQuestion">Количество вопросов</param>
    public ExamPaperFactoryOption(int quantityQuestion) { QuantityQuestion = quantityQuestion; }
}