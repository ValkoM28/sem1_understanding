namespace Session07;

public class MusicPlayer
{
    public void Play(Playlist playlist)
    {
        Song song = playlist.Songs[playlist.CurrentSongIndex++];
        //playlist.
        Console.WriteLine($"Playlist {playlist.Name} is palying: {song.Artist} - {song.Title}: {song.Genre} - {song.Duration} seconds");
    }


    public void Play(Song song)
    {
        Console.WriteLine("Song is playing");
    }
}