using Validation.CoreLib.Core;

namespace Validation.CoreLib.FactoryOptionsRules;

public class FactoryOptions 
{
    public int QuantityQuestion { get; set; }
}

public class ValidatorOptionsRules : IValidationRule<FactoryOptions> 

{
    public ValidationResult Validate(FactoryOptions item)
    {
        var result = new ValidationResult();
        if (item is null)
        {
            result.AddError("Настройка фабрики не указана либо null");
            return result;
        }

        if (item.QuantityQuestion <= 0)
        {
            result.AddError("Количество вопросов должно быть больше 0");
        }
        return result;
    }
    
}