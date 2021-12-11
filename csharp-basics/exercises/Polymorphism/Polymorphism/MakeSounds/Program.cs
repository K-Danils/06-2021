using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sounds = new List<ISound>();

            sounds.Add(new Firework());
            sounds.Add(new Parrot());
            sounds.Add(new Radio());
            sounds.Add(new Firework());
            sounds.Add(new Radio());
            sounds.Add(new Parrot());

            sounds.ForEach(sound => sound.PlaySound());

            Console.ReadKey();
        }
    }
}
