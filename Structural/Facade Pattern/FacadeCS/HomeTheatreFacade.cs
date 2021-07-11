using System;

namespace FacadeCS
{
    public class HomeTheatreFacade
    {
        // TO Keep Things simple, I have created only few classes but you get the idea of complex system.
        // We can add other classes like Volume controls, Display controls, Projector etc.
        Screen screen;
        CDPlayer cDPlayer;
        TheatreLights theatreLights;

        public HomeTheatreFacade(Screen screen, CDPlayer cDPlayer, TheatreLights theatreLights){
            this.screen = screen;
            this.cDPlayer = cDPlayer;
            this.theatreLights = theatreLights;
        }

        public void WatchMovie(String movie){
            Console.WriteLine("Get Ready to watch a movie...");
            screen.Down();
            theatreLights.Dim();
            cDPlayer.On();
            cDPlayer.Play(movie);
        }

        public void EndMovie(){
            Console.WriteLine("Shutting the movie theatre down...");
            theatreLights.On();
            screen.Up();
            cDPlayer.Stop();
            cDPlayer.Off();
        }
    }
}
