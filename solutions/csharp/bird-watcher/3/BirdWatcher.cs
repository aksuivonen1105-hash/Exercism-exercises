class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today()
    {
       return birdsPerDay[6];
    }

    public void IncrementTodaysCount() => birdsPerDay[6]++;
    
    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < birdsPerDay.Length; i++)

            if (birdsPerDay[i] == 0)
            {
                return true;
            }
            return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
       int total = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            total = total + birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
       int BusyDays = 0;

        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
            {
                BusyDays++;
            }
        }
        return BusyDays;
    }
}
