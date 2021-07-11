using System;

namespace FacadeCS
{
    public class CDPlayer{
             public void On(){
                Console.WriteLine("Player On");
            }

            public void Off(){
                Console.WriteLine("Player Off");
            }

            public void Play(string movie){
                Console.WriteLine("Playing " + movie);
            }

            public void Pause(string movie){
                Console.WriteLine("Pausing " + movie);
            }

            public void Stop(){
                Console.WriteLine("Stopping movie");
            }
        }
}
