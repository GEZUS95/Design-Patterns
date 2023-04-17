using System;
using System.Collections.Generic;

namespace assignment3
{
    public class MP3Player : IObservable
    {
        private Random _rnd = new Random(2);
        private List<Song> _songs = new List<Song>();
        public Song CurrentSong { get; private set; }
        private List<IObserver> _mp3Displays = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            _mp3Displays.Add(observer);
        }
        //static Random rnd;
        public void NextSong()
        {
            int newIndex = _rnd.Next(_songs.Count);
            CurrentSong = _songs[newIndex];
            foreach (IObserver display in _mp3Displays)
            {
                display.Update(CurrentSong);
            }
            Console.WriteLine();
        }
        
        public void RemoveObserver(IObserver observer)
        {
            _mp3Displays.Remove(observer);
        }

        public MP3Player()
        {
            _songs.Add(new Song("Editors", "Papillon", new TimeSpan(0, 5, 24)));
            _songs.Add(new Song("Pink Floyd", "Wish You Were Here", new TimeSpan(0, 5, 39)));
            _songs.Add(new Song("Led Zeppelin", "Dazed and Confused", new TimeSpan(0, 6, 26)));
            _songs.Add(new Song("Bruno Mars", "Billionaire", new TimeSpan(0, 3, 31)));
        }
    }
}
