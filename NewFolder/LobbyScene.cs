using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    class LobbyScene
    {
        private Player _player;
        
        private Status ch_status;
        private Inventory ch_inventory;
        private Shop item_shop;

        bool isGameOver = false;

        public LobbyScene(Player player_info)
        {
            this._player = player_info;
            this.ch_status = new Status(player_info);
            this.ch_inventory = new Inventory();
            this.item_shop = new Shop(player_info);
        }
        
        public void Lobby() 
        {
            while (!isGameOver)
            {
                Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine($"스파르타 마을에 오신 {_player.name} 님, 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");

                Console.WriteLine("1. 상태 보기 \n2. 인벤토리 \n3. 상점\n\n0. 게임종료");
                Console.Write("원하시는 행동을 입력해주세요. : ");

                string MainScene_input = Console.ReadLine();

                switch (MainScene_input)
                {
                    case "1":
                        ch_status.CharacterStatus();
                        break;
                    case "2":
                        ch_inventory.Character_Inventory();
                        break;
                    case "3":
                        item_shop.itemShop();
                        break;
                    case "0":
                        isGameOver = true;
                        break;
                    default:
                        Console.Write("잘못된 입력입니다.");
                        break;
                }
            }
        }
    }
}
