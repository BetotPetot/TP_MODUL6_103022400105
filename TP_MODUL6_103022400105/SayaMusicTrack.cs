using System;

public class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    // Constructor
    public SayaMusicTrack(string title)
    {
        this.title = title;

        Random rand = new Random();
        this.id = rand.Next(10000, 100000); 

        this.playCount = 0;
    }

    // Method untuk menambah jumlah play count
    public void IncreasePlayCount(int count)
    {
        // Untuk menambah jumlah
        playCount += count;
    }

    // Method untuk menampilkan detail track
    public void PrintTrackDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}