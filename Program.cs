class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaMusicTrack lagu = new SayaMusicTrack("Lagu Testing");

            for (int i = 0; i < 5; i++)
            {
                lagu.IncreasePlayCount(2000000);
            }

            lagu.PrintTrackDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}