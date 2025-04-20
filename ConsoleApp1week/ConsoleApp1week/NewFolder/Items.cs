using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    class Items
    {
        public string name;
        public int itemStat;
        public string description;
        public int price;


        public Items(string name, int itemStat, string description, int price)
        {
            this.name = name;
            this.itemStat = itemStat;
            this.description = description;
            this.price = price;
        }
    }
}
