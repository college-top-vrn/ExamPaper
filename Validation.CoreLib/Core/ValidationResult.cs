using System.Collections.Generic;
using System.Linq;

namespace Validation.CoreLib.Core;

/// <summary>
/// Представляет результат выполнения проверки (валидации).
/// </summary>5
public class ValidationResult
{
    /// <summary>
    /// Список найденных ошибок. Если список пуст, валидация пройдена успешно.
    /// </summary>
    public List<string> Errors { get; } = [];


    /// <summary>
    /// Возвращает true, если объект успешно прошел проверку (нет ошибок).
    /// </summary>
    public bool IsValid => !Errors.Any();


    /// <summary>
    /// Добавляет ошибку в список ошибок.
    /// </summary>
    /// <param name="error"></param>
    public void AddError(string error)
    {
        if (!string.IsNullOrWhiteSpace(error))
        {
            Errors.Add(error);
        }
    }


    /// <summary>
    /// Добавляет коллекцию ошибок в список результатов.
    /// </summary>
    /// <param name="errors">Коллекция текстов ошибок.</param>
    public void AddErrors(IEnumerable<string>? errors)
    {
        if (errors is not null) Errors.AddRange(errors);
    }
}