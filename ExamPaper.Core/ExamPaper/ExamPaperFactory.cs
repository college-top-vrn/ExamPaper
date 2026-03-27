namespace ExamPaper.Core.ExamPaper;

/// <summary>
/// Класс фабрика по созданию билетов
/// </summary>
public class ExamPaperFactory
{
    /// <summary>
    /// Опция фабрики
    /// </summary>
    public ExamPaperFactoryOption Options { get; }
    /// <summary>
    /// Список вопросов
    /// </summary>
    public List<Question> Questions { get; }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="options">Опция фабрики</param>
    public ExamPaperFactory(ExamPaperFactoryOption options)
    {
        Options = options;
    }
    /// <summary>
    /// Метод создания билета
    /// </summary>
    /// <returns>Новый эекзаменационный билет</returns>
    public ExamPaper Create()
    {
        return new ExamPaper(Options.QuantityQuestion, Questions);
    }
}