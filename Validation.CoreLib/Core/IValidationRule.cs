namespace Validation.CoreLib.Core;

/// <summary>
/// Определяет контракт для реализации правил проверки валидации.
/// </summary>
/// <typeparam name="T">Тип объекта, который подлежит проверке.</typeparam>
public interface IValidationRule<T>
{
    /// <summary>
    /// Выполняет проверку переданного объекта.
    /// </summary>
    /// <param name="item">Объект для проверки.</param>
    /// <returns>Результат валидации с возможными ошибками.</returns>
    ValidationResult Validate(T item);
}