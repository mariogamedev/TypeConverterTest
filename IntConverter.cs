
public class IntConverter
{
    private readonly IConverterInputValidator _validator;

    public IntConverter(IConverterInputValidator validator)
    {
        _validator = validator;
    }

    public string itoa(int value, int numericBase)
    {
        _validator.Validate(numericBase);
        if (value == 0) return "0";

        string result = "";
        value = Mathematics.Abs(value);

        while (value > 0)
        {
            int remainder = value % numericBase;
            result = Mathematics.BASE_16_CHARACTERS[remainder] + result;
            value /= numericBase;
        }

        if (value < 0)
            return NegativeResult(result);
        else
            return result;
    }

    private string NegativeResult(string result)
    {
        return "-" + result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of IntConverter
        IConverterInputValidator converterValidator = new IntConverterValidator();
        IntConverter intConverter = new IntConverter(converterValidator);
        
        // Run the tests
        IntConverterTests tests = new IntConverterTests(intConverter);
        bool allTestsPassed = tests.RunTests();
        
        Console.WriteLine($"All tests passed: {allTestsPassed}");
    }
}

