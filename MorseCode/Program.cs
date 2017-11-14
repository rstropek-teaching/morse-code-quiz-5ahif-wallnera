using System;
using Enigma;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Morse-File: " + args[0]);
            Console.WriteLine("Decoded File: " + args[1]);
                if (args[0] != null && args[1] != null)
                {

                    FileControl fcon = new FileControl();

                    Console.WriteLine("Morse-File: " + args[0]);
                    Console.WriteLine("Decoded File: " + args[1]);
                    fcon.encodeFileByLine(@args[0], @args[1]);

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } catch(Exception e)
            {
                Console.Error.Write("Wrong Path or File! Exception: "+e.Message);
                Console.Error.WriteLine("Press any key to continue...");
            }
        }
    }
}
