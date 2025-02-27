public static class Mathematics
{
    public const string BASE_16_CHARACTERS = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static int Abs(int value)
    {
        return (value < 0) ? -value : value;
    }
} 