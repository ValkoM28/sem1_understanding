namespace Session07;

public class Song
{
    public string? Title { get; set;}
    public string? Artist { get; set;}
    public string? Genre { get; set;}
    public int Duration { get; set;}

    public Song(string? title, string? artist, string? genre, int duration)
    {
        Title = title;
        Artist = artist;
        Genre = genre;
        Duration = duration;
    }

    public Song()
    {
        
    }
}