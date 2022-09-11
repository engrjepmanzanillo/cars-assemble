using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed <= 10 && speed != 0)
        {
            if(speed <= 9)
            {
                if(speed <=8)
                {
                    if(speed <=4)
                    {
                        return 1.00d;
                    }
                    return 0.90d;
                }
                return 0.80d;
            }
            return 0.77;
        }
        return 0.00d;
    }
    
    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => Convert.ToInt32(Math.Floor(ProductionRatePerHour(speed) / 60));

}
