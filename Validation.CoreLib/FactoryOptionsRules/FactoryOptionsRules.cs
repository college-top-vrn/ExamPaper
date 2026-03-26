namespace Validation.CoreLib.FactoryOptionsRules;

public class FactoryOptions
{
    public int QuantityQuestion { get; set; }
}

public class ValidatorOptionsRules
{
    public bool IsValid(FactoryOptions options)
    {
        if (options is null) return false;

        return options.QuantityQuestion > 0;
    }
}