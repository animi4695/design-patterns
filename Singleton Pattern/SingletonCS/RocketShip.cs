using System.Threading;
using System;

namespace SingletonCS
{
    class RocketShip
    {
        // 1. private constructor
        private RocketShip() {}

        // 2. private static instance of class
        private static RocketShip rocketShip;
        private static readonly object mutex = new object();

        // 3. static factory method to get the instance of class.
        public static RocketShip GetInstance() {
            if(rocketShip == null){
                lock(mutex){
                    rocketShip = new RocketShip();
                }
            }
            return rocketShip;
        }
    }
}
