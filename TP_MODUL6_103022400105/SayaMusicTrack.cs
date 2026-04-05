using System;
using System.Diagnostics;

public class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    // Constructor
    public SayaMusicTrack(string title)
    {
        // Precondition
        // Title tidak boleh null dan panjangnya maksimal 100 karakter
        Debug.Assert(title != null, "Title tidak boleh null");
        Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter");

        this.title = title;

        Random rand = new Random();
        this.id = rand.Next(10000, 100000); 

        this.playCount = 0;
    }

    // Method untuk menambah jumlah play count
    public void IncreasePlayCount(int count)
    {
        // Precondition
        // Count harus lebih dari 0 dan tidak boleh melebihi 10.000.000
        Debug.Assert(count > 0, "Count harus lebih dari 0");
        Debug.Assert(count <= 10000000, "Maksimal 10.000.000");

        // Menggunakan checked untuk menangani kemungkinan overflow pada playCount
        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow pada playCount");
        }   
    }

    // Method untuk menampilkan detail track
    public void PrintTrackDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}