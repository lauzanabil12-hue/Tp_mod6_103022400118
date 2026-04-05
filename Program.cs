class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu1 = new SayaMusicTrack("Lagu A");
        SayaMusicTrack lagu2 = new SayaMusicTrack("Lagu B");

        lagu1.IncreasePlayCount(5);
        lagu2.IncreasePlayCount(3);

        lagu1.PrintTrackDetails();
        lagu2.PrintTrackDetails();
    }
}