Dictionary<char, int> romanDigits = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

Console.WriteLine(RomanToInt("LVII", romanDigits));
static int RomanToInt(string s, Dictionary<char, int> romanDigits)
{
    int result = 0;

    for (int i = 0; i < s.Length - 1; i++)
    {
        if (romanDigits[s[i]] < romanDigits[s[i + 1]])
            result -= romanDigits[s[i]];
        else
            result += romanDigits[s[i]];
    }

    return result + romanDigits[s[s.Length - 1]];
}