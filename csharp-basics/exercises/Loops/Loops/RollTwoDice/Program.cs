using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTwoDice
{
    class RollTwoDice
    {
        private Random ran = new Random();
        private int dice1 = 0;
        private int dice2 = 0;
        private int sum = 0;

        public RollTwoDice()
        {
            Console.Write("Desired sum: ");
            sum = int.Parse(Console.ReadLine());

            RollDice();
        }

        private void RollDice()
        {
            while (dice1 + dice2 != sum)
            {
                dice1 = ran.Next(0, 6) + 1;
                dice2 = ran.Next(0, 6) + 1;
                Console.WriteLine("{0} and {1} = {2}", dice1, dice2, (dice1 + dice2));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RollTwoDice dice = new RollTwoDice();

            Console.Read();
        }
    }
}
