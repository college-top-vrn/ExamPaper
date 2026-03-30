using Validation.CoreLib.Core;

namespace Test.Test.Validator.Core;

public class ValidationResultTest
{
    [Fact]
    public void Errors_List_Is_Initially_Empty()
    {
        ValidationResult result = new();

        Assert.True(result.IsValid());
    }

    [Fact]
    public void IsValid_Returns_False_When_Errors_Are_Not_Empty()
    {
        ValidationResult result = new();
        result.AddError("Ошибка 1");

        Assert.False(result.IsValid());
    }

    [Fact]
    public void AddError_Adds_NonEmpty_String_Error()
    {
        ValidationResult result = new();

        result.AddError("Ошибка проверки");

        Assert.Contains("Ошибка проверки", result.Errors);
    }

    [Fact]
    public void AddError_Ignores_Null_Error()
    {
        ValidationResult result = new();

        result.AddError(null!);

        Assert.Empty(result.Errors);
    }

    [Fact]
    public void AddError_Ignores_Empty_String_Error()
    {
        ValidationResult result = new();

        result.AddError("");
        result.AddError("   ");

        Assert.Empty(result.Errors);
    }

    [Fact]
    public void AddErrors_Adds_NonNull_Collection()
    {
        ValidationResult result = new();
        string[] errors = new[] { "Ошибка 1", "Ошибка 2" };


        result.AddErrors(errors);

        Assert.Equal(2, result.Errors.Count);
        Assert.Contains("Ошибка 1", result.Errors);
        Assert.Contains("Ошибка 2", result.Errors);
    }

    [Fact]
    public void AddErrors_Ignores_Null_Collection()
    {
        ValidationResult result = new();

        result.AddErrors(null);

        Assert.Empty(result.Errors);
    }

    [Fact]
    public void AddErrors_Does_Not_Throw_On_Empty_Collection()
    {
        ValidationResult result = new();
        string[] errors = Array.Empty<string>();

        result.AddErrors(errors);
        Assert.Empty(result.Errors);
    }

    [Fact]
    public void AddError_And_AddErrors_Combine_Correctly()
    {
        ValidationResult result = new();
        string[] additionalErrors = new[] { "Ошибка 2", "Ошибка 3" };

        result.AddError("Ошибка 1");
        result.AddErrors(additionalErrors);

        Assert.Equal(3, result.Errors.Count);
        Assert.Contains("Ошибка 1", result.Errors);
        Assert.Contains("Ошибка 2", result.Errors);
        Assert.Contains("Ошибка 3", result.Errors);
    }
}