using Validation.CoreLib.Core;
using Validation.CoreLib.Validators;

namespace Test.Test.Validator.Core;

public class UserProfile
{
    public string Username { get; set; }
    public int Age { get; set; }
}

public class UsernameNotEmptyRule : IValidationRule<UserProfile>
{
    public ValidationResult Validate(UserProfile item)
    {
        ValidationResult result = new();
        if (item == null || string.IsNullOrWhiteSpace(item.Username))
        {
            result.AddError("Имя пользователя не может быть пустым.");
        }

        return result;
    }
}

public class AgeAdultRule : IValidationRule<UserProfile>
{
    public ValidationResult Validate(UserProfile item)
    {
        ValidationResult result = new();
        if (item != null && item.Age < 18)
        {
            result.AddError($"Возраст слишком мал: {item.Age}. Регистрациядоступна с 18 лет.");
        }

        return result;
    }
}

public class ValidatorTest
{
    [Fact]
    public void Validate_WhenAllRulesPass_ReturnsValidResult()
    {
        List<IValidationRule<UserProfile>> rules = new() { new UsernameNotEmptyRule(), new AgeAdultRule() };
        UserProfile validUser = new() { Username = "testuser", Age = 20 };

        Validator<UserProfile> validator = new(rules);

        ValidationResult result = validator.Validate(validUser);

        Assert.True(result.IsValid());
    }

    [Fact]
    public void Validate_WhenRulesFail_CollectsAllErrors()
    {
        List<IValidationRule<UserProfile>> rules = new() { new UsernameNotEmptyRule(), new AgeAdultRule() };
        Validator<UserProfile> validator = new(rules);
        UserProfile invalidUser = new() { Username = "", Age = 16 };

        ValidationResult result = validator.Validate(invalidUser);

        Assert.False(result.IsValid());
        Assert.Equal(2, result.Errors.Count);
        Assert.Contains(result.Errors, e => e.Contains("Username"));
        Assert.Contains(result.Errors, e => e.Contains("Age"));
    }

    [Fact]
    public void Validate_WhenNoRulesProvided_ThrowsArgumentNullException()
    {
        IEnumerable<IValidationRule<UserProfile>>? nullRules = null;

        Assert.Throws<ArgumentNullException>(() => new Validator<UserProfile>(nullRules));
    }
}