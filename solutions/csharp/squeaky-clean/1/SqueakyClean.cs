using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        
        StringBuilder result = new StringBuilder();

        bool uppercaseNext = false;


        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                result.Append('_');
            }
            else if (char.IsControl(c))
            {
                result.Append("CTRL");
            }
            else if (c == '-')
            {
                uppercaseNext = true;
            }
            else if(uppercaseNext)
            {
                result.Append(char.ToUpper(c));
                    uppercaseNext = false;
            }
            else if (!char.IsLetter(c))
            {
            }
            else if (c >= 'α' && (c <= 'ω'))
            {
            }

            
            else
            {
                result.Append(c);
            }
            
        }
        return result.ToString();
    }

}
