using System;

namespace FacadeCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now the client need not worry about all the internals of watching a movie. Our Facade class in the background takes care of that
            // This helped us to avoid the tight coupling between client and complex home theatre system.
            HomeTheatreFacade homeTheatreFacade = new HomeTheatreFacade(new Screen(), new CDPlayer(), new TheatreLights());
            homeTheatreFacade.WatchMovie("Game Of Thrones");
            homeTheatreFacade.EndMovie();
        }
    }
}
