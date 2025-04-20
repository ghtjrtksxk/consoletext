using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1week.NewFolder
{
    class Status
    {
        private Player _player;

        string Status_input;
        bool Status_window_on = true;

        public Status(Player player_info)
        {
            this._player = player_info;
        }

        public void CharacterStatus()
        {
            while (Status_window_on)
            {
                Console.Clear();
                Console.WriteLine($"{_player.name} 님의 상태");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");

                Console.WriteLine($"Lv : {_player.level}");
                Console.WriteLine($"공격력 : {_player.ATK}");
                Console.WriteLine($"직업 : {_player.job}");
                Console.WriteLine($"방어력 : {_player.DEF}");
                Console.WriteLine($"Gold : {_player.gold} G");
                Console.WriteLine($"체력 : {_player.HP}");

                Console.WriteLine("\n0. 나가기\n");

                int result = LobbyScene.CheckInput(0, 0);
                switch (result)
                {
                    case 0:
                        Status_window_on = false;
                        break;
                }
            }
        }
    }
}
