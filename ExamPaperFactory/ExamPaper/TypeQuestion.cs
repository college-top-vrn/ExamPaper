namespace ExamPaperFactory;

public class TypeQuestion
{
    
    public string Name { get; init; }
    public string? Description { get; init; }

    public TypeQuestion(string name, string? description)
    {
        Name = name;
        Description = description;
    }
}