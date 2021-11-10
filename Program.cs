using System;
using InstrumentLibrary.Models;

namespace InstrumentLibrary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Guitar myGuitar = new Guitar("Gibson");
            Mandolin myMandolin = new Mandolin("Kentucky KM-140");
            Ukulele myUkulele = new Ukulele("Ortega");

            myGuitar.Play();
            myMandolin.Play();
            myUkulele.Play();
        }
    }
}
