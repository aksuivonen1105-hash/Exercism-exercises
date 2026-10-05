public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        bool hasLetter = false;
        bool isYelling = true;

        foreach (char c in statement)
     {
            if (char.IsLetter(c))
        {
           hasLetter = true;

            if (!char.IsUpper(c))
            {
            isYelling = false;
            }
        }
     
    }

    if (string.IsNullOrWhiteSpace(statement))
    {
        return "Fine. Be that way!";
    }
        
    else if (isYelling && hasLetter && statement.EndsWith("?"))
    {
        return "Calm down, I know what I'm doing!";
    }

    else if (isYelling && hasLetter)
    {
        return "Whoa, chill out!";
    }

    else if (statement.EndsWith("?"))
    {
        return "Sure.";
    }
    else
    {
        return "Whatever.";
    }

        
                              
    }
}