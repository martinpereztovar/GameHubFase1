using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub_Fase1.Models.Game1
{
    public class Board
    {
        string[] positions = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public Board()
        {
        }

        public void printBoard()
        {
            Console.WriteLine("         JOGO DA VELHA"     );
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine($"  |   {positions[0]}   |   {positions[1]}   |   {positions[2]}   |");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine($"  |   {positions[3]}   |   {positions[4]}   |   {positions[5]}   |");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine($"  |   {positions[6]}   |   {positions[7]}   |   {positions[8]}   |");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
        }

        public void clearBoard()
        {
            Console.Clear();
        }
    }
}
