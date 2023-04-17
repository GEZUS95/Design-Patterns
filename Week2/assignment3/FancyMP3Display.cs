using System;

namespace assignment3
{
    class FancyMP3Display : IObserver
    {
        private IObservable _player;

        public FancyMP3Display(IObservable player)
        {
            this._player = player;
            _player.AddObserver(this);
        }
        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: {song.Title} by {song.Artist} ({song.Duration.ToString(@"mm\:ss")})");        }
    }
}
