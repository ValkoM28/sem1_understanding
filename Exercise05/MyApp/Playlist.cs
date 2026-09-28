namespace Session07;

public class Playlist
{
    public string? Name { get; set;}
    public List<Song> Songs { get; set;} = [];
    public int CurrentSongIndex { get; set;}
}