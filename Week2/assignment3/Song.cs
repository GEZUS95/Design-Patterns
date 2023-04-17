using System;

namespace assignment3
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set;}

        public Song(string artist, string title, TimeSpan duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }
    }
}
