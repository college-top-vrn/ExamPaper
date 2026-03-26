namespace ExamPaperFactory;

public class Question
{
    private string _question { get; init; }
    private TypeQuestion _type { get; init; }

    public Question(string question, TypeQuestion type)
    {
        if (question == "")
        {
            throw new Exception("Вопрос не должен быть пустым");
        }
        else
        {
            _question = question;
        }

        if (type == null)
        {
            throw new Exception(" Тип не может быть пустым");
        }
        else
        {
            _type = type;
        }
    }
}