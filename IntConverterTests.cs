
public class IntConverterTests
{
    private readonly IntConverter _intConverter;

    public IntConverterTests(IntConverter intConverter)
    {
        _intConverter = intConverter;
    }

    public bool RunTests()
    {
        try
        {
            Console.WriteLine(_intConverter.itoa(-10, 2));   // Should print "-1010"
            Console.WriteLine(_intConverter.itoa(100, 8));   // Should print "144"
            Console.WriteLine(_intConverter.itoa(255, 16)); // Should print "FF"
            Console.WriteLine(_intConverter.itoa(0, 10));   // Should print "0"
            return true; 
        }
        catch (Exception)
        {
            return false; 
        }
    }
} 