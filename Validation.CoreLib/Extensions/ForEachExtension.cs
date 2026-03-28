using System;
using System.Collections.Generic;

namespace Validation.CoreLib.Extensions;

/// <summary>
/// Предоставляет метод расширения для перечисления.
/// </summary>
public static class ForEachExtension
{
    /// <summary>
    /// Выполняет указанное действие для каждого элемента перечисления.
    /// </summary>
    /// <typeparam name="T">Тип элементов в перечислении.</typeparam>
    /// <param name="enumeration">Перечисление элементов.</param>
    /// <param name="action">Действие, которое необходимо выполнить для каждого элемента.</param>
    public static void ForEachRule<T>(this IEnumerable<T> enumeration, Action<T> action)
    {
        foreach (T item in enumeration)
        {
            action(item); 
        }
    }
    
}