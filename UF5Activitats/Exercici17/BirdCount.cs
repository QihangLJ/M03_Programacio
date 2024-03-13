namespace Object
{
    public class BirdCount
    {
        public int[] BirdsPerDay { get; set; }

        public BirdCount(int[] birdsPerDay)
        {
            BirdsPerDay = birdsPerDay;
        }

        // 1. Check what the counts were last week
        public static int[] LastWeek()
        {
            int[] lastWeek = [ 0, 2, 5, 3, 7, 8, 4 ];
            return lastWeek;
        }

        // 2. Check how many birds visited today
        public int Today()
        {
            const int Today = 5;
            return BirdsPerDay[Today];
        }

        // 3. Increment today's count
        public void IncrementTodaysCount()
        {
            const int Today = 5;
            BirdsPerDay[Today]++;
        }

        // 4. Check if there was a day with no visiting birds
        public bool HasDayWithoutBirds()
        {
            foreach (int value in BirdsPerDay)
            {
                if (value == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // 5. Calculate the number of visiting birds for the first number of days
        public int CountForFirstDays(int days)
        {
            int sum = 0;
            for (int i = 0; i < days; i++)
            {
                sum += BirdsPerDay[i];
            }
            return sum;
        }

        // 6. Calculate the number of busy days
        public int BusyDays()
        {
            const int BusyDay = 5;
            int count = 0;
            foreach (int value in BirdsPerDay)
            {
                if (value >= BusyDay)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
