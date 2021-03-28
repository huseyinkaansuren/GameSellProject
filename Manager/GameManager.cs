using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Game Added");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Game Deleted");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("Game Updated");
        }
    }
}
