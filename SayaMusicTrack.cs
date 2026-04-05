using System;

public class SayaMusicTrack
{
    private int id;
    private string title;
    private int playCount;

    public SayaMusicTrack(string title)
    {
        if (title == null)
        {
            throw new ArgumentException("Judul tidak boleh null");
        }

        if (title.Length > 100)
        {
            throw new ArgumentException("Judul maksimal 100 karakter");
        }

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 10000000)
        {
            throw new ArgumentException("Play count maksimal 10.000.000");
        }

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow!");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
        Console.WriteLine("----------------------");
    }
}