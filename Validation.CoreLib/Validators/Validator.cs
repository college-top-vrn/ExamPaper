using System;
using System.Collections.Generic;
using System.Linq;

using Validation.CoreLib.Core;

namespace Validation.CoreLib.Validators;

/// <summary>
/// Главный класс для реализации механизма валидации. Запускает коллекцию переданных правил для объекта.
/// </summary>
/// <typeparam name="T">Тип проверяемого объекта.</typeparam>
public class Validator<T> : IValidator<T>
{
    /// <inheritdoc />
    public IEnumerable<IValidationRule<T>> Rules { get; }

    /// <summary>
    /// Инициализирует новый экземпляр валидатора с заданным набором правил.
    /// </summary>
    /// <param name="rules">Коллекция правил, реализующих IValidationRule.</param>
    /// <exception cref="ArgumentNullException">Выбрасывается, если коллекция правил равна null.</exception>
    public Validator(IEnumerable<IValidationRule<T>> rules)
    {
        Rules = rules ?? throw new ArgumentNullException(nameof(rules));
    }


    /// <summary>
    /// Выполняет проверку объекта по всем загруженным правилам.
    /// </summary>
    /// <param name="item">Объект для проверки.</param>
    /// <returns>Итоговый результат, содержащий ошибки со всех правил.</returns>
    public ValidationResult Validate(T item)
    {
        var result = new ValidationResult();

        var allErrors = Rules
            .Select(rule => rule.Validate(item))
            .SelectMany(r => r.Errors);

        result.AddErrors(allErrors);
        return result;
    }
}