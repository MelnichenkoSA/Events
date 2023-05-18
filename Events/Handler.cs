using System;
using System.IO;

namespace Events
{
    class Handler
    {
        public static void HandleBackwardEvent()
        {
            using (StreamWriter sw = new StreamWriter("test.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine("Backward event happened");
            }
        }
    }
}
