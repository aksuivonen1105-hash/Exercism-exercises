public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ending;
        
       if (number % 10 == 1 && number % 100 != 11)
       {
           ending = "st";
       }
        else if (number % 10 == 2 && number % 100 != 12)
        {
            ending = "nd";
        }
        else if (number % 10 == 3 && number % 100 != 13)
        {
            ending = "rd";
        }
        else
        {
            ending = "th";
        }

        return $"{name}, you are the {number}{ending} customer we serve today. Thank you!";
      
    }
}
