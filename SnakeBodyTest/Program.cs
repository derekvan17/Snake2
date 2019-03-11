using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
        restart:
            Console.Clear();
            Game.Start();
            Init.Board();
            Init.Apple();
            Init.Snake();
            Move.Body();
            Console.Clear();
            Console.WriteLine("You scored {0} on {1} difficulty", Draw.snakeLength, Game.diffSel);
            Console.WriteLine("Press any key to play again. Press ctrl + c to exit.");
            Console.ReadLine();
            goto restart;
        }
    }
}
