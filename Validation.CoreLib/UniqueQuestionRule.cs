// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

public class Question
{
    public string Text { get; set; }
}

public class UniqueQuestionRule
{
    public bool IsValid(Question[] question)
    {
        if (question == null)
            return true;
        
        return question 
            .Where(q => q != null && !string.IsNullOrWhiteSpace(q.Text))
            .Select(q => q.Text.Trim())
            .GroupBy(t => t)
            .All(g => g.Count() == 1);
    }
}