namespace Test;

public class QuestionTests
{
    public class QuestionTest
    {
        private readonly TypeQuestion _typeExample;

        public QuestionTests()
        {
            _typeExample = new TypeQuestion("MultipleChoice", "Вопрос с выбором ответа");
        }

        [Fact]
        public void Constructor_WhenValidDataPassed_ShouldSetQuestion()
        {
            var expectedQuestionText = "Какой тип данных используется в C# для хранения целых чисел?";

            var question = new Question(expectedQuestionText, _typeExample);

            Assert.Equal(expectedQuestionText, question.Question());
        }

        [Fact]
        public void Constructor_WhenValidDataPassed_ShouldSetQuestionType()
        {
            var expectedQuestionText = "Какой тип данных используется в C# для хранения целых чисел?";

            var question = new Question(expectedQuestionText, _typeExample);

            Assert.Same(_typeExample, question.Type());
        }
    }
}