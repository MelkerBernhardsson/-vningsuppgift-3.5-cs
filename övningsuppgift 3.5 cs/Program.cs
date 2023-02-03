using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur gammal är du? (svara i år)");
            int ålder = int.Parse(Console.ReadLine());
            Console.WriteLine("vad är din månadslön? (svara i antal kronor)");
            int lön = int.Parse(Console.ReadLine());

            if(ålder == 39)
            {
                Console.WriteLine("du är lika gammal som medelåldern i göteborg");
            }
            else if ( ålder > 39)
            {
                Console.WriteLine("du är äldre än medelåldern i göteborg");
            }
            else if ( ålder < 39)
            {
                Console.WriteLine("du är yngre än medelåldern i göteborg");
            }
            
            if(lön == 36100)
            {
                Console.WriteLine("du tjänar en svensk medellön");
            }
            else if(lön > 36100)
            {
                Console.WriteLine("du tjänar mer än svensk medellön");
            }
            else if (lön < 36100)
            {
                Console.WriteLine("du har en lön som är under svensk medel");
            }
        }
    }
}
