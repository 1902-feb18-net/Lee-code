using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var moviePlayer = new MoviePlayer()
            {
                CurrentMovie = Movie.StarWars5
            };

            MoviePlayer.MovieFinishedHandler handler = EjectDisk;

            moviePlayer.MovieFinished += handler;

            Console.WriteLine("playing movie");

            moviePlayer.Play();

            moviePlayer.MovieFinished += () =>
            {
                Console.WriteLine("Lambda expression");
            };
        }

        public static void EjectDisk()
        {
            Console.WriteLine("Ejecting Disk");
        }
    }
}
