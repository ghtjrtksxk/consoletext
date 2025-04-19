using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    class Player
    {
        public string name;
        public int level;
        public int HP;
        public int ATK;
        public int DEF;
        public int gold;
        public Job job;

        public Player(string name, Job job = Job.Tanker)
        {
            this.name = name;
            this.job = job;
            this.level = 1;
            this.ATK = 10;
            this.DEF = 5;
            this.HP = 10;
            this.gold = 10000;
        }
    }

    public enum Job
    {
        Tanker = 1,
        Assassin,
        Sniper
    }
}
