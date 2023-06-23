class ClockAngle
{

    public static void Run()
    {
        bool inputDone = false;
        int hours = 0, mins = 0;
        while (!inputDone)
        {
            try
            {
                Console.WriteLine("Enter the hour (Between 0 and 23):");
                hours = Convert.ToInt32(Console.ReadLine());
                if (hours < 0 || hours > 23)
                {
                    Console.WriteLine("Invalid hour");
                }
                else
                {
                    Console.WriteLine("Enter the minutes (Between 0 and 59):");
                    mins = Convert.ToInt32(Console.ReadLine());
                    if (mins < 0 || mins > 59)
                    {
                        Console.WriteLine("Invalid minutes");
                    }
                    else
                        inputDone = true;

                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Wrong input");
            }
        }
        double angle = CalcAngle(hours, mins);
        Console.WriteLine($"The angle between hours and minutes hands = {angle} degrees");
    }

    private static double CalcAngle(int hours, int mins)
    {
        double minsAngle = mins / 60.0 * 360;
        if(hours >= 12)
            hours -= 12;
        double hoursAngle = (hours + mins / 60.0) / 12.0 * 360;
        double dif = Math.Abs(hoursAngle - minsAngle);
        if(dif>180)
            dif = 360 - dif;
        return dif;
    }
}
