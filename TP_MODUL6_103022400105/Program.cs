using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat instance dari kelas SayaMusicTrack
        SayaMusicTrack track = new SayaMusicTrack("Ambatukam Termuwani");


        // NORMAL
        // Meningkatkan play count 
        track.IncreasePlayCount(99);
        // Menampilkan detail track
        track.PrintTrackDetails();

        Console.WriteLine("=== TEST ERROR ===");

        // Test overflow
        for (int i = 0; i < 50; i++)
        {
            // Meningkatkan play count dengan nilai yang sangat besar untuk menguji overflow
            track.IncreasePlayCount(int.MaxValue);
        }
    }
}