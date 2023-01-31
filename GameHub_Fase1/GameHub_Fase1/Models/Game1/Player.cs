using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub_Fase1.Models.Game1
{
    public class Player
    {
        public int Type = 1;
        public int Position;
        public int Wins;
        public Board[] positions;

        public Player()
        {
        }

        public Player(int type)
        {
            Type = type;
        }

        public Player(int type, int position, int wins)
        {
            Type = type;
            Position = position;
            Wins = wins;
        }

        public void CheckingTimeForPlaying(Player player)
        {
            if (Type % 2 == 0)
            {
                Console.WriteLine("Vez do jogador 1, letra X");
            }
            else
            {
                Console.WriteLine("Vez do jogador 2, letra O");
            }
        }
    }
}
