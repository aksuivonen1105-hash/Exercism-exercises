using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder result = new StringBuilder();

        foreach (var c in text)
        {
            if (char.IsLower(c))
            {
                 result.Append((char)((c - 'a' + shiftKey) % 26 + 'a'));
            }
            else if (char.IsUpper(c))
            {
                result.Append((char)((c - 'A' + shiftKey) % 26 + 'A'));
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}