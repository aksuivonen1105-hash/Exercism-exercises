public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        bool IsPangram = true;

        for (int i = 0; i < alphabet.Length; i++)
        {
            char letter = alphabet[i];

            if (!input.ToLower().Contains(letter))
            {
                IsPangram = false;
                break;
            }
        }
        return IsPangram;
    }
}