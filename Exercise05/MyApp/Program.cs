namespace Session07;

public class Program
{
    public static void Main()
    {
        MusicPlayer musicPlayer = new();
        Playlist playlistElectronic = new();
        Playlist playlistClassRock = new();
        Song songElectronic1 = new("Dead Star", "Covenant", "EBM", 336);
        Song songElectronic2 = new("24k MAgic", "Bruno Mars", "Pop", 227);
        Song songClassicRock1 = new("Dream On", "Steve Jobs", "Rock", 450);
        Song songClassicRock2 = new("Bohemian Rapsody", "The Queens", "Rock", 550);
        Song songClassicRock3 = new("We were Rocky", "ACDC", "Rock", 400);

        playlistElectronic.Name = "Electronic playlist";
        playlistClassRock.Name = "Classic Rock Playlist";

        playlistElectronic.Songs.Add(songElectronic1);
        playlistElectronic.Songs.Add(songElectronic2);
        playlistClassRock.Songs.Add(songClassicRock1);
        playlistClassRock.Songs.Add(songClassicRock2);
        playlistClassRock.Songs.Add(songClassicRock3);
        musicPlayer.Play(playlistElectronic);
        musicPlayer.Play(playlistClassRock);
        musicPlayer.Play(playlistElectronic);
        musicPlayer.Play(playlistClassRock);
        musicPlayer.Play(playlistClassRock);
    }
}