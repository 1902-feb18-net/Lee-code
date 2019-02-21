using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegates
{
    class MoviePlayer
    {
        public Movie CurrentMovie { get; set; }

        // declares a new delegate type
        public delegate void MovieFinishedHandler();

        public event MovieFinishedHandler MovieFinished;

        // will return true if success, false if not
        public bool Play()
        {
            Thread.Sleep(3000);

            MovieFinished?.Invoke();

            return false;
        }

        
    }
}
