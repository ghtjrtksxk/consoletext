using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    internal class MainScene
    {
        static void Main(string[] args)
        {
            GameManager game = new MyGame();
            game.StartGame();
        }
    }
}
