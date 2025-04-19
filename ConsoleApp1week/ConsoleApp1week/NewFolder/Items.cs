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
        public string itemNumber;
        public string itemEquipState;
        public string name;
        public int itemStat;
        public string description;
        public string buyState;
        public int price;


        public Items(string itemNumber, string itemEquipState, string name, int itemStat, string description, string buyState, int price)
        {
            this.itemNumber = itemNumber;
            this.itemEquipState = itemEquipState;
            this.name = name;
            this.itemStat = itemStat;
            this.description = description;
            this.buyState = buyState;
            this.price = price;
        }
    }
}
