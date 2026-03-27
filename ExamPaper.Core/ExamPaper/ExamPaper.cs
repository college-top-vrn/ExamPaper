namespace ExamPaper.Core.ExamPaper;

public class ExamPaper
{
    public int Number { get; }
    public List<Question>  Questions { get; }

    public ExamPaper(int number, List<Question> questions)
    {
        Number = number;
        Questions = questions;
    }
}
//