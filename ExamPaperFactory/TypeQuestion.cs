namespace ExamPaperFactory;

public class TypeQuestion
{
    
    private string Name { get; init; }
    private string? Description { get; init; }

    public TypeQuestion(string name, string? description)
    {
        if (name == "")
        {
            throw new Exception("имя не может быть пустым");
        }
        else
        {
            Name = name;
        }
        Description = description;
    }
}