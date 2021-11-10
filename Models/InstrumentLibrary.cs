using System;

namespace InstrumentLibrary.Models
{
    public abstract class Instrument
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }

        public Instrument(string _name)
        {
            Name = _name;
        }

        public abstract void Play();
    }

    public class Guitar : Instrument
    {
        public Guitar(string _name) : base(_name)
        { }

        public override void Play()
        {
            Console.WriteLine($"I am playing {Name} Guitar");
        }
    }

    public class Mandolin : Instrument
    {
        public Mandolin(string _name) : base(_name)
        { }

        public override void Play()
        {
            Console.WriteLine($"I am playing {Name} Mandolin");
        }
    }

    public class Ukulele : Instrument
    {
        public Ukulele(string _name) : base(_name)
        { }

        public override void Play()
        {
            Console.WriteLine($"I am playing {Name} Ukulele");
        }
    }
}
