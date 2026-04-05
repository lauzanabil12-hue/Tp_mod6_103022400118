using System;

public class SayaMusicTrack
{
    private int id;
    private string title;
    private int playCount;

    public SayaMusicTrack(string title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
        Console.WriteLine("----------------------");
    }
}