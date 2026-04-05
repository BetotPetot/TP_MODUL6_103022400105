using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat instance dari kelas SayaMusicTrack
        SayaMusicTrack track = new SayaMusicTrack("Ambatukam Termuwani");

        // Meningkatkan play count 
        track.IncreasePlayCount(99);
        // Menampilkan detail track
        track.PrintTrackDetails();
    }
}