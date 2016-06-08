using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class Program
    {
        static void Main(string[] args)
        {
            //choose first player
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            Console.Clear();

            GameState gs = new GameState(name);
            


            gs.printBoard();

            Console.Read();

        }
    }
}
