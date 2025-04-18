using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    internal abstract class GameManager
    {
        public static GameManager Instance { get; protected set; }

        protected GameManager()
        {
            Instance = this;
        }

        public abstract void StartGame();
    }
}
