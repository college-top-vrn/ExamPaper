using System.Collections.Generic;

namespace Validation.CoreLib.Core;

/// <summary>
/// Определяет контракт для механизма валидации, который запускает набор правил.
/// </summary>
/// <typeparam name="T">Тип проверяемого объекта.</typeparam>
public interface IValidator<in T>
{
    /// <summary>
    /// Коллекция правил валидации, реализующих IValidationRule.
    /// </summary>
    IEnumerable<IValidationRule<T>> Rules { get; }

    /// <summary>
    /// Прогоняет объект через все зарегистрированные правила валидации.
    /// </summary>
    /// <param name="item">Объект для проверки.</param>
    /// <returns>Общий результат всех проверок.</returns>
    ValidationResult Validate(T item);
}