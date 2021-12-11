using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSounds
{
    class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("KURA-KURA-PARROT-HELLO-KURA");
        }
    }
}
