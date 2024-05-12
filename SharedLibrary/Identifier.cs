public class Identifier
{
    public string Value { get; private set; }
    public IdentifierType Type { get; private set; }

    private Identifier(string value, IdentifierType type)
    {
        Value = value;
        Type = type;
    }

    public static Either<Identifier, string> Create(string value)
    {
        if (value.Length == 11 && value.All(char.IsDigit) && value[0] != '0' && IsValidTCKN(value))
        {
            return new Either<Identifier, string>(new Identifier(value, IdentifierType.TCKN));
        }
        else if (value.Length == 10 && value.All(char.IsDigit) && IsValidVKN(value))
        {
            return new Either<Identifier, string>(new Identifier(value, IdentifierType.VKN));
        }
        else
        {
            return new Either<Identifier, string>("Invalid identifier format.");
        }
    }

    private static bool IsValidTCKN(string value)
    {
        int[] digits = value.Select(c => int.Parse(c.ToString())).ToArray();
        int sumOdd = digits[0] + digits[2] + digits[4] + digits[6] + digits[8];
        int sumEven = digits[1] + digits[3] + digits[5] + digits[7];

        int checkDigit10 = (sumOdd * 7 - sumEven) % 10;
        if (checkDigit10 != digits[9])
            return false;

        int totalSum = digits.Take(10).Sum();
        int checkDigit11 = totalSum % 10;
        if (checkDigit11 != digits[10])
            return false;

        return true;
    }

    private static bool IsValidVKN(string value)
    {
        int[] digits = value.Select(c => int.Parse(c.ToString())).ToArray();
        int controlDigit = digits.Last();
        int[] r = new int[digits.Length - 1];

        for (int i = 0; i < digits.Length - 1; i++)
        {
            int mod = (digits[i] + 10 - (i + 1)) % 10;
            if (mod == 9)
            {
                r[i] = mod;
            }
            else
            {
                int pow = (int)Math.Pow(2, 10 - (i + 1));
                r[i] = (mod * pow) % 9;
            }
        }

        int total = r.Sum();
        int computedControl = (10 - (total % 10)) % 10;

        return computedControl == controlDigit;
    }

    public override string ToString()
    {
        return $"{Type}: {Value}";
    }
}

public enum IdentifierType
{
    TCKN,
    VKN
}
