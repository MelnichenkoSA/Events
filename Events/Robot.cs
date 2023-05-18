using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Robot
    {
        Random rnd = new Random();
        int x;
        public delegate void Sobytie();
        public event Sobytie Nazad;
        public void Going()
        {
            for (int i = 0; i < 20; i++)
            {
                x = rnd.Next(1, 5);
                switch(x)
                {
                    case 1:
                        Console.WriteLine("Vpered");
                        break;
                    case 2:
                        Console.WriteLine("Naravo");
                        break;
                    case 3:
                        Console.WriteLine("Nalevo");
                        break;
                    case 4:
                        Console.WriteLine("Nazad");
                        Nazad.Invoke();
                        break;
                }    
            }
        }
    }
}
