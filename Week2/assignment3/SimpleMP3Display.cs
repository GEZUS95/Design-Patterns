using System;

namespace assignment3
{
    class SimpleMP3Display : IObserver
    {
        private IObservable _player;
        public SimpleMP3Display(IObservable player)
        {
            this._player = player;
            _player.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Simple Display: {song.Artist} - {song.Title}");
        }
    }
}
