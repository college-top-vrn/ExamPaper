using System.Collections.Generic;


namespace Validation.CoreLib.Core;

/// <summary>
/// Представляет результат выполнения проверки (валидации).
/// </summary>
public class ValidationResult
{
    /// <summary>
    /// Список найденных ошибок. Если список пуст, валидация пройдена успешно.
    /// </summary>
    public List<string> Errors { get; } = [];
    
    
    /// <summary>
    /// Указывает, пройдена ли валидация успешно (отсутствуют ли ошибки).
    /// </summary>
    /// <returns>True, если ошибок нет; иначе false.</returns>
    public bool IsValid() => Errors.Count == 0; 
    
    /// <summary>
    /// Добавляет ошибку в список ошибок.
    /// </summary>
    /// <param name="error">Текст ошибки.</param>
    public void AddError(string error)
    {
        if (!string.IsNullOrWhiteSpace(error))
        {
            Errors.Add(error);
        }
    }


    /// <summary>
    /// Добавляет коллекцию ошибок в список ошибок.
    /// </summary>
    /// <param name="errors">Коллекция текстов ошибок.</param>
    public void AddErrors(IEnumerable<string>? errors)
    {
        if (errors is not null) Errors.AddRange(errors);
    }
}