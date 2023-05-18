using System;
using System.IO;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Handler hand = new Handler();
            robot.Nazad += Handler.HandleBackwardEvent;

            robot.Going();

            
        }

    }
}
