public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
      string[] colorCodes = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

        int first = Array.IndexOf(colorCodes, colors[0]);
        int second = Array.IndexOf(colorCodes, colors[1]);

            return first * 10 + second;
    }
}
