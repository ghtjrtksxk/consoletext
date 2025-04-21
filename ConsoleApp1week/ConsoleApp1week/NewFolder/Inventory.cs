using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{ 
    public class Inventory
    {
        private Player _player;

        public Items[] inventory_items;

        public Inventory(Player player_info)
        {
            this._player = player_info;

            inventory_items = new Items[]
            {
               new Items("초보자의 검", 3, "초보자의 검이다", 30)
            };
        }

        public void Character_Inventory()
        {

        }
    }
}
