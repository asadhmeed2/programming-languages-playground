

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeekCount = {0,2,5,3,7,8};
        return lastWeekCount;
    }

    public int Today()
    {
        var length = this.birdsPerDay.Length;
        return this.birdsPerDay[length - 1];
    }

    public void IncrementTodaysCount()
    {
        var length = this.birdsPerDay.Length;
        this.birdsPerDay[length - 1] = this.birdsPerDay[length - 1] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        bool hasDayWithoutBirds = false;
        foreach (int birdsCount in this.birdsPerDay)
        {
            if(birdsCount == 0 && !hasDayWithoutBirds)
            {
                hasDayWithoutBirds = true;
            }
        }
        return hasDayWithoutBirds;
    }

    public int CountForFirstDays(int numberOfDays)
    {

        if(numberOfDays > this.birdsPerDay.Length || numberOfDays < 1)
        {
            return 0;
        }

        int count = 0;

        for(int day = 0; day < numberOfDays; day++)
        {
            count += this.birdsPerDay[day];
        }

        return count;
    }

    public int BusyDays()
    {
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}

