using System.Text.Json;

namespace ExamPaper.Json;

/// <summary>
/// Класс для сериализации списков любого типа в Json файл и десериализации из Json файла.
/// </summary>
public static class JsonManager
{
    /// <summary>
    /// Метод для десериализции Json файла в список любого типа. 
    /// </summary>
    /// <param name="path">Путь к фаЙлу Json.</param>
    /// <typeparam name="T">Тип любого класса.</typeparam>
    /// <returns>Список из объектов класса T.</returns>
    public static IEnumerable<T> Deserialize<T>(string path) where T : class
    {
        try
        {
            if (!File.Exists(path))
            {
                return [];
            }
            var fileText = File.ReadAllText(path);
            var objects = JsonSerializer.Deserialize<List<T>>(fileText);
            if (objects == null)
            {
                return [];
            }
            return objects;
        }
        catch (JsonException)
        {
            return [];
        }
    }
    /// <summary>
    /// Метод для сериализации в Json файл.  
    /// </summary>
    /// <param name="objects">Список из объектов класса Т.</param>
    /// <param name="path">Путь к файлу Json.</param>
    /// <typeparam name="T">Тип любого класса.</typeparam>
    /// <returns>Ничего.</returns>
    public static void Serialize<T>(IEnumerable<T> objects, string path) where T : class
    {
        var json = JsonSerializer.Serialize(objects);
        File.WriteAllText(path, json);
    }
}