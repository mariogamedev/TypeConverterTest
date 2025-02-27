
public interface IConverterInputValidator
{
    void Validate(int numericBase);
}

public class IntConverterValidator : IConverterInputValidator
{
    private const int MIN_VALUE_BASE = 2;
    private const int MAX_VALUE_BASE = 16;

    public void Validate(int numericBase)
    {
        if (numericBase < MIN_VALUE_BASE || numericBase > MAX_VALUE_BASE)
            throw new ArgumentOutOfRangeException(nameof(numericBase), "Base must be in the range " + MIN_VALUE_BASE + "- " + MAX_VALUE_BASE);
    }
} 